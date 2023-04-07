﻿using System;
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

            SaveButton.Click += (sender, args) => SaveSettings();
        }

        private void SaveSettings()
        {
            Settings.Write("Token", TokenTextBox.Text, "Telegram");
            Settings.Write("NameChannel", NameChannelTextBox.Text, "Telegram");
        }
    }
}
