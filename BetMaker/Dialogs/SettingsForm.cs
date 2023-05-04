using System;
using System.Windows.Forms;

namespace BetMaker.Dialogs
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            TokenTextBox.Text = Settings.KeyExists("Token", "Telegram")
                ? Settings.Read("Token", "Telegram")
                : string.Empty;
            NameChannelTextBox.Text = Settings.KeyExists("NameChannel", "Telegram")
                ? Settings.Read("NameChannel", "Telegram")
                : String.Empty;

            TemplateCreatedAtFileText.Text = Settings.KeyExists("TemplateCreatedAtFile")
                ? Settings.Read("TemplateCreatedAtFile")
                : "HH-mm-dd-MM-yyyy";
            TemplateCreatedAtText.Text = Settings.KeyExists("TemplateCreatedAt")
                ? Settings.Read("TemplateCreatedAt")
                : "HH:mm | d MMM yyyy";

            TemplateStartAtFileText.Text = Settings.KeyExists("TemplateStartAtFile")
                ? Settings.Read("TemplateStartAtFile")
                : "HH-mm-dd-MM-yyyy";
            TemplateStartAtText.Text = Settings.KeyExists("TemplateStartAt")
                ? Settings.Read("TemplateStartAt")
                : "HH:mm | d MMM yyyy";

            TemplateNameFileText.Text = Settings.KeyExists("TemplateNameFile")
                ? Settings.Read("TemplateNameFile")
                : "{CreatedAt}-{HomeTeam}-{GuestTeam}.md";

            SaveButton.Click += (sender, args) => SaveSettings();
        }

        private void SaveSettings()
        {
            Settings.Write("Token", TokenTextBox.Text, "Telegram");
            Settings.Write("NameChannel", NameChannelTextBox.Text, "Telegram");
            Settings.Write("TemplateCreatedAtFile", TemplateCreatedAtFileText.Text);
            Settings.Write("TemplateCreatedAt", TemplateCreatedAtText.Text);
            Settings.Write("TemplateStartAtFile", TemplateStartAtFileText.Text);
            Settings.Write("TemplateStartAt", TemplateStartAtText.Text);
            Settings.Write("TemplateNameFile", TemplateNameFileText.Text);
        }
    }
}
