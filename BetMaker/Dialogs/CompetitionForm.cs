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
    public partial class CompetitionForm : Form
    {
        public CompetitionForm()
        {
            InitializeComponent();

            this.Load += (sender, args) => UpdateList();
            UpdateListTool.Click += (sender, args) => UpdateList();

            AddCompetitionTool.Click += (sender, args) => AddCompetition();
            AddCompetitionFileTool.Click += (sender, args) => AddCompetitionFile();
            RemoveCompetitionTool.Click += (sender, args) => RemoveCompetition();
            EditCompetitionTool.Click += (sender, args) => EditCompetition();
        }

        private void EditCompetition()
        {
            string name = MessageService.InputBox("Введите новое имя для соревнования:");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            Competition competitionForEdit = MainList.SelectedItem as Competition;

            competitionForEdit.Name = name;

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            var teamDb = db.GetCollection<Competition>("Competition");

            teamDb.Update(competitionForEdit);
        }

        private void RemoveCompetition()
        {
            Competition competitionForRemove = MainList.SelectedItem as Competition;

            DialogResult result = MessageService.ShowQuestion($"Вы точно собираетесь удалить соревнование {competitionForRemove.Name} ?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

                db.GetCollection<Competition>("Competition").Delete(competitionForRemove.Id);
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
                    competitionDB.Insert(new Competition() { Name = name });
                }
            }
        }

        private void AddCompetition()
        {
            string name = MessageService.InputBox("Введите название соревнования:");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            Competition newCompetition = new Competition();

            newCompetition.Name = name;

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            db.GetCollection<Competition>("Competition").Insert(newCompetition);
        }

        private void UpdateList()
        {
            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            MainList.DataSource = db.GetCollection<Competition>("Competition").FindAll().ToList();
            MainList.DisplayMember = "Name";
            MainList.ValueMember = "Id";
        }
    }
}
