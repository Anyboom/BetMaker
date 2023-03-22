﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BetMaker.Models;

using LiteDB;

namespace BetMaker.Dialogs
{
    public partial class SaveForm : Form
    {
        private List<int> Ids;
        public SaveForm(List<int> ids)
        {
            this.Ids = ids;

            InitializeComponent();

            OpenPathButton.Click += (sender, args) => OpenPath();
            SaveButton.Click += (sender, args) => SaveBet();
        }

        private void SaveBet()
        {
            bool inOneFile = InOneFileRadio.Checked;
            bool inOtherFile = InOtherFileRadio.Checked;

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            List<Bet> bets = db.GetCollection<Bet>("Bet").Find(x => Ids.Contains(x.Id)).ToList();

            string path = default;

            if (inOneFile)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";

                DialogResult dialogResult = saveFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                }
            }

            if (inOtherFile)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath;
                }
            }

            foreach (Bet bet in bets)
            {
                string result = TemplateTextBox.Text;
                result = result.Replace("{id}", bet.Id.ToString());
                result = result.Replace("{HomeTeam}", bet.HomeTeam.Name);
                result = result.Replace("{GuestTeam}", bet.GuestTeam.Name);
                result = result.Replace("{Prognosis}", bet.Prognosis.Name);
                result = result.Replace("{Competition}", bet.Competition.Name);
                result = result.Replace("{Coefficient}", bet.Coefficient.ToString());
                result = result.Replace("{Result}", bet.Result.ToString());
                result = result.Replace("{StartAt}", bet.StartAt.ToString("HH:mm | d MMM yyyy"));

                File.AppendAllText(path, result);
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