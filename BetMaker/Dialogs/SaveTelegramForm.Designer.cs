
namespace BetMaker.Dialogs
{
    partial class SaveTelegramForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TemplateLabel = new System.Windows.Forms.Label();
            TemplateTextBox = new System.Windows.Forms.TextBox();
            SaveButton = new System.Windows.Forms.Button();
            MainGroup = new System.Windows.Forms.GroupBox();
            MarkersTemplateLinkLabel = new System.Windows.Forms.LinkLabel();
            OpenPathButton = new System.Windows.Forms.Button();
            PathTemplateTextBox = new System.Windows.Forms.TextBox();
            PathTemplateLabel = new System.Windows.Forms.Label();
            SettingsGroup = new System.Windows.Forms.GroupBox();
            SettingsSaveButtom = new System.Windows.Forms.Button();
            NameChannelCheckBox_3 = new System.Windows.Forms.CheckBox();
            NameChannelCheckBox_2 = new System.Windows.Forms.CheckBox();
            NameChannelCheckBox_1 = new System.Windows.Forms.CheckBox();
            NameChannelTextBox_3 = new System.Windows.Forms.TextBox();
            NameChannelTextBox_2 = new System.Windows.Forms.TextBox();
            NameChannelTextBox_1 = new System.Windows.Forms.TextBox();
            NameChannelLabel = new System.Windows.Forms.Label();
            TokenTextBox = new System.Windows.Forms.TextBox();
            TokenLabel = new System.Windows.Forms.Label();
            MainGroup.SuspendLayout();
            SettingsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // TemplateLabel
            // 
            TemplateLabel.AutoSize = true;
            TemplateLabel.Location = new System.Drawing.Point(13, 70);
            TemplateLabel.Name = "TemplateLabel";
            TemplateLabel.Size = new System.Drawing.Size(55, 15);
            TemplateLabel.TabIndex = 0;
            TemplateLabel.Text = "Шаблон:";
            // 
            // TemplateTextBox
            // 
            TemplateTextBox.Location = new System.Drawing.Point(13, 88);
            TemplateTextBox.Multiline = true;
            TemplateTextBox.Name = "TemplateTextBox";
            TemplateTextBox.ReadOnly = true;
            TemplateTextBox.Size = new System.Drawing.Size(298, 279);
            TemplateTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(236, 373);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(75, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // MainGroup
            // 
            MainGroup.Controls.Add(MarkersTemplateLinkLabel);
            MainGroup.Controls.Add(SaveButton);
            MainGroup.Controls.Add(OpenPathButton);
            MainGroup.Controls.Add(TemplateTextBox);
            MainGroup.Controls.Add(PathTemplateTextBox);
            MainGroup.Controls.Add(TemplateLabel);
            MainGroup.Controls.Add(PathTemplateLabel);
            MainGroup.Location = new System.Drawing.Point(12, 12);
            MainGroup.Name = "MainGroup";
            MainGroup.Padding = new System.Windows.Forms.Padding(10);
            MainGroup.Size = new System.Drawing.Size(325, 409);
            MainGroup.TabIndex = 1;
            MainGroup.TabStop = false;
            MainGroup.Text = "Основное окно";
            // 
            // MarkersTemplateLinkLabel
            // 
            MarkersTemplateLinkLabel.AutoSize = true;
            MarkersTemplateLinkLabel.Location = new System.Drawing.Point(13, 377);
            MarkersTemplateLinkLabel.Name = "MarkersTemplateLinkLabel";
            MarkersTemplateLinkLabel.Size = new System.Drawing.Size(135, 15);
            MarkersTemplateLinkLabel.TabIndex = 6;
            MarkersTemplateLinkLabel.TabStop = true;
            MarkersTemplateLinkLabel.Text = "Маркеры для шаблона";
            // 
            // OpenPathButton
            // 
            OpenPathButton.Location = new System.Drawing.Point(286, 43);
            OpenPathButton.Name = "OpenPathButton";
            OpenPathButton.Size = new System.Drawing.Size(25, 25);
            OpenPathButton.TabIndex = 5;
            OpenPathButton.Text = "О";
            OpenPathButton.UseVisualStyleBackColor = true;
            // 
            // PathTemplateTextBox
            // 
            PathTemplateTextBox.Enabled = false;
            PathTemplateTextBox.Location = new System.Drawing.Point(13, 44);
            PathTemplateTextBox.Name = "PathTemplateTextBox";
            PathTemplateTextBox.ReadOnly = true;
            PathTemplateTextBox.Size = new System.Drawing.Size(275, 23);
            PathTemplateTextBox.TabIndex = 4;
            // 
            // PathTemplateLabel
            // 
            PathTemplateLabel.AutoSize = true;
            PathTemplateLabel.Location = new System.Drawing.Point(13, 26);
            PathTemplateLabel.Name = "PathTemplateLabel";
            PathTemplateLabel.Size = new System.Drawing.Size(99, 15);
            PathTemplateLabel.TabIndex = 3;
            PathTemplateLabel.Text = "Путь к шаблону:";
            // 
            // SettingsGroup
            // 
            SettingsGroup.Controls.Add(SettingsSaveButtom);
            SettingsGroup.Controls.Add(NameChannelCheckBox_3);
            SettingsGroup.Controls.Add(NameChannelCheckBox_2);
            SettingsGroup.Controls.Add(NameChannelCheckBox_1);
            SettingsGroup.Controls.Add(NameChannelTextBox_3);
            SettingsGroup.Controls.Add(NameChannelTextBox_2);
            SettingsGroup.Controls.Add(NameChannelTextBox_1);
            SettingsGroup.Controls.Add(NameChannelLabel);
            SettingsGroup.Controls.Add(TokenTextBox);
            SettingsGroup.Controls.Add(TokenLabel);
            SettingsGroup.Location = new System.Drawing.Point(343, 12);
            SettingsGroup.Name = "SettingsGroup";
            SettingsGroup.Padding = new System.Windows.Forms.Padding(10);
            SettingsGroup.Size = new System.Drawing.Size(315, 222);
            SettingsGroup.TabIndex = 2;
            SettingsGroup.TabStop = false;
            SettingsGroup.Text = "Настройки";
            // 
            // SettingsSaveButtom
            // 
            SettingsSaveButtom.Location = new System.Drawing.Point(227, 190);
            SettingsSaveButtom.Name = "SettingsSaveButtom";
            SettingsSaveButtom.Size = new System.Drawing.Size(75, 23);
            SettingsSaveButtom.TabIndex = 10;
            SettingsSaveButtom.Text = "Сохранить";
            SettingsSaveButtom.UseVisualStyleBackColor = true;
            // 
            // NameChannelCheckBox_3
            // 
            NameChannelCheckBox_3.AutoSize = true;
            NameChannelCheckBox_3.Location = new System.Drawing.Point(287, 158);
            NameChannelCheckBox_3.Name = "NameChannelCheckBox_3";
            NameChannelCheckBox_3.Size = new System.Drawing.Size(15, 14);
            NameChannelCheckBox_3.TabIndex = 9;
            NameChannelCheckBox_3.UseVisualStyleBackColor = true;
            // 
            // NameChannelCheckBox_2
            // 
            NameChannelCheckBox_2.AutoSize = true;
            NameChannelCheckBox_2.Location = new System.Drawing.Point(287, 129);
            NameChannelCheckBox_2.Name = "NameChannelCheckBox_2";
            NameChannelCheckBox_2.Size = new System.Drawing.Size(15, 14);
            NameChannelCheckBox_2.TabIndex = 8;
            NameChannelCheckBox_2.UseVisualStyleBackColor = true;
            // 
            // NameChannelCheckBox_1
            // 
            NameChannelCheckBox_1.AutoSize = true;
            NameChannelCheckBox_1.Location = new System.Drawing.Point(287, 100);
            NameChannelCheckBox_1.Name = "NameChannelCheckBox_1";
            NameChannelCheckBox_1.Size = new System.Drawing.Size(15, 14);
            NameChannelCheckBox_1.TabIndex = 7;
            NameChannelCheckBox_1.UseVisualStyleBackColor = true;
            // 
            // NameChannelTextBox_3
            // 
            NameChannelTextBox_3.Location = new System.Drawing.Point(13, 154);
            NameChannelTextBox_3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            NameChannelTextBox_3.Name = "NameChannelTextBox_3";
            NameChannelTextBox_3.Size = new System.Drawing.Size(268, 23);
            NameChannelTextBox_3.TabIndex = 6;
            // 
            // NameChannelTextBox_2
            // 
            NameChannelTextBox_2.Location = new System.Drawing.Point(13, 125);
            NameChannelTextBox_2.Name = "NameChannelTextBox_2";
            NameChannelTextBox_2.Size = new System.Drawing.Size(268, 23);
            NameChannelTextBox_2.TabIndex = 5;
            // 
            // NameChannelTextBox_1
            // 
            NameChannelTextBox_1.Location = new System.Drawing.Point(13, 96);
            NameChannelTextBox_1.Name = "NameChannelTextBox_1";
            NameChannelTextBox_1.Size = new System.Drawing.Size(268, 23);
            NameChannelTextBox_1.TabIndex = 4;
            // 
            // NameChannelLabel
            // 
            NameChannelLabel.AutoSize = true;
            NameChannelLabel.Location = new System.Drawing.Point(13, 78);
            NameChannelLabel.Name = "NameChannelLabel";
            NameChannelLabel.Size = new System.Drawing.Size(110, 15);
            NameChannelLabel.TabIndex = 3;
            NameChannelLabel.Text = "Название каналов:";
            // 
            // TokenTextBox
            // 
            TokenTextBox.Location = new System.Drawing.Point(13, 45);
            TokenTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            TokenTextBox.Name = "TokenTextBox";
            TokenTextBox.Size = new System.Drawing.Size(289, 23);
            TokenTextBox.TabIndex = 1;
            // 
            // TokenLabel
            // 
            TokenLabel.AutoSize = true;
            TokenLabel.Location = new System.Drawing.Point(13, 26);
            TokenLabel.Name = "TokenLabel";
            TokenLabel.Size = new System.Drawing.Size(70, 15);
            TokenLabel.TabIndex = 0;
            TokenLabel.Text = "Токен бота:";
            // 
            // SaveTelegramForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(670, 433);
            Controls.Add(SettingsGroup);
            Controls.Add(MainGroup);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "SaveTelegramForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Сохранение ставок [ТЕЛЕГРАМ]";
            MainGroup.ResumeLayout(false);
            MainGroup.PerformLayout();
            SettingsGroup.ResumeLayout(false);
            SettingsGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label TemplateLabel;
        private System.Windows.Forms.TextBox TemplateTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Button OpenPathButton;
        private System.Windows.Forms.TextBox PathTemplateTextBox;
        private System.Windows.Forms.Label PathTemplateLabel;
        private System.Windows.Forms.LinkLabel MarkersTemplateLinkLabel;
        private System.Windows.Forms.GroupBox SettingsGroup;
        private System.Windows.Forms.Label NameChannelLabel;
        private System.Windows.Forms.TextBox TokenTextBox;
        private System.Windows.Forms.Label TokenLabel;
        private System.Windows.Forms.CheckBox NameChannelCheckBox_3;
        private System.Windows.Forms.CheckBox NameChannelCheckBox_2;
        private System.Windows.Forms.CheckBox NameChannelCheckBox_1;
        private System.Windows.Forms.TextBox NameChannelTextBox_3;
        private System.Windows.Forms.TextBox NameChannelTextBox_2;
        private System.Windows.Forms.TextBox NameChannelTextBox_1;
        private System.Windows.Forms.Button SettingsSaveButtom;
    }
}