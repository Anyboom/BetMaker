using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using BetMaker.Models;
using BetMaker.Services;
using LiteDB;

namespace BetMaker.Dialogs
{
    public partial class SaveFileForm : Form
    {
        private List<int> Ids;
        private Regex startedAtRegex = new Regex("{StartedAt([:]?)([A-Za-z \\/:|-]*)}");
        private Regex createdAtRegex = new Regex("{CreatedAt([:]?)([A-Za-z \\/:|-]*)}");
        public SaveFileForm(List<int> ids)
        {
            this.Ids = ids;

            InitializeComponent();

            ManyFileTextBox.Text = Settings.KeyExists("TemplateNameFile")
                ? Settings.Read("TemplateNameFile")
                : "{CreatedAt:hh:mm}-{HomeTeam}-{GuestTeam}.md";

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
            MarkersTemplateLinkLabel.Click += (sender, args) =>
            {
                MessageService.ShowInfo(Settings.ShowHelp);
            };

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

            if ("/\\*?:\"|<>".ToCharArray().Any(x =>
            {
                return ManyFileTextBox.Text.Contains(x);
            }))
            {
                MessageService.ShowError($"Были использованы запрещенные символы в название файла в шаблоне: [/\\*?:\"|<>]");
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
                result = result.Replace("{Coefficient}", bet.Coefficient.ToString("0.00"));
                result = result.Replace("{Result}", bet.Result.ToString());
                result = result.Replace("{Author}", bet.Author);

                foreach (Match match in startedAtRegex.Matches(result))
                {
                    string resultFormat = match.Groups[2].Value;

                    result = result.Replace(match.Value, bet.StartAt.ToString(resultFormat));
                }

                foreach (Match match in createdAtRegex.Matches(result))
                {
                    string resultFormat = match.Groups[2].Value;

                    result = result.Replace(match.Value, bet.CreatedAt.ToString(resultFormat));
                }

                string pathResult = ManyFileTextBox.Text;

                pathResult = pathResult.Replace("{Id}", bet.Id.ToString());
                pathResult = pathResult.Replace("{HomeTeam}", bet.HomeTeam.Name);
                pathResult = pathResult.Replace("{GuestTeam}", bet.GuestTeam.Name);
                pathResult = pathResult.Replace("{Prognosis}", bet.Prognosis.Name);
                pathResult = pathResult.Replace("{Competition}", bet.Competition.Name);
                pathResult = pathResult.Replace("{Coefficient}", bet.Coefficient.ToString("0.00"));
                pathResult = pathResult.Replace("{Result}", bet.Result.ToString());
                pathResult = pathResult.Replace("{Author}", bet.Author);

                foreach (Match match in startedAtRegex.Matches(pathResult))
                {
                    string resultFormat = match.Groups[2].Value;

                    pathResult = pathResult.Replace(match.Value, bet.StartAt.ToString(resultFormat));
                }

                foreach (Match match in createdAtRegex.Matches(pathResult))
                {
                    string resultFormat = match.Groups[2].Value;

                    pathResult = pathResult.Replace(match.Value, bet.CreatedAt.ToString(resultFormat));
                }


                File.WriteAllText(Path.Combine(pathBet, pathResult), result);

            }
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
                    result = result.Replace("{Coefficient}", bet.Coefficient.ToString("0.00"));
                    result = result.Replace("{Result}", bet.Result.ToString());
                    result = result.Replace("{Author}", bet.Author);

                    foreach (Match match in startedAtRegex.Matches(result))
                    {
                        string resultFormat = match.Groups[2].Value;

                        result = result.Replace(match.Value, bet.StartAt.ToString(resultFormat));
                    }

                    foreach (Match match in createdAtRegex.Matches(result))
                    {
                        string resultFormat = match.Groups[2].Value;

                        result = result.Replace(match.Value, bet.CreatedAt.ToString(resultFormat));
                    }


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
