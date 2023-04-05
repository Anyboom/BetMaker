using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetMaker.Models;
using BetMaker.Services;
using LiteDB;

namespace BetMaker.Dialogs
{
    public partial class TeamForm : Form
    {
        public TeamForm()
        {
            InitializeComponent();

            this.Load += (sender, args) => UpdateList();
            UpdateListTool.Click += (sender, args) => UpdateList();

            AddTeamTool.Click += (sender, args) => AddTeam();
            AddTeamFileTool.Click += (sender, args) => AddTeamFile();
            RemoveTeamTool.Click += (sender, args) => RemoveTeam();
            EditTeamTool.Click += (sender, args) => EditTeam();
        }

        private void EditTeam()
        {
            string name = MessageService.InputBox("Введите новое имя для кошелька:");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            Team teamForEdit = MainList.SelectedItem as Team;

            teamForEdit.Name = name;

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            var teamDb = db.GetCollection<Team>("Team");

            teamDb.Update(teamForEdit);
        }

        private void RemoveTeam()
        {
            Team teamForRemove = MainList.SelectedItem as Team;

            DialogResult result = MessageService.ShowQuestion($"Вы точно собираетесь команду {teamForRemove.Name} ?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

                db.GetCollection<Team>("Team").Delete(teamForRemove.Id);
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
                    teamDB.Insert(new Team() { Name = name });
                }
            }
        }

        private void AddTeam()
        {
            string name = MessageService.InputBox("Введите название команды:");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            Team newTeam = new Team();

            newTeam.Name = name;

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            db.GetCollection<Team>("Team").Insert(newTeam);
        }

        private void UpdateList()
        {
            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            MainList.DataSource = db.GetCollection<Team>("Team").FindAll().ToList();
            MainList.DisplayMember = "Name";
            MainList.ValueMember = "Id";
        }
    }
}
