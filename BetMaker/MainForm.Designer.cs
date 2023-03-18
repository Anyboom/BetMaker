
namespace BetMaker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BetTool = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBetTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateTableTool = new System.Windows.Forms.ToolStripMenuItem();
            this.StartDateTime = new System.Windows.Forms.DateTimePicker();
            this.EndDateTime = new System.Windows.Forms.DateTimePicker();
            this.MainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.MainContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGroup.Controls.Add(this.MainGrid);
            this.MainGroup.Location = new System.Drawing.Point(12, 41);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.MainGroup.Size = new System.Drawing.Size(760, 405);
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
            this.MainGrid.ContextMenuStrip = this.MainContextMenu;
            this.MainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainGrid.Location = new System.Drawing.Point(13, 22);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.MainGrid.RowTemplate.Height = 25;
            this.MainGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(734, 370);
            this.MainGrid.TabIndex = 0;
            this.MainGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MainGrid_CellFormatting);
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BetTool,
            this.toolStripSeparator1,
            this.UpdateTableTool});
            this.MainContextMenu.Name = "MainContextMenu";
            this.MainContextMenu.Size = new System.Drawing.Size(129, 54);
            // 
            // BetTool
            // 
            this.BetTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBetTool,
            this.RemoveTool});
            this.BetTool.Name = "BetTool";
            this.BetTool.Size = new System.Drawing.Size(128, 22);
            this.BetTool.Text = "Ставка";
            // 
            // AddBetTool
            // 
            this.AddBetTool.Name = "AddBetTool";
            this.AddBetTool.Size = new System.Drawing.Size(126, 22);
            this.AddBetTool.Text = "Добавить";
            this.AddBetTool.Click += new System.EventHandler(this.AddBetTool_Click);
            // 
            // RemoveTool
            // 
            this.RemoveTool.Name = "RemoveTool";
            this.RemoveTool.Size = new System.Drawing.Size(126, 22);
            this.RemoveTool.Text = "Удалить";
            this.RemoveTool.Click += new System.EventHandler(this.RemoveTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // UpdateTableTool
            // 
            this.UpdateTableTool.Name = "UpdateTableTool";
            this.UpdateTableTool.Size = new System.Drawing.Size(128, 22);
            this.UpdateTableTool.Text = "Обновить";
            this.UpdateTableTool.Click += new System.EventHandler(this.UpdateTableTool_Click);
            // 
            // StartDateTime
            // 
            this.StartDateTime.CustomFormat = "";
            this.StartDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateTime.Location = new System.Drawing.Point(12, 12);
            this.StartDateTime.Name = "StartDateTime";
            this.StartDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartDateTime.Size = new System.Drawing.Size(78, 23);
            this.StartDateTime.TabIndex = 1;
            // 
            // EndDateTime
            // 
            this.EndDateTime.CustomFormat = "";
            this.EndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTime.Location = new System.Drawing.Point(96, 12);
            this.EndDateTime.Name = "EndDateTime";
            this.EndDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndDateTime.Size = new System.Drawing.Size(78, 23);
            this.EndDateTime.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 458);
            this.Controls.Add(this.EndDateTime);
            this.Controls.Add(this.StartDateTime);
            this.Controls.Add(this.MainGroup);
            this.Name = "MainForm";
            this.Text = "BetMaker";
            this.MainGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.MainContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem BetTool;
        private System.Windows.Forms.ToolStripMenuItem AddBetTool;
        private System.Windows.Forms.ToolStripMenuItem RemoveTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem UpdateTableTool;
        private System.Windows.Forms.DateTimePicker StartDateTime;
        private System.Windows.Forms.DateTimePicker EndDateTime;
    }
}

