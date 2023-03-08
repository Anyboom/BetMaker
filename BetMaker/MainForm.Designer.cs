
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
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
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
            this.MainGrid.Location = new System.Drawing.Point(13, 22);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowTemplate.Height = 25;
            this.MainGrid.Size = new System.Drawing.Size(734, 402);
            this.MainGrid.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.DataGridView MainGrid;
    }
}

