using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class AddBetForm : Form
    {
        public Bet NewBet = new Bet(); 
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

            MainButton.Click += (sender, args) => AddBet();
        }

        private void AddBet()
        {
            string homeTeamResult = HomeTeamTextBox.Text,
                guestTeamResult = GuestTeamTextBox.Text,
                competitionResult = CompetitionNameTextBox.Text,
                prognosisResult = PrognosisTextBox.Text,
                coefficientText = CoefficientTextBox.Text;

            DateTime startAtResult = StartAtDateTime.Value;
            float coefficientResult = default;

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(homeTeamResult))
            {
                errors.AppendLine("[Домашняя команда]: Поле не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(guestTeamResult))
            {
                errors.AppendLine("[Гостевая команда]: Поле не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(competitionResult))
            {
                errors.AppendLine("[Название мероприятия]: Поле не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(prognosisResult))
            {
                errors.AppendLine("[Прогноз]: Поле не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(coefficientText))
            {
                errors.AppendLine("[Коэффициент]: Поле не может быть пустым.");
            }

            if (startAtResult <= DateTime.Now)
            {
                errors.AppendLine("[Дата и время мероприятия]: Событие не может быть в прошлом.");
            }

            if (float.TryParse(coefficientText, NumberStyles.Any, CultureInfo.InvariantCulture, out
                    coefficientResult) == false)
            {
                errors.AppendLine("[Коэффициент]: Поле должно состоять только из одного дробного числа.");
            }

            if (errors.Length > 0)
            {
                MessageService.ShowError(errors.ToString());
                return;
            }

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

            NewBet.HomeTeam = teamDb.FindOne(x => x.Name == homeTeamResult);
            NewBet.GuestTeam = teamDb.FindOne(x => x.Name == guestTeamResult);
            NewBet.Competition = competitionDb.FindOne(x => x.Name == competitionResult);
            NewBet.Prognosis = prognosisDb.FindOne(x => x.Name == prognosisResult);

            NewBet.StartAt = startAtResult;
            NewBet.Result = BetStatus.NotCalculated;
            NewBet.Сoefficient = coefficientResult;
            NewBet.CreatedAt = DateTime.Now;
            NewBet.IsDeleted = false;

            NewBet.Id = db.GetCollection<Bet>("Bet").Insert(NewBet);

            DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
