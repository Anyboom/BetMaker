using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BetMaker.Models;
using BetMaker.Services;
using LiteDB;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BetMaker.Dialogs
{
    public partial class SaveTelegramForm : Form
    {
        private List<int> Ids;
        public SaveTelegramForm(List<int> ids)
        {
            this.Ids = ids;

            InitializeComponent();

            OpenPathButton.Click += (sender, args) => OpenPath();
            SaveButton.Click += (sender, args) => SaveBet();
            MarkersTemplateLinkLabel.Click += (sender, args) => ShowHelp();
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
        private async void SaveBet()
        {
            if (InternetService.CheckConnection() == false)
            {
                MessageService.ShowWarn("Проверьте интернет соединение.");
                return;
            }

            if (string.IsNullOrWhiteSpace(PathTemplateTextBox.Text) || string.IsNullOrWhiteSpace(TemplateTextBox.Text))
            {
                MessageService.ShowWarn("Для сохранения требуется шаблон.");
                return;
            }

            if (Settings.KeyExists("Token", "Telegram") == false ||
                Settings.KeyExists("NameChannel", "Telegram") == false)
            {
                MessageService.ShowWarn("У вас в настройках не заполнены данные: токен бота, ид канала.");
                return;
            }
            

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            List<Bet> bets = db.GetCollection<Bet>("Bet").Find(x => Ids.Contains(x.Id)).ToList();

            TelegramBotClient client = new TelegramBotClient(Settings.Read("Token", "Telegram"));

            foreach (Bet bet in bets)
            {
                string result = TemplateTextBox.Text;

                string statusBet = bet.Result switch
                {
                    BetStatus.NotCalculated => Settings.KeyExists("NotCalculated", "Status") ? Settings.Read("NotCalculated", "Status") : "Не расчитано",
                    BetStatus.Win => Settings.KeyExists("Win", "Status") ? Settings.Read("Win", "Status") : "Выигрыш",
                    BetStatus.Lose => Settings.KeyExists("Lose", "Status") ? Settings.Read("Lose", "Status") : "Проигрыш",
                    BetStatus.Return => Settings.KeyExists("Return", "Status") ? Settings.Read("Return", "Status") : "Возврат",
                    _ => throw new NotImplementedException()
                };
                
                result = result.Replace("{Id}", bet.Id.ToString());
                result = result.Replace("{HomeTeam}", bet.HomeTeam.Name);
                result = result.Replace("{GuestTeam}", bet.GuestTeam.Name);
                result = result.Replace("{Prognosis}", MarkdownService.ToText(bet.Prognosis.Name));
                result = result.Replace("{Competition}", bet.Competition.Name);
                result = result.Replace("{Coefficient}", bet.Coefficient.ToString("0.00"));
                result = result.Replace("{Result}", statusBet);
                result = result.Replace("{Author}", bet.Author);
                result = result.Replace("{StartAt}", bet.StartAt.ToString("HH:mm | d MMM yyyy"));

                try
                {
                    await client.SendTextMessageAsync(Settings.Read("NameChannel", "Telegram"), result, ParseMode.Markdown);

                }
                catch
                {
                    MessageService.ShowWarn("Проверьте правильность токена и название канала.");
                    return;
                }

                DialogResult = DialogResult.OK;

                Close();
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
            stringHelp.AppendLine("{Author} - автор ставки");

            MessageService.ShowInfo(stringHelp.ToString());
        }
    }
}
