
namespace BetMaker.Dialogs
{
    partial class SaveFileForm
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
            this.TemplateLabel = new System.Windows.Forms.Label();
            this.TemplateTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.MarkersTemplateLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OpenPathButton = new System.Windows.Forms.Button();
            this.PathTemplateLabel = new System.Windows.Forms.Label();
            this.PathTemplateTextBox = new System.Windows.Forms.TextBox();
            this.ManyFileTextBox = new System.Windows.Forms.TextBox();
            this.ManyFilesCheck = new System.Windows.Forms.CheckBox();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TemplateLabel
            // 
            this.TemplateLabel.AutoSize = true;
            this.TemplateLabel.Location = new System.Drawing.Point(13, 70);
            this.TemplateLabel.Name = "TemplateLabel";
            this.TemplateLabel.Size = new System.Drawing.Size(55, 15);
            this.TemplateLabel.TabIndex = 0;
            this.TemplateLabel.Text = "Шаблон:";
            // 
            // TemplateTextBox
            // 
            this.TemplateTextBox.Location = new System.Drawing.Point(13, 88);
            this.TemplateTextBox.Multiline = true;
            this.TemplateTextBox.Name = "TemplateTextBox";
            this.TemplateTextBox.ReadOnly = true;
            this.TemplateTextBox.Size = new System.Drawing.Size(298, 206);
            this.TemplateTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(237, 354);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.ManyFilesCheck);
            this.MainGroup.Controls.Add(this.ManyFileTextBox);
            this.MainGroup.Controls.Add(this.MarkersTemplateLinkLabel);
            this.MainGroup.Controls.Add(this.SaveButton);
            this.MainGroup.Controls.Add(this.OpenPathButton);
            this.MainGroup.Controls.Add(this.TemplateTextBox);
            this.MainGroup.Controls.Add(this.PathTemplateTextBox);
            this.MainGroup.Controls.Add(this.TemplateLabel);
            this.MainGroup.Controls.Add(this.PathTemplateLabel);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10);
            this.MainGroup.Size = new System.Drawing.Size(325, 387);
            this.MainGroup.TabIndex = 1;
            this.MainGroup.TabStop = false;
            // 
            // MarkersTemplateLinkLabel
            // 
            this.MarkersTemplateLinkLabel.AutoSize = true;
            this.MarkersTemplateLinkLabel.Location = new System.Drawing.Point(13, 358);
            this.MarkersTemplateLinkLabel.Name = "MarkersTemplateLinkLabel";
            this.MarkersTemplateLinkLabel.Size = new System.Drawing.Size(135, 15);
            this.MarkersTemplateLinkLabel.TabIndex = 6;
            this.MarkersTemplateLinkLabel.TabStop = true;
            this.MarkersTemplateLinkLabel.Text = "Маркеры для шаблона";
            // 
            // OpenPathButton
            // 
            this.OpenPathButton.Location = new System.Drawing.Point(286, 43);
            this.OpenPathButton.Name = "OpenPathButton";
            this.OpenPathButton.Size = new System.Drawing.Size(25, 25);
            this.OpenPathButton.TabIndex = 5;
            this.OpenPathButton.Text = "О";
            this.OpenPathButton.UseVisualStyleBackColor = true;
            // 
            // PathTemplateLabel
            // 
            this.PathTemplateLabel.AutoSize = true;
            this.PathTemplateLabel.Location = new System.Drawing.Point(13, 26);
            this.PathTemplateLabel.Name = "PathTemplateLabel";
            this.PathTemplateLabel.Size = new System.Drawing.Size(99, 15);
            this.PathTemplateLabel.TabIndex = 3;
            this.PathTemplateLabel.Text = "Путь к шаблону:";
            // 
            // PathTemplateTextBox
            // 
            this.PathTemplateTextBox.Enabled = false;
            this.PathTemplateTextBox.Location = new System.Drawing.Point(13, 44);
            this.PathTemplateTextBox.Name = "PathTemplateTextBox";
            this.PathTemplateTextBox.ReadOnly = true;
            this.PathTemplateTextBox.Size = new System.Drawing.Size(275, 23);
            this.PathTemplateTextBox.TabIndex = 4;
            // 
            // ManyFileTextBox
            // 
            this.ManyFileTextBox.Location = new System.Drawing.Point(13, 325);
            this.ManyFileTextBox.Name = "ManyFileTextBox";
            this.ManyFileTextBox.Size = new System.Drawing.Size(298, 23);
            this.ManyFileTextBox.TabIndex = 9;
            this.ManyFileTextBox.Text = "{CreatedAt}-{HomeTeam}-{GuestTeam}";
            // 
            // ManyFilesCheck
            // 
            this.ManyFilesCheck.AutoSize = true;
            this.ManyFilesCheck.Location = new System.Drawing.Point(13, 300);
            this.ManyFilesCheck.Name = "ManyFilesCheck";
            this.ManyFilesCheck.Size = new System.Drawing.Size(227, 19);
            this.ManyFilesCheck.TabIndex = 10;
            this.ManyFilesCheck.Text = "В разные файлы: ( шаблон файлов )";
            this.ManyFilesCheck.UseVisualStyleBackColor = true;
            // 
            // SaveFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 411);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SaveFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сохранение ставок [ФАЙЛ]";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TemplateLabel;
        private System.Windows.Forms.TextBox TemplateTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Button OpenPathButton;
        private System.Windows.Forms.Label PathTemplateLabel;
        private System.Windows.Forms.LinkLabel MarkersTemplateLinkLabel;
        private System.Windows.Forms.CheckBox ManyFilesCheck;
        private System.Windows.Forms.TextBox ManyFileTextBox;
        private System.Windows.Forms.TextBox PathTemplateTextBox;
    }
}