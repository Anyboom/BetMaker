using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetMaker.Dialogs;
using BetMaker.Models;
using BetMaker.Services;
using LiteDB;

namespace BetMaker
{
    public partial class MainForm : Form
    {
        private DataTable mainTable;
        public MainForm()
        {
            InitializeComponent();

            mainTable = new DataTable();

            mainTable.Columns.Add("ИД", typeof(int));
            mainTable.Columns.Add("ДОМАШНЯЯ КОМАНДА", typeof(string));
            mainTable.Columns.Add("ГОСТЕВАЯ КОМАНДА", typeof(string));
            mainTable.Columns.Add("ПРОГНОЗ", typeof(string));
            mainTable.Columns.Add("КФ", typeof(string));
            mainTable.Columns.Add("СОРЕВНОВАНИЕ", typeof(string));
            mainTable.Columns.Add("СТАТУС", typeof(object));
            mainTable.Columns.Add("НАЧАЛО", typeof(DateTime));
            mainTable.Columns.Add("СОЗДАНО", typeof(DateTime));

            MainGrid.DataSource = mainTable;

            MainGrid.Sort(MainGrid.Columns[8], ListSortDirection.Descending);

            StartDateTime.Value = DateTime.Now.AddDays(-4);
            EndDateTime.Value = DateTime.Now.AddDays(+4);

        }

        private void AddBetTool_Click(object sender, EventArgs e)
        {
            AddBetForm tempForm = new AddBetForm();
            tempForm.ShowDialog();
        }

        private void MainGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is BetStatus typeFormat)
            {
                e.Value = typeFormat switch
                {
                    BetStatus.NotCalculated => "Не расчитано",
                    BetStatus.Win => "Выигрыш",
                    BetStatus.Lose => "Проигрыш",
                    BetStatus.Return => "Возврат"
                };

                MainGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = typeFormat switch
                {
                    BetStatus.NotCalculated => Color.FromArgb(0x95, 0xa5, 0xa6),
                    BetStatus.Win => Color.FromArgb(0x9a, 0xe8, 0xbb),
                    BetStatus.Lose => Color.FromArgb(0xf6, 0xbb, 0xb5),
                    BetStatus.Return => Color.FromArgb(0xa8, 0xd3, 0xef)
                };
            }

            if ((e.ColumnIndex == 8 || e.ColumnIndex == 7) && e.Value is DateTime dateFormat)
            {
                e.Value = dateFormat.ToString("hh:mm | d MMM yyyy");
            }
        }

        private void RemoveTool_Click(object sender, EventArgs e)
        {
            List<int> ids = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Cells[0].Value)).ToList();

            DialogResult result = MessageService.ShowQuestion("Вы точно хотите удалить выбранные позиции ?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

                var betDb = db.GetCollection<Bet>("Bet");

                foreach (var bet in ids.Select(id => betDb.FindById(id)))
                {
                    bet.IsDeleted = true;
                    betDb.Update(bet);
                }
            }
        }

        private void UpdateTableTool_Click(object sender, EventArgs e)
        {
            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            mainTable.Clear();

            foreach (Bet bet in db.GetCollection<Bet>("Bet").Find(x => x.IsDeleted == false && StartDateTime.Value <= x.StartAt && x.StartAt <= EndDateTime.Value))
            {
                mainTable.Rows.Add(bet.Id, bet.HomeTeam, bet.GuestTeam, bet.Prognosis, bet.Сoefficient, bet.Competition, bet.Result, bet.StartAt, bet.CreatedAt);
            }
        }
    }
}
