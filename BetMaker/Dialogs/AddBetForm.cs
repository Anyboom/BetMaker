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
using LiteDB;

namespace BetMaker.Dialogs
{
    public partial class AddBetForm : Form
    {
        public AddBetForm()
        {
            InitializeComponent();

            AutoCompleteStringCollection teamsAutoComplete = new AutoCompleteStringCollection();
            AutoCompleteStringCollection competiotionsAutoComplete = new AutoCompleteStringCollection();
            AutoCompleteStringCollection prognosesAutoComplete = new AutoCompleteStringCollection();

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            string[] teams = db.GetCollection<Team>("Team").FindAll().Select(x => x.Name).ToArray();
            string[] competitions = db.GetCollection<Competition>("Competition").FindAll().Select(x => x.Name).ToArray();
            string[] prognoses = db.GetCollection<Prognosis>("Prognosis").FindAll().Select(x => x.Name).ToArray();

            teamsAutoComplete.AddRange(teams);
            competiotionsAutoComplete.AddRange(competitions);
            prognosesAutoComplete.AddRange(prognoses);

            HomeTeamTextBox.AutoCompleteCustomSource = teamsAutoComplete;
            GuestTeamTextBox.AutoCompleteCustomSource = teamsAutoComplete;
            CompetitionNameTextBox.AutoCompleteCustomSource = competiotionsAutoComplete;
            PrognosisTextBox.AutoCompleteCustomSource = prognosesAutoComplete;
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            string homeTeamResult = HomeTeamTextBox.Text,
                   guestTeamResult = GuestTeamTextBox.Text,
                   competitionResult = CompetitionNameTextBox.Text,
                   prognosisResult = PrognosisTextBox.Text;

            DateTime startAtResult = StartAtDateTime.Value;
            float coefficientResult = float.Parse(CoefficientTextBox.Text);

            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            var teamDb = db.GetCollection<Team>("Team");
            var competitionDb = db.GetCollection<Competition>("Competition");
            var prognosisDb = db.GetCollection<Prognosis>("Prognosis");

            // Если нет домашней команды, то добавляем.
            if (teamDb.Exists(x => x.Name == homeTeamResult) == false)
            {
                Team TempTeam = new Team()
                {
                    Name = homeTeamResult
                };

                teamDb.Insert(TempTeam);
            }

            // Если нет гостевой команды, то добавляем.
            if (teamDb.Exists(x => x.Name == guestTeamResult) == false)
            {
                Team newTeam = new Team()
                {
                    Name = guestTeamResult
                };

                teamDb.Insert(newTeam);
            }

            // Если нет соревнования, то добавляем.
            if (competitionDb.Exists(x => x.Name == competitionResult) == false)
            {
                Competition newCompetition = new Competition()
                {
                    Name = competitionResult
                };

                competitionDb.Insert(newCompetition);
            }

            // Если нет прогноза, то добавляем.
            if (prognosisDb.Exists(x => x.Name == prognosisResult) == false)
            {
                Prognosis tempPrognosis = new Prognosis()
                {
                    Name = prognosisResult
                };

                prognosisDb.Insert(tempPrognosis);
            }

            Bet newBet = new Bet();

            newBet.HomeTeam = teamDb.FindOne(x => x.Name == homeTeamResult);
            newBet.GuestTeam = teamDb.FindOne(x => x.Name == guestTeamResult);
            newBet.Competition = competitionDb.FindOne(x => x.Name == competitionResult);
            newBet.Prognosis = prognosisDb.FindOne(x => x.Name == prognosisResult);

            newBet.StartAt = startAtResult;
            newBet.Result = BetStatus.NotCalculated;
            newBet.Сoefficient = coefficientResult;
            newBet.CreatedAt = DateTime.Now;
            newBet.IsDeleted = false;

            db.GetCollection<Bet>("Bet").Insert(newBet);
        }
    }
}
