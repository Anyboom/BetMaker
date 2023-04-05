
namespace BetMaker.Dialogs
{
    partial class TeamForm
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
            this.AddTeamTool = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTeamFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveTeamTool = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTeamTool = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateListTool = new System.Windows.Forms.ToolStripMenuItem();
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
            this.AddTeamTool,
            this.RemoveTeamTool,
            this.EditTeamTool,
            this.UpdateListTool});
            this.ListContextMenu.Name = "ListContextMenu";
            this.ListContextMenu.Size = new System.Drawing.Size(181, 114);
            // 
            // AddTeamTool
            // 
            this.AddTeamTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTeamFileTool});
            this.AddTeamTool.Name = "AddTeamTool";
            this.AddTeamTool.Size = new System.Drawing.Size(180, 22);
            this.AddTeamTool.Text = "Добавить";
            // 
            // AddTeamFileTool
            // 
            this.AddTeamFileTool.Name = "AddTeamFileTool";
            this.AddTeamFileTool.Size = new System.Drawing.Size(126, 22);
            this.AddTeamFileTool.Text = "Из файла";
            // 
            // RemoveTeamTool
            // 
            this.RemoveTeamTool.Name = "RemoveTeamTool";
            this.RemoveTeamTool.Size = new System.Drawing.Size(180, 22);
            this.RemoveTeamTool.Text = "Удалить";
            // 
            // EditTeamTool
            // 
            this.EditTeamTool.Name = "EditTeamTool";
            this.EditTeamTool.Size = new System.Drawing.Size(180, 22);
            this.EditTeamTool.Text = "Редактировать";
            // 
            // UpdateListTool
            // 
            this.UpdateListTool.Name = "UpdateListTool";
            this.UpdateListTool.Size = new System.Drawing.Size(180, 22);
            this.UpdateListTool.Text = "Обновить";
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 315);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Команды";
            this.MainGroup.ResumeLayout(false);
            this.ListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.ContextMenuStrip ListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddTeamTool;
        private System.Windows.Forms.ToolStripMenuItem RemoveTeamTool;
        private System.Windows.Forms.ToolStripMenuItem EditTeamTool;
        private System.Windows.Forms.ToolStripMenuItem AddTeamFileTool;
        private System.Windows.Forms.ToolStripMenuItem UpdateListTool;
    }
}