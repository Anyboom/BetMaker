
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
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddCompetitionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCompetitionFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveCompetitionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCompetitionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateListTool = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGroup.Controls.Add(this.MainGrid);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainGroup.Size = new System.Drawing.Size(361, 291);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AllowUserToResizeColumns = false;
            this.MainGrid.AllowUserToResizeRows = false;
            this.MainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.ContextMenuStrip = this.MainMenu;
            this.MainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainGrid.Location = new System.Drawing.Point(13, 24);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.MainGrid.RowTemplate.Height = 25;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(335, 254);
            this.MainGrid.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCompetitionTool,
            this.RemoveCompetitionTool,
            this.EditCompetitionTool,
            this.Separator1,
            this.UpdateListTool});
            this.MainMenu.Name = "ListContextMenu";
            this.MainMenu.Size = new System.Drawing.Size(155, 98);
            // 
            // AddCompetitionTool
            // 
            this.AddCompetitionTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCompetitionFileTool});
            this.AddCompetitionTool.Name = "AddCompetitionTool";
            this.AddCompetitionTool.Size = new System.Drawing.Size(154, 22);
            this.AddCompetitionTool.Text = "Добавить";
            // 
            // AddCompetitionFileTool
            // 
            this.AddCompetitionFileTool.Name = "AddCompetitionFileTool";
            this.AddCompetitionFileTool.Size = new System.Drawing.Size(126, 22);
            this.AddCompetitionFileTool.Text = "Из файла";
            // 
            // RemoveCompetitionTool
            // 
            this.RemoveCompetitionTool.Name = "RemoveCompetitionTool";
            this.RemoveCompetitionTool.Size = new System.Drawing.Size(154, 22);
            this.RemoveCompetitionTool.Text = "Удалить";
            // 
            // EditCompetitionTool
            // 
            this.EditCompetitionTool.Name = "EditCompetitionTool";
            this.EditCompetitionTool.Size = new System.Drawing.Size(154, 22);
            this.EditCompetitionTool.Text = "Редактировать";
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(151, 6);
            // 
            // UpdateListTool
            // 
            this.UpdateListTool.Name = "UpdateListTool";
            this.UpdateListTool.Size = new System.Drawing.Size(154, 22);
            this.UpdateListTool.Text = "Обновить";
            // 
            // CompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 315);
            this.Controls.Add(this.MainGroup);
            this.Name = "CompetitionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Соревнования";
            this.MainGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem AddCompetitionTool;
        private System.Windows.Forms.ToolStripMenuItem RemoveCompetitionTool;
        private System.Windows.Forms.ToolStripMenuItem EditCompetitionTool;
        private System.Windows.Forms.ToolStripMenuItem AddCompetitionFileTool;
        private System.Windows.Forms.ToolStripMenuItem UpdateListTool;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.DataGridView MainGrid;
    }
}