﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BetMaker.Models;
using BetMaker.Services;
using LiteDB;

namespace BetMaker.Dialogs
{
    public partial class SaveFileForm : Form
    {
        private List<int> Ids;
        public SaveFileForm(List<int> ids)
        {
            this.Ids = ids;

            InitializeComponent();

            OpenPathButton.Click += (sender, args) => OpenPath();
            SaveButton.Click += (sender, args) =>
            {
                if (ManyFilesCheck.Checked)
                {
                    SaveBetMany();
                }
                else
                {
                    SaveBet();
                }

            };
            MarkersTemplateLinkLabel.Click += (sender, args) => ShowHelp();
            ManyFilesCheck.CheckStateChanged += (sender, args) =>
            {
                ManyFileTextBox.Enabled = ManyFilesCheck.Checked;
            };
        }

        private void SaveBetMany()
        {
            if (string.IsNullOrWhiteSpace(ManyFileTextBox.Text) || string.IsNullOrWhiteSpace(PathTemplateTextBox.Text) || string.IsNullOrWhiteSpace(TemplateTextBox.Text))
            {
                return;
            }

            string dirBet = DateTime.Now.ToString("dd.MM.yyyy"),
                dirMain = "Bets",
                pathBet = Path.Combine(dirMain, dirBet);

            if (Directory.Exists(dirMain) == false)
            {
                Directory.CreateDirectory(dirMain);
            }

            if (Directory.Exists(pathBet) == false)
            {
                Directory.CreateDirectory(pathBet);
            }

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            List<Bet> bets = db.GetCollection<Bet>("Bet").Find(x => Ids.Contains(x.Id)).ToList();

            foreach (Bet bet in bets)
            {
                string result = TemplateTextBox.Text;

                result = result.Replace("{Id}", bet.Id.ToString());
                result = result.Replace("{HomeTeam}", bet.HomeTeam.Name);
                result = result.Replace("{GuestTeam}", bet.GuestTeam.Name);
                result = result.Replace("{Prognosis}", bet.Prognosis.Name);
                result = result.Replace("{Competition}", bet.Competition.Name);
                result = result.Replace("{Coefficient}", bet.Coefficient.ToString());
                result = result.Replace("{Result}", bet.Result.ToString());
                result = result.Replace("{Author}", bet.Author);
                result = result.Replace("{StartAt}", bet.StartAt.ToString("HH:mm | d MMM yyyy"));
                result = result.Replace("{CreatedAt}", bet.CreatedAt.ToString("HH:mm | d MMM yyyy"));

                string pathResult = ManyFileTextBox.Text;

                pathResult = pathResult.Replace("{Id}", bet.Id.ToString());
                pathResult = pathResult.Replace("{HomeTeam}", bet.HomeTeam.Name);
                pathResult = pathResult.Replace("{GuestTeam}", bet.GuestTeam.Name);
                pathResult = pathResult.Replace("{Prognosis}", bet.Prognosis.Name);
                pathResult = pathResult.Replace("{Competition}", bet.Competition.Name);
                pathResult = pathResult.Replace("{Coefficient}", bet.Coefficient.ToString());
                pathResult = pathResult.Replace("{Result}", bet.Result.ToString());
                pathResult = pathResult.Replace("{Author}", bet.Author);
                pathResult = pathResult.Replace("{StartAt}", bet.StartAt.ToString("HH-mm-dd-MM-yyyy"));
                pathResult = pathResult.Replace("{CreatedAt}", bet.CreatedAt.ToString("HH-mm-dd-MM-yyyy"));

                File.WriteAllText(Path.Combine(pathBet, string.Concat(pathResult, ".txt")), result);
            }
        }

        private void ShowHelp()
        {
            StringBuilder stringHelp = new StringBuilder();
            stringHelp.AppendLine("{Id} - идентификатор ставки");
            stringHelp.AppendLine("{HomeTeam} - домашняя команда");
            stringHelp.AppendLine("{GuestTeam} - гостевая команда");
            stringHelp.AppendLine("{Prognosis} - прогноз");
            stringHelp.AppendLine("{Competition} - название сореванования");
            stringHelp.AppendLine("{Coefficient} - коэффициент");
            stringHelp.AppendLine("{Result} - результат");
            stringHelp.AppendLine("{StartAt} - начало матча");
            stringHelp.AppendLine("{CreatedAt} - дата и время создания ставки");
            stringHelp.AppendLine("{Author} - автор ставки");

            MessageService.ShowInfo(stringHelp.ToString());
        }

        private void SaveBet()
        {
            if (string.IsNullOrWhiteSpace(PathTemplateTextBox.Text) || string.IsNullOrWhiteSpace(TemplateTextBox.Text))
            {
                return;
            }

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            List<Bet> bets = db.GetCollection<Bet>("Bet").Find(x => Ids.Contains(x.Id)).ToList();

            string path = default;

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                path = saveFileDialog.FileName;

                foreach (Bet bet in bets)
                {
                    string result = TemplateTextBox.Text;

                    result = result.Replace("{Id}", bet.Id.ToString());
                    result = result.Replace("{HomeTeam}", bet.HomeTeam.Name);
                    result = result.Replace("{GuestTeam}", bet.GuestTeam.Name);
                    result = result.Replace("{Prognosis}", bet.Prognosis.Name);
                    result = result.Replace("{Competition}", bet.Competition.Name);
                    result = result.Replace("{Coefficient}", bet.Coefficient.ToString());
                    result = result.Replace("{Result}", bet.Result.ToString());
                    result = result.Replace("{Author}", bet.Author);
                    result = result.Replace("{StartAt}", bet.StartAt.ToString("HH:mm | d MMM yyyy"));
                    result = result.Replace("{CreatedAt}", bet.CreatedAt.ToString("HH:mm | d MMM yyyy"));

                    File.AppendAllText(path, result);
                }
            }
        }

        private void OpenPath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                PathTemplateTextBox.Text = openFileDialog.FileName;
                TemplateTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
    }
}