
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
            this.MainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.MainContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.MainGrid);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.MainGroup.Size = new System.Drawing.Size(760, 437);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.ContextMenuStrip = this.MainContextMenu;
            this.MainGrid.Location = new System.Drawing.Point(13, 22);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowTemplate.Height = 25;
            this.MainGrid.Size = new System.Drawing.Size(734, 402);
            this.MainGrid.TabIndex = 0;
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BetTool});
            this.MainContextMenu.Name = "MainContextMenu";
            this.MainContextMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // BetTool
            // 
            this.BetTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBetTool});
            this.BetTool.Name = "BetTool";
            this.BetTool.Size = new System.Drawing.Size(180, 22);
            this.BetTool.Text = "Ставка";
            // 
            // AddBetTool
            // 
            this.AddBetTool.Name = "AddBetTool";
            this.AddBetTool.Size = new System.Drawing.Size(180, 22);
            this.AddBetTool.Text = "Добавить";
            this.AddBetTool.Click += new System.EventHandler(this.AddBetTool_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
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
    }
}

