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
    public partial class TeamForm : Form
    {
        private DataTable mainTable;
        public TeamForm()
        {
            InitializeComponent();

            mainTable = new DataTable();

            mainTable.Columns.Add("ИД", typeof(int));
            mainTable.Columns.Add("НАЗВАНИЕ", typeof(string));

            this.Load += (sender, args) => UpdateList();
            UpdateListTool.Click += (sender, args) => UpdateList();

            AddTeamTool.Click += (sender, args) => AddTeam();
            AddTeamFileTool.Click += (sender, args) => AddTeamFile();
            RemoveTeamTool.Click += (sender, args) => RemoveTeam();
            EditTeamTool.Click += (sender, args) => EditTeam();

            MainGrid.DataSource = mainTable;
        }

        private void EditTeam()
        {
            List<int> ids = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Cells[0].Value))
                .ToList();
            List<int> idsCells = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Index)).ToList();

            if (ids.Count == 0 || ids.Count > 1)
            {
                return;
            }

            string name = MessageService.InputBox("Введите новое имя для команды:");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);
            var teamDb = db.GetCollection<Team>("Team");

            Team teamForEdit = teamDb.FindById(ids.First());

            teamForEdit.Name = name;

            teamDb.Update(teamForEdit);

            mainTable.Rows[idsCells.First()][1] = name;
        }

        private void RemoveTeam()
        {
            List<int> ids = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Cells[0].Value))
                .ToList();
            List<int> idsCells = MainGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => Convert.ToInt32(x.Index)).ToList();

            if (ids.Count == 0)
            {
                return;
            }

            DialogResult result = MessageService.ShowQuestion($"Вы точно собираетесь удалить команды в количестве {ids.Count} ?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);
                var teamDb = db.GetCollection<Team>("Team");

                teamDb.DeleteMany(x => ids.Contains(x.Id));
                idsCells.ForEach(x => mainTable.Rows.RemoveAt(x));
            }
        }

        private void AddTeamFile()
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

                var teamDB = db.GetCollection<Team>("Team");

                foreach (var name in teams)
                {
                    int id = teamDB.Insert(new Team() { Name = name });
                    mainTable.Rows.Add(id, name);
                }
            }
        }

        private void AddTeam()
        {
            string name = MessageService.InputBox("Введите название команды:", "Новое название для команды");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            Team newTeam = new Team();

            newTeam.Name = name;

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            int id = db.GetCollection<Team>("Team").Insert(newTeam);
            mainTable.Rows.Add(id, name);
        } 

        private void UpdateList()
        {
            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            foreach (Team team in db.GetCollection<Team>("Team").FindAll())
            {
                mainTable.Rows.Add(team.Id, team.Name);
            }
        }
    }
}
