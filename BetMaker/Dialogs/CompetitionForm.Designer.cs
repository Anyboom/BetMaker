
namespace BetMaker.Dialogs
{
    partial class CompetitionForm
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
            this.components = new System.ComponentModel.Container();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.MainList = new System.Windows.Forms.ListBox();
            this.ListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddCompetitionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCompetitionFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveCompetitionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCompetitionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateListTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainGroup.SuspendLayout();
            this.ListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.MainList);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainGroup.Size = new System.Drawing.Size(207, 291);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // MainList
            // 
            this.MainList.ContextMenuStrip = this.ListContextMenu;
            this.MainList.FormattingEnabled = true;
            this.MainList.ItemHeight = 15;
            this.MainList.Location = new System.Drawing.Point(13, 21);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(180, 259);
            this.MainList.TabIndex = 0;
            // 
            // ListContextMenu
            // 
            this.ListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCompetitionTool,
            this.RemoveCompetitionTool,
            this.EditCompetitionTool,
            this.Separator1,
            this.UpdateListTool});
            this.ListContextMenu.Name = "ListContextMenu";
            this.ListContextMenu.Size = new System.Drawing.Size(181, 120);
            // 
            // AddCompetitionTool
            // 
            this.AddCompetitionTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCompetitionFileTool});
            this.AddCompetitionTool.Name = "AddCompetitionTool";
            this.AddCompetitionTool.Size = new System.Drawing.Size(180, 22);
            this.AddCompetitionTool.Text = "Добавить";
            // 
            // AddCompetitionFileTool
            // 
            this.AddCompetitionFileTool.Name = "AddCompetitionFileTool";
            this.AddCompetitionFileTool.Size = new System.Drawing.Size(180, 22);
            this.AddCompetitionFileTool.Text = "Из файла";
            // 
            // RemoveCompetitionTool
            // 
            this.RemoveCompetitionTool.Name = "RemoveCompetitionTool";
            this.RemoveCompetitionTool.Size = new System.Drawing.Size(180, 22);
            this.RemoveCompetitionTool.Text = "Удалить";
            // 
            // EditCompetitionTool
            // 
            this.EditCompetitionTool.Name = "EditCompetitionTool";
            this.EditCompetitionTool.Size = new System.Drawing.Size(180, 22);
            this.EditCompetitionTool.Text = "Редактировать";
            // 
            // UpdateListTool
            // 
            this.UpdateListTool.Name = "UpdateListTool";
            this.UpdateListTool.Size = new System.Drawing.Size(180, 22);
            this.UpdateListTool.Text = "Обновить";
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(177, 6);
            // 
            // CompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 315);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompetitionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Соревнования";
            this.MainGroup.ResumeLayout(false);
            this.ListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.ContextMenuStrip ListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddCompetitionTool;
        private System.Windows.Forms.ToolStripMenuItem RemoveCompetitionTool;
        private System.Windows.Forms.ToolStripMenuItem EditCompetitionTool;
        private System.Windows.Forms.ToolStripMenuItem AddCompetitionFileTool;
        private System.Windows.Forms.ToolStripMenuItem UpdateListTool;
        private System.Windows.Forms.ToolStripSeparator Separator1;
    }
}