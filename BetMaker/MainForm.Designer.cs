
using System.Drawing;

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
            this.RemoveBetTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangeBetStatusTool = new System.Windows.Forms.ToolStripMenuItem();
            this.WinStatusTool = new System.Windows.Forms.ToolStripMenuItem();
            this.LoseStatusTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnStatusTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveBetTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBetFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBetTelegramTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip3 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsTableTool = new System.Windows.Forms.ToolStripMenuItem();
            this.TeamTool = new System.Windows.Forms.ToolStripMenuItem();
            this.CompetitionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip4 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateTableTool = new System.Windows.Forms.ToolStripMenuItem();
            this.StartRangeDateTime = new System.Windows.Forms.DateTimePicker();
            this.EndRangeDateTime = new System.Windows.Forms.DateTimePicker();
            this.RangeLabel = new System.Windows.Forms.Label();
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
            this.MainGrid.ShowCellToolTips = false;
            this.MainGrid.Size = new System.Drawing.Size(734, 370);
            this.MainGrid.TabIndex = 0;
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BetTool,
            this.toolStrip3,
            this.SettingsTableTool,
            this.toolStrip4,
            this.UpdateTableTool});
            this.MainContextMenu.Name = "MainContextMenu";
            this.MainContextMenu.Size = new System.Drawing.Size(177, 82);
            // 
            // BetTool
            // 
            this.BetTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBetTool,
            this.RemoveBetTool,
            this.ToolStrip1,
            this.ChangeBetStatusTool,
            this.ToolStrip2,
            this.SaveBetTool});
            this.BetTool.Name = "BetTool";
            this.BetTool.Size = new System.Drawing.Size(176, 22);
            this.BetTool.Text = "Ставка";
            // 
            // AddBetTool
            // 
            this.AddBetTool.Name = "AddBetTool";
            this.AddBetTool.Size = new System.Drawing.Size(165, 22);
            this.AddBetTool.Text = "Добавить";
            // 
            // RemoveBetTool
            // 
            this.RemoveBetTool.Name = "RemoveBetTool";
            this.RemoveBetTool.Size = new System.Drawing.Size(165, 22);
            this.RemoveBetTool.Text = "Удалить";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(162, 6);
            // 
            // ChangeBetStatusTool
            // 
            this.ChangeBetStatusTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WinStatusTool,
            this.LoseStatusTool,
            this.ReturnStatusTool});
            this.ChangeBetStatusTool.Name = "ChangeBetStatusTool";
            this.ChangeBetStatusTool.Size = new System.Drawing.Size(165, 22);
            this.ChangeBetStatusTool.Text = "Изменить статус";
            // 
            // WinStatusTool
            // 
            this.WinStatusTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(232)))), ((int)(((byte)(187)))));
            this.WinStatusTool.Name = "WinStatusTool";
            this.WinStatusTool.Size = new System.Drawing.Size(136, 22);
            this.WinStatusTool.Text = "Выигрыш";
            // 
            // LoseStatusTool
            // 
            this.LoseStatusTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.LoseStatusTool.Name = "LoseStatusTool";
            this.LoseStatusTool.Size = new System.Drawing.Size(136, 22);
            this.LoseStatusTool.Text = "Проигрыш";
            // 
            // ReturnStatusTool
            // 
            this.ReturnStatusTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(211)))), ((int)(((byte)(239)))));
            this.ReturnStatusTool.Name = "ReturnStatusTool";
            this.ReturnStatusTool.Size = new System.Drawing.Size(136, 22);
            this.ReturnStatusTool.Text = "Возврат";
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Size = new System.Drawing.Size(162, 6);
            // 
            // SaveBetTool
            // 
            this.SaveBetTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveBetFileTool,
            this.SaveBetTelegramTool});
            this.SaveBetTool.Name = "SaveBetTool";
            this.SaveBetTool.Size = new System.Drawing.Size(165, 22);
            this.SaveBetTool.Text = "Сохранить в";
            // 
            // SaveBetFileTool
            // 
            this.SaveBetFileTool.Name = "SaveBetFileTool";
            this.SaveBetFileTool.Size = new System.Drawing.Size(187, 22);
            this.SaveBetFileTool.Text = "Текстовый документ";
            // 
            // SaveBetTelegramTool
            // 
            this.SaveBetTelegramTool.Name = "SaveBetTelegramTool";
            this.SaveBetTelegramTool.Size = new System.Drawing.Size(187, 22);
            this.SaveBetTelegramTool.Text = "Telegram";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(173, 6);
            // 
            // SettingsTableTool
            // 
            this.SettingsTableTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TeamTool,
            this.CompetitionTool});
            this.SettingsTableTool.Name = "SettingsTableTool";
            this.SettingsTableTool.Size = new System.Drawing.Size(176, 22);
            this.SettingsTableTool.Text = "Настройки";
            // 
            // TeamTool
            // 
            this.TeamTool.Name = "TeamTool";
            this.TeamTool.Size = new System.Drawing.Size(154, 22);
            this.TeamTool.Text = "Команды";
            // 
            // CompetitionTool
            // 
            this.CompetitionTool.Name = "CompetitionTool";
            this.CompetitionTool.Size = new System.Drawing.Size(154, 22);
            this.CompetitionTool.Text = "Соревнования";
            // 
            // toolStrip4
            // 
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(173, 6);
            // 
            // UpdateTableTool
            // 
            this.UpdateTableTool.Name = "UpdateTableTool";
            this.UpdateTableTool.Size = new System.Drawing.Size(176, 22);
            this.UpdateTableTool.Text = "Обновить таблицу";
            // 
            // StartRangeDateTime
            // 
            this.StartRangeDateTime.CustomFormat = "";
            this.StartRangeDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartRangeDateTime.Location = new System.Drawing.Point(81, 17);
            this.StartRangeDateTime.Name = "StartRangeDateTime";
            this.StartRangeDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartRangeDateTime.Size = new System.Drawing.Size(78, 23);
            this.StartRangeDateTime.TabIndex = 1;
            // 
            // EndRangeDateTime
            // 
            this.EndRangeDateTime.CustomFormat = "";
            this.EndRangeDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndRangeDateTime.Location = new System.Drawing.Point(165, 17);
            this.EndRangeDateTime.Name = "EndRangeDateTime";
            this.EndRangeDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndRangeDateTime.Size = new System.Drawing.Size(78, 23);
            this.EndRangeDateTime.TabIndex = 4;
            // 
            // RangeLabel
            // 
            this.RangeLabel.AutoSize = true;
            this.RangeLabel.Location = new System.Drawing.Point(12, 21);
            this.RangeLabel.Name = "RangeLabel";
            this.RangeLabel.Size = new System.Drawing.Size(63, 15);
            this.RangeLabel.TabIndex = 5;
            this.RangeLabel.Text = "Диапазон:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 458);
            this.Controls.Add(this.RangeLabel);
            this.Controls.Add(this.EndRangeDateTime);
            this.Controls.Add(this.StartRangeDateTime);
            this.Controls.Add(this.MainGroup);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блокнот ставок";
            this.MainGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.MainContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem BetTool;
        private System.Windows.Forms.ToolStripMenuItem AddBetTool;
        private System.Windows.Forms.ToolStripMenuItem RemoveBetTool;
        private System.Windows.Forms.ToolStripSeparator toolStrip3;
        private System.Windows.Forms.ToolStripMenuItem UpdateTableTool;
        private System.Windows.Forms.DateTimePicker StartRangeDateTime;
        private System.Windows.Forms.DateTimePicker EndRangeDateTime;
        private System.Windows.Forms.Label RangeLabel;
        private System.Windows.Forms.ToolStripMenuItem ChangeBetStatusTool;
        private System.Windows.Forms.ToolStripMenuItem WinStatusTool;
        private System.Windows.Forms.ToolStripMenuItem LoseStatusTool;
        private System.Windows.Forms.ToolStripMenuItem ReturnStatusTool;
        private System.Windows.Forms.ToolStripMenuItem SaveBetTool;
        private System.Windows.Forms.ToolStripSeparator ToolStrip1;
        private System.Windows.Forms.ToolStripSeparator ToolStrip2;
        private System.Windows.Forms.ToolStripMenuItem SaveBetFileTool;
        private System.Windows.Forms.ToolStripMenuItem SaveBetTelegramTool;
        private System.Windows.Forms.ToolStripMenuItem SettingsTableTool;
        private System.Windows.Forms.ToolStripSeparator toolStrip4;
        private System.Windows.Forms.ToolStripMenuItem TeamTool;
        private System.Windows.Forms.ToolStripMenuItem CompetitionTool;
    }
}

