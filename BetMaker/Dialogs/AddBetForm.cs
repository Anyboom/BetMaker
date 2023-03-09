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

            AutoCompleteStringCollection TeamsAutoComplete = new AutoCompleteStringCollection();
            AutoCompleteStringCollection CompetiotionsAutoComplete = new AutoCompleteStringCollection();
            AutoCompleteStringCollection PrognosesAutoComplete = new AutoCompleteStringCollection();

            using LiteDatabase Db = new LiteDatabase(Settings.PathDatabase);

            string[] Teams = Db.GetCollection<Team>("Team").FindAll().Select(x => x.Name).ToArray();
            string[] Competitions = Db.GetCollection<Competition>("Competition").FindAll().Select(x => x.Name).ToArray();
            string[] Prognoses = Db.GetCollection<Prognosis>("Prognosis").FindAll().Select(x => x.Name).ToArray();

            TeamsAutoComplete.AddRange(Teams);
            CompetiotionsAutoComplete.AddRange(Competitions);
            PrognosesAutoComplete.AddRange(Prognoses);

            HomeTeamTextBox.AutoCompleteCustomSource = TeamsAutoComplete;
            GuestTeamTextBox.AutoCompleteCustomSource = TeamsAutoComplete;
            CompetitionNameTextBox.AutoCompleteCustomSource = CompetiotionsAutoComplete;
            PrognosisTextBox.AutoCompleteCustomSource = PrognosesAutoComplete;
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            string HomeTeamResult = HomeTeamTextBox.Text,
                   GuestTeamResult = GuestTeamTextBox.Text,
                   CompetitionResult = CompetitionNameTextBox.Text,
                   PrognosisResult = PrognosisTextBox.Text;

            DateTime StartAtResult = StartAtDateTime.Value;
            float CoefficientResult = float.Parse(CoefficientTextBox.Text);

            using LiteDatabase Db = new LiteDatabase(Settings.PathDatabase);

            var TeamDb = Db.GetCollection<Team>("Team");
            var CompetitionDb = Db.GetCollection<Competition>("Competition");
            var PrognosisDb = Db.GetCollection<Prognosis>("Prognosis");

            // Если нет домашней команды, то добавляем.
            if (TeamDb.Exists(x => x.Name == HomeTeamResult) == false)
            {
                Team TempTeam = new Team()
                {
                    Name = HomeTeamResult
                };

                TeamDb.Insert(TempTeam);
            }

            // Если нет гостевой команды, то добавляем.
            if (TeamDb.Exists(x => x.Name == GuestTeamResult) == false)
            {
                Team TempTeam = new Team()
                {
                    Name = GuestTeamResult
                };

                TeamDb.Insert(TempTeam);
            }

            // Если нет соревнования, то добавляем.
            if (CompetitionDb.Exists(x => x.Name == CompetitionResult) == false)
            {
                Competition TempCompetition = new Competition()
                {
                    Name = CompetitionResult
                };

                CompetitionDb.Insert(TempCompetition);
            }

            // Если нет прогноза, то добавляем.
            if (PrognosisDb.Exists(x => x.Name == PrognosisResult) == false)
            {
                Prognosis TempPrognosis = new Prognosis()
                {
                    Name = PrognosisResult
                };

                PrognosisDb.Insert(TempPrognosis);
            }

            Bet BetResult = new Bet();

            BetResult.HomeTeam = TeamDb.FindOne(x => x.Name == HomeTeamResult);
            BetResult.GuestTeam = TeamDb.FindOne(x => x.Name == GuestTeamResult);
            BetResult.Competition = CompetitionDb.FindOne(x => x.Name == CompetitionResult);
            BetResult.Prognosis = PrognosisDb.FindOne(x => x.Name == PrognosisResult);

            BetResult.StartAt = StartAtResult;
            BetResult.Result = BetStatus.NotCalculated;
            BetResult.Сoefficient = CoefficientResult;
            BetResult.CreatedAt = DateTime.Now;

            Db.GetCollection<Bet>("Bet").Insert(BetResult);

            Db.Commit();
        }
    }
}
