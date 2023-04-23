
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameChannelTextBox = new System.Windows.Forms.TextBox();
            this.TokenTextBox = new System.Windows.Forms.TextBox();
            this.NameChannelLabel = new System.Windows.Forms.Label();
            this.TokenLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.NameChannelTextBox);
            this.groupBox1.Controls.Add(this.TokenTextBox);
            this.groupBox1.Controls.Add(this.NameChannelLabel);
            this.groupBox1.Controls.Add(this.TokenLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(310, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(222, 131);
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
            this.ClientSize = new System.Drawing.Size(334, 187);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NameChannelTextBox;
        private System.Windows.Forms.TextBox TokenTextBox;
        private System.Windows.Forms.Label NameChannelLabel;
        private System.Windows.Forms.Label TokenLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}