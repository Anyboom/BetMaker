
namespace BetMaker.Dialogs
{
    partial class SettingsForm
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
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.TemplateStartAtText = new System.Windows.Forms.TextBox();
            this.TemplateStartAtLabel = new System.Windows.Forms.Label();
            this.TemplateStartAtFileText = new System.Windows.Forms.TextBox();
            this.TemplateStartAtFileLabel = new System.Windows.Forms.Label();
            this.TemplateCreatedAtText = new System.Windows.Forms.TextBox();
            this.TemplateCreatedAtLabel = new System.Windows.Forms.Label();
            this.TemplateCreatedAtFileText = new System.Windows.Forms.TextBox();
            this.TemplateCreatedAtFileLabel = new System.Windows.Forms.Label();
            this.TemplateNameFileText = new System.Windows.Forms.TextBox();
            this.TemplateNameFileLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameChannelTextBox = new System.Windows.Forms.TextBox();
            this.TokenTextBox = new System.Windows.Forms.TextBox();
            this.NameChannelLabel = new System.Windows.Forms.Label();
            this.TokenLabel = new System.Windows.Forms.Label();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.TemplateStartAtText);
            this.MainGroup.Controls.Add(this.TemplateStartAtLabel);
            this.MainGroup.Controls.Add(this.TemplateStartAtFileText);
            this.MainGroup.Controls.Add(this.TemplateStartAtFileLabel);
            this.MainGroup.Controls.Add(this.TemplateCreatedAtText);
            this.MainGroup.Controls.Add(this.TemplateCreatedAtLabel);
            this.MainGroup.Controls.Add(this.TemplateCreatedAtFileText);
            this.MainGroup.Controls.Add(this.TemplateCreatedAtFileLabel);
            this.MainGroup.Controls.Add(this.TemplateNameFileText);
            this.MainGroup.Controls.Add(this.TemplateNameFileLabel);
            this.MainGroup.Controls.Add(this.SaveButton);
            this.MainGroup.Controls.Add(this.NameChannelTextBox);
            this.MainGroup.Controls.Add(this.TokenTextBox);
            this.MainGroup.Controls.Add(this.NameChannelLabel);
            this.MainGroup.Controls.Add(this.TokenLabel);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10);
            this.MainGroup.Size = new System.Drawing.Size(310, 419);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // TemplateStartAtText
            // 
            this.TemplateStartAtText.Location = new System.Drawing.Point(13, 350);
            this.TemplateStartAtText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.TemplateStartAtText.Name = "TemplateStartAtText";
            this.TemplateStartAtText.Size = new System.Drawing.Size(284, 23);
            this.TemplateStartAtText.TabIndex = 15;
            // 
            // TemplateStartAtLabel
            // 
            this.TemplateStartAtLabel.AutoSize = true;
            this.TemplateStartAtLabel.Location = new System.Drawing.Point(13, 332);
            this.TemplateStartAtLabel.Name = "TemplateStartAtLabel";
            this.TemplateStartAtLabel.Size = new System.Drawing.Size(198, 15);
            this.TemplateStartAtLabel.TabIndex = 14;
            this.TemplateStartAtLabel.Text = "Формат StartAt для текста в файле:";
            // 
            // TemplateStartAtFileText
            // 
            this.TemplateStartAtFileText.Location = new System.Drawing.Point(13, 299);
            this.TemplateStartAtFileText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.TemplateStartAtFileText.Name = "TemplateStartAtFileText";
            this.TemplateStartAtFileText.Size = new System.Drawing.Size(284, 23);
            this.TemplateStartAtFileText.TabIndex = 13;
            // 
            // TemplateStartAtFileLabel
            // 
            this.TemplateStartAtFileLabel.AutoSize = true;
            this.TemplateStartAtFileLabel.Location = new System.Drawing.Point(13, 281);
            this.TemplateStartAtFileLabel.Name = "TemplateStartAtFileLabel";
            this.TemplateStartAtFileLabel.Size = new System.Drawing.Size(205, 15);
            this.TemplateStartAtFileLabel.TabIndex = 12;
            this.TemplateStartAtFileLabel.Text = "Формат StartAt для названия файла:";
            // 
            // TemplateCreatedAtText
            // 
            this.TemplateCreatedAtText.Location = new System.Drawing.Point(13, 248);
            this.TemplateCreatedAtText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.TemplateCreatedAtText.Name = "TemplateCreatedAtText";
            this.TemplateCreatedAtText.Size = new System.Drawing.Size(284, 23);
            this.TemplateCreatedAtText.TabIndex = 11;
            // 
            // TemplateCreatedAtLabel
            // 
            this.TemplateCreatedAtLabel.AutoSize = true;
            this.TemplateCreatedAtLabel.Location = new System.Drawing.Point(13, 230);
            this.TemplateCreatedAtLabel.Name = "TemplateCreatedAtLabel";
            this.TemplateCreatedAtLabel.Size = new System.Drawing.Size(215, 15);
            this.TemplateCreatedAtLabel.TabIndex = 10;
            this.TemplateCreatedAtLabel.Text = "Формат CreatedAt для текста в файле:";
            // 
            // TemplateCreatedAtFileText
            // 
            this.TemplateCreatedAtFileText.Location = new System.Drawing.Point(13, 197);
            this.TemplateCreatedAtFileText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.TemplateCreatedAtFileText.Name = "TemplateCreatedAtFileText";
            this.TemplateCreatedAtFileText.Size = new System.Drawing.Size(284, 23);
            this.TemplateCreatedAtFileText.TabIndex = 9;
            // 
            // TemplateCreatedAtFileLabel
            // 
            this.TemplateCreatedAtFileLabel.AutoSize = true;
            this.TemplateCreatedAtFileLabel.Location = new System.Drawing.Point(13, 179);
            this.TemplateCreatedAtFileLabel.Name = "TemplateCreatedAtFileLabel";
            this.TemplateCreatedAtFileLabel.Size = new System.Drawing.Size(222, 15);
            this.TemplateCreatedAtFileLabel.TabIndex = 8;
            this.TemplateCreatedAtFileLabel.Text = "Формат CreatedAt для названия файла:";
            // 
            // TemplateNameFileText
            // 
            this.TemplateNameFileText.Location = new System.Drawing.Point(13, 146);
            this.TemplateNameFileText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.TemplateNameFileText.Name = "TemplateNameFileText";
            this.TemplateNameFileText.Size = new System.Drawing.Size(284, 23);
            this.TemplateNameFileText.TabIndex = 7;
            // 
            // TemplateNameFileLabel
            // 
            this.TemplateNameFileLabel.AutoSize = true;
            this.TemplateNameFileLabel.Location = new System.Drawing.Point(13, 128);
            this.TemplateNameFileLabel.Name = "TemplateNameFileLabel";
            this.TemplateNameFileLabel.Size = new System.Drawing.Size(193, 15);
            this.TemplateNameFileLabel.TabIndex = 6;
            this.TemplateNameFileLabel.Text = "Шаблон для именования файлов:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(222, 386);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // NameChannelTextBox
            // 
            this.NameChannelTextBox.Location = new System.Drawing.Point(13, 95);
            this.NameChannelTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.NameChannelTextBox.Name = "NameChannelTextBox";
            this.NameChannelTextBox.Size = new System.Drawing.Size(284, 23);
            this.NameChannelTextBox.TabIndex = 4;
            // 
            // TokenTextBox
            // 
            this.TokenTextBox.Location = new System.Drawing.Point(13, 44);
            this.TokenTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.TokenTextBox.Name = "TokenTextBox";
            this.TokenTextBox.Size = new System.Drawing.Size(284, 23);
            this.TokenTextBox.TabIndex = 3;
            // 
            // NameChannelLabel
            // 
            this.NameChannelLabel.AutoSize = true;
            this.NameChannelLabel.Location = new System.Drawing.Point(13, 77);
            this.NameChannelLabel.Name = "NameChannelLabel";
            this.NameChannelLabel.Size = new System.Drawing.Size(103, 15);
            this.NameChannelLabel.TabIndex = 2;
            this.NameChannelLabel.Text = "Название канала:";
            // 
            // TokenLabel
            // 
            this.TokenLabel.AutoSize = true;
            this.TokenLabel.Location = new System.Drawing.Point(13, 26);
            this.TokenLabel.Name = "TokenLabel";
            this.TokenLabel.Size = new System.Drawing.Size(70, 15);
            this.TokenLabel.TabIndex = 0;
            this.TokenLabel.Text = "Токен бота:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 443);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.TextBox NameChannelTextBox;
        private System.Windows.Forms.TextBox TokenTextBox;
        private System.Windows.Forms.Label NameChannelLabel;
        private System.Windows.Forms.Label TokenLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TemplateNameFileText;
        private System.Windows.Forms.Label TemplateNameFileLabel;
        private System.Windows.Forms.TextBox TemplateCreatedAtFileText;
        private System.Windows.Forms.Label TemplateCreatedAtFileLabel;
        private System.Windows.Forms.TextBox TemplateStartAtText;
        private System.Windows.Forms.Label TemplateStartAtLabel;
        private System.Windows.Forms.TextBox TemplateStartAtFileText;
        private System.Windows.Forms.Label TemplateStartAtFileLabel;
        private System.Windows.Forms.TextBox TemplateCreatedAtText;
        private System.Windows.Forms.Label TemplateCreatedAtLabel;
    }
}