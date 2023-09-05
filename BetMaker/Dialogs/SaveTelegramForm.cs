using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private Regex startedAtRegex = new Regex("{StartedAt([:]?)([A-Za-z \\/:|-]*)}");
        private Regex createdAtRegex = new Regex("{CreatedAt([:]?)([A-Za-z \\/:|-]*)}");
        public SaveTelegramForm(List<int> ids)
        {
            this.Ids = ids;

            InitializeComponent();

            OpenPathButton.Click += (sender, args) => OpenPath();

            SaveButton.Click += (sender, args) => SaveBet();

            MarkersTemplateLinkLabel.Click += (sender, args) =>
            {
                MessageService.ShowInfo(Settings.ShowHelp);
            };

            SettingsSaveButtom.Click += (sender, args) => SettingsSave();

            TokenTextBox.Text = Settings.KeyExists("Token", "Telegram")
                ? Settings.Read("Token", "Telegram")
                : string.Empty;

            NameChannelTextBox_1.Text = Settings.KeyExists("NameChannel_1", "Telegram")
                ? Settings.Read("NameChannel_1", "Telegram")
                : String.Empty;

            NameChannelTextBox_2.Text = Settings.KeyExists("NameChannel_2", "Telegram")
                ? Settings.Read("NameChannel_2", "Telegram")
                : String.Empty;

            NameChannelTextBox_3.Text = Settings.KeyExists("NameChannel_3", "Telegram")
                ? Settings.Read("NameChannel_3", "Telegram")
                : String.Empty;

            if (Settings.KeyExists("NameChannelCheck_1", "Telegram"))
            {
                NameChannelCheckBox_1.Checked = bool.Parse(Settings.Read("NameChannelCheck_1", "Telegram"));
            }

            if(Settings.KeyExists("NameChannelCheck_2", "Telegram"))
            {
                NameChannelCheckBox_2.Checked = bool.Parse(Settings.Read("NameChannelCheck_2", "Telegram"));
            }

            if (Settings.KeyExists("NameChannelCheck_3", "Telegram"))
            {
                NameChannelCheckBox_3.Checked = bool.Parse(Settings.Read("NameChannelCheck_3", "Telegram"));
            }

                     
        }

        private void SettingsSave()
        {
            Settings.Write("Token", TokenTextBox.Text, "Telegram");
            Settings.Write("NameChannel_1", NameChannelTextBox_1.Text, "Telegram");
            Settings.Write("NameChannel_2", NameChannelTextBox_2.Text, "Telegram");
            Settings.Write("NameChannel_3", NameChannelTextBox_3.Text, "Telegram");
            Settings.Write("NameChannelCheck_1", NameChannelCheckBox_1.Checked.ToString(), "Telegram");
            Settings.Write("NameChannelCheck_2", NameChannelCheckBox_2.Checked.ToString(), "Telegram");
            Settings.Write("NameChannelCheck_3", NameChannelCheckBox_3.Checked.ToString(), "Telegram");
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

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            List<Bet> bets = db.GetCollection<Bet>("Bet").Find(x => Ids.Contains(x.Id)).ToList();

            TelegramBotClient client = new TelegramBotClient(Settings.Read("Token", "Telegram"));

            foreach (Bet bet in bets)
            {
                string result = TemplateTextBox.Text;

                result = result.Replace("{Id}", bet.Id.ToString());
                result = result.Replace("{HomeTeam}", bet.HomeTeam.Name);
                result = result.Replace("{GuestTeam}", bet.GuestTeam.Name);
                result = result.Replace("{Prognosis}", MarkdownService.ToText(bet.Prognosis.Name));
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

                try
                {
                    if (NameChannelCheckBox_1.Checked)
                    {
                        await client.SendTextMessageAsync(Settings.Read("NameChannel_1", "Telegram"), result, parseMode: ParseMode.Markdown);
                    }

                    if (NameChannelCheckBox_2.Checked)
                    {
                        await client.SendTextMessageAsync(Settings.Read("NameChannel_2", "Telegram"), result, parseMode: ParseMode.Markdown);
                    }

                    if (NameChannelCheckBox_3.Checked)
                    {
                        await client.SendTextMessageAsync(Settings.Read("NameChannel_3", "Telegram"), result, parseMode: ParseMode.Markdown);
                    }
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
    }
}
