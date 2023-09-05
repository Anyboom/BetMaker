
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
            TemplateLabel = new System.Windows.Forms.Label();
            TemplateTextBox = new System.Windows.Forms.TextBox();
            SaveButton = new System.Windows.Forms.Button();
            MainGroup = new System.Windows.Forms.GroupBox();
            ManyFilesCheck = new System.Windows.Forms.CheckBox();
            ManyFileTextBox = new System.Windows.Forms.TextBox();
            MarkersTemplateLinkLabel = new System.Windows.Forms.LinkLabel();
            OpenPathButton = new System.Windows.Forms.Button();
            PathTemplateTextBox = new System.Windows.Forms.TextBox();
            PathTemplateLabel = new System.Windows.Forms.Label();
            MainGroup.SuspendLayout();
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
            TemplateTextBox.Size = new System.Drawing.Size(298, 206);
            TemplateTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(237, 354);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(75, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // MainGroup
            // 
            MainGroup.Controls.Add(ManyFilesCheck);
            MainGroup.Controls.Add(ManyFileTextBox);
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
            MainGroup.Size = new System.Drawing.Size(325, 387);
            MainGroup.TabIndex = 1;
            MainGroup.TabStop = false;
            // 
            // ManyFilesCheck
            // 
            ManyFilesCheck.AutoSize = true;
            ManyFilesCheck.Location = new System.Drawing.Point(13, 300);
            ManyFilesCheck.Name = "ManyFilesCheck";
            ManyFilesCheck.Size = new System.Drawing.Size(227, 19);
            ManyFilesCheck.TabIndex = 10;
            ManyFilesCheck.Text = "В разные файлы: ( шаблон файлов )";
            ManyFilesCheck.UseVisualStyleBackColor = true;
            // 
            // ManyFileTextBox
            // 
            ManyFileTextBox.Enabled = false;
            ManyFileTextBox.Location = new System.Drawing.Point(13, 325);
            ManyFileTextBox.Name = "ManyFileTextBox";
            ManyFileTextBox.Size = new System.Drawing.Size(298, 23);
            ManyFileTextBox.TabIndex = 9;
            // 
            // MarkersTemplateLinkLabel
            // 
            MarkersTemplateLinkLabel.AutoSize = true;
            MarkersTemplateLinkLabel.Location = new System.Drawing.Point(13, 358);
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
            // SaveFileForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(349, 411);
            Controls.Add(MainGroup);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "SaveFileForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Сохранение ставок [ФАЙЛ]";
            MainGroup.ResumeLayout(false);
            MainGroup.PerformLayout();
            ResumeLayout(false);
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