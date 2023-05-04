using System;
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

            ManyFileTextBox.Text = Settings.KeyExists("TemplateNameFile")
                ? Settings.Read("TemplateNameFile")
                : "{CreatedAt}-{HomeTeam}-{GuestTeam}.md";

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

            string createdAtTemplate = Settings.KeyExists("TemplateCreatedAt")
                ? Settings.Read("TemplateCreatedAt")
                : "HH:mm | d MMM yyyy",
                createdAtFileTemplate = Settings.KeyExists("TemplateCreatedAtFile")
                ? Settings.Read("TemplateCreatedAtFile")
                : "HH-mm-dd-MM-yyyy",
                startAtTemplate = Settings.KeyExists("TemplateStartAt")
                ? Settings.Read("TemplateStartAt")
                : "HH:mm | d MMM yyyy",
                startAtFileTemplate = Settings.KeyExists("TemplateStartAtFile")
                ? Settings.Read("TemplateStartAtFile")
                : "HH-mm-dd-MM-yyyy";

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
                result = result.Replace("{StartAt}", bet.StartAt.ToString(startAtTemplate));
                result = result.Replace("{CreatedAt}", bet.CreatedAt.ToString(createdAtTemplate));

                string pathResult = ManyFileTextBox.Text;

                pathResult = pathResult.Replace("{Id}", bet.Id.ToString());
                pathResult = pathResult.Replace("{HomeTeam}", bet.HomeTeam.Name);
                pathResult = pathResult.Replace("{GuestTeam}", bet.GuestTeam.Name);
                pathResult = pathResult.Replace("{Prognosis}", bet.Prognosis.Name);
                pathResult = pathResult.Replace("{Competition}", bet.Competition.Name);
                pathResult = pathResult.Replace("{Coefficient}", bet.Coefficient.ToString("0.00"));
                pathResult = pathResult.Replace("{Result}", bet.Result.ToString());
                pathResult = pathResult.Replace("{Author}", bet.Author);
                pathResult = pathResult.Replace("{StartAt}", bet.StartAt.ToString(startAtFileTemplate));
                pathResult = pathResult.Replace("{CreatedAt}", bet.CreatedAt.ToString(createdAtFileTemplate));

                File.WriteAllText(Path.Combine(pathBet, pathResult), result);
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

            string createdAtTemplate = Settings.KeyExists("TemplateCreatedAt")
                ? Settings.Read("TemplateCreatedAt")
                : "HH:mm | d MMM yyyy",
                createdAtFileTemplate = Settings.KeyExists("TemplateCreatedAtFile")
                ? Settings.Read("TemplateCreatedAtFile")
                : "HH-mm-dd-MM-yyyy",
                startAtTemplate = Settings.KeyExists("TemplateStartAt")
                ? Settings.Read("TemplateStartAt")
                : "HH:mm | d MMM yyyy",
                startAtFileTemplate = Settings.KeyExists("TemplateStartAtFile")
                ? Settings.Read("TemplateStartAtFile")
                : "HH-mm-dd-MM-yyyy";

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
                    result = result.Replace("{StartAt}", bet.StartAt.ToString(startAtTemplate));
                    result = result.Replace("{CreatedAt}", bet.CreatedAt.ToString(createdAtTemplate));

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
