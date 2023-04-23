using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using BetMaker.Models;
using BetMaker.Services;

using LiteDB;

namespace BetMaker.Dialogs
{
    public partial class CompetitionForm : Form
    {
        private DataTable mainTable;

        public CompetitionForm()
        {
            InitializeComponent();

            mainTable = new DataTable();

            mainTable.Columns.Add("ИД", typeof(int));
            mainTable.Columns.Add("НАЗВАНИЕ", typeof(string));

            this.Load += (sender, args) => UpdateList();
            UpdateListTool.Click += (sender, args) => UpdateList();

            AddCompetitionTool.Click += (sender, args) => AddCompetition();
            AddCompetitionFileTool.Click += (sender, args) => AddCompetitionFile();
            RemoveCompetitionTool.Click += (sender, args) => RemoveCompetition();
            EditCompetitionTool.Click += (sender, args) => EditCompetition();

            MainGrid.DataSource = mainTable;
        }

        private void EditCompetition()
        {
            List<int> ids = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Cells[0].Value))
                .ToList();
            List<int> idsCells = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Index)).ToList();

            if (ids.Count == 0 || ids.Count > 1)
            {
                return;
            }

            string name = MessageService.InputBox("Введите новое имя для соревнования:");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);
            var competitionDb = db.GetCollection<Competition>("Competition");

            Competition competitionForEdit = competitionDb.FindById(ids.First());

            competitionForEdit.Name = name;

            competitionDb.Update(competitionForEdit);

            mainTable.Rows[idsCells.First()][1] = name;
        }

        private void RemoveCompetition()
        {
            List<int> ids = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Cells[0].Value))
                .ToList();
            List<int> idsCells = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Index)).ToList();

            if (ids.Count == 0)
            {
                return;
            }

            DialogResult result = MessageService.ShowQuestion($"Вы точно собираетесь удалить соревнование в количестве {ids.Count} ?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);
                var competitionDb = db.GetCollection<Competition>("Competition");

                competitionDb.DeleteMany(x => ids.Contains(x.Id));
                idsCells.ForEach(x => mainTable.Rows.RemoveAt(x));
            }
        }

        private void AddCompetitionFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string[] teams = File.ReadAllLines(openFileDialog.FileName);

                using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

                var competitionDB = db.GetCollection<Competition>("Competition");

                foreach (var name in teams)
                {
                    int id = competitionDB.Insert(new Competition() { Name = name });
                    mainTable.Rows.Add(id, name);
                }
            }
        }

        private void AddCompetition()
        {
            string name = MessageService.InputBox("Введите название соревнования:", "Новое название для соревнования");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            Competition newCompetition = new Competition();

            newCompetition.Name = name;

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            int id = db.GetCollection<Competition>("Competition").Insert(newCompetition);

            mainTable.Rows.Add(id, name);
        }

        private void UpdateList()
        {
            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            mainTable.Clear();

            foreach (Competition competition in db.GetCollection<Competition>("Competition").FindAll())
            {
                mainTable.Rows.Add(competition.Id, competition.Name);
            }
        }
    }
}
