using System;
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
using BetMaker.Services;
using LiteDB;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

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
            SaveButton.Click += (sender, args) => SaveBet();
            MarkersTemplateLinkLabel.Click += (sender, args) => ShowHelp();
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

                    string statusBet = bet.Result switch
                    {
                        BetStatus.NotCalculated => Settings.KeyExists("NotCalculated", "Status") ? Settings.Read("NotCalculated", "Status") : "Не расчитано",
                        BetStatus.Win => Settings.KeyExists("Win", "Status") ? Settings.Read("Win", "Status") : "Выигрыш",
                        BetStatus.Lose => Settings.KeyExists("Lose", "Status") ? Settings.Read("Lose", "Status") : "Проигрыш",
                        BetStatus.Return => Settings.KeyExists("Return", "Status") ? Settings.Read("Return", "Status") : "Возврат"
                    };

                    result = result.Replace("{Id}", bet.Id.ToString());
                    result = result.Replace("{HomeTeam}", bet.HomeTeam.Name);
                    result = result.Replace("{GuestTeam}", bet.GuestTeam.Name);
                    result = result.Replace("{Prognosis}", bet.Prognosis.Name);
                    result = result.Replace("{Competition}", bet.Competition.Name);
                    result = result.Replace("{Coefficient}", bet.Coefficient.ToString());
                    result = result.Replace("{Result}", statusBet);
                    result = result.Replace("{StartAt}", bet.StartAt.ToString("HH:mm | d MMM yyyy"));

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
