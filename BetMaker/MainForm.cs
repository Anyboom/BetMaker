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

            StartRangeDateTime.Value = DateTime.Now.AddDays(-4);
            EndRangeDateTime.Value = DateTime.Now.AddDays(+4);

            AddBetTool.Click += (sender, args) => AddBet();
            MainGrid.CellFormatting += (sender, args) => MainGridCellFormatting(args);
            RemoveBetTool.Click += (sender, args) => RemoveBet();
            UpdateTableTool.Click += (sender, args) => UpdateTable();
            WinStatusTool.Click += (sender, args) => ChangeBetStatus(BetStatus.Win);
            LoseStatusTool.Click += (sender, args) => ChangeBetStatus(BetStatus.Lose);
            ReturnStatusTool.Click += (sender, args) => ChangeBetStatus(BetStatus.Return);

            SaveBetFileTool.Click += (sender, args) => SaveBetFile();
            SaveBetTelegramTool.Click += (sender, args) => SaveBetTelegram();

            SettingsTableTool.Click += (sender, args) => UpdateSettings();
            TeamTool.Click += (sender, args) => UpdateTeams();

        }

        private void UpdateTeams()
        {
            TeamForm teamForm = new TeamForm();

            teamForm.ShowDialog();
        }

        private void UpdateSettings()
        {
            SettingsForm settingsForm = new SettingsForm();

            settingsForm.ShowDialog();
        }

        private void SaveBetTelegram()
        {
            if (InternetService.CheckConnection() == false)
            {
                MessageService.ShowWarn("Проверьте интернет соединение.");
                return;
            }
            
            List<int> ids = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Cells[0].Value)).ToList();

            if (ids.Count == 0)
            {
                return;
            }

            SaveTelegramForm saveForm = new SaveTelegramForm(ids);
            DialogResult result = saveForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageService.ShowInfo("Записи успешно добавлены");
            }
        }

        private void SaveBetFile()
        {
            List<int> ids = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Cells[0].Value)).ToList();

            if (ids.Count == 0)
            {
                return;
            }

            SaveFileForm saveForm = new SaveFileForm(ids);
            saveForm.ShowDialog();
        }

        private void ChangeBetStatus(BetStatus betStatus)
        {
            List<int> ids = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Cells[0].Value)).ToList();
            List<int> idsCells = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Index)).ToList();

            if (ids.Count == 0)
            {
                return;
            }

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            var betDb = db.GetCollection<Bet>("Bet");

            foreach (var bet in ids.Select(id => betDb.FindById(id)))
            {
                bet.Result = betStatus;
                betDb.Update(bet);
            }

            idsCells.ForEach(x => MainGrid.Rows[x].Cells[6].Value = betStatus);
        }

        private void MainGridCellFormatting(DataGridViewCellFormattingEventArgs e)
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
                e.Value = dateFormat.ToString("HH:mm | d MMM yyyy");
            }
        }

        private void AddBet()
        {
            AddBetForm tempForm = new AddBetForm();
            
            DialogResult result = tempForm.ShowDialog();

            if (result == DialogResult.OK && StartRangeDateTime.Value <= tempForm.NewBet.StartAt && tempForm.NewBet.StartAt <= EndRangeDateTime.Value)
            {
                mainTable.Rows.Add(tempForm.NewBet.Id, tempForm.NewBet.HomeTeam, tempForm.NewBet.GuestTeam, tempForm.NewBet.Prognosis, tempForm.NewBet.Coefficient, tempForm.NewBet.Competition, tempForm.NewBet.Result, tempForm.NewBet.StartAt, tempForm.NewBet.CreatedAt);
            }
        }

        private void RemoveBet()
        {
            List<int> ids = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Cells[0].Value)).ToList();
            List<int> idsCells = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Index)).ToList();

            if (ids.Count == 0)
            {
                return;
            }

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

                idsCells.ForEach(x => MainGrid.Rows.RemoveAt(x));
            }
        }

        private void UpdateTable()
        {
            if (StartRangeDateTime.Value > EndRangeDateTime.Value)
            {
                return;
            }

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            mainTable.Clear();

            foreach (Bet bet in db.GetCollection<Bet>("Bet").Find(x => x.IsDeleted == false && StartRangeDateTime.Value <= x.StartAt && x.StartAt <= EndRangeDateTime.Value))
            {
                mainTable.Rows.Add(bet.Id, bet.HomeTeam, bet.GuestTeam, bet.Prognosis, bet.Coefficient, bet.Competition, bet.Result, bet.StartAt, bet.CreatedAt);
            }
        }
    }
}
