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

namespace BetMaker.Dialogs
{
    public partial class AddBetForm : Form
    {
        public AddBetForm()
        {
            InitializeComponent();

            AutoCompleteStringCollection TeamsAutoComplete = new AutoCompleteStringCollection();
            AutoCompleteStringCollection EventsAutoComplete = new AutoCompleteStringCollection();
            AutoCompleteStringCollection PrognosesAutoComplete = new AutoCompleteStringCollection();

            if (File.Exists(Settings.PathTeams))
            {
                TeamsAutoComplete.AddRange(File.ReadAllLines(Settings.PathTeams));
            }

            if (File.Exists(Settings.PathEvents))
            {
                EventsAutoComplete.AddRange(File.ReadAllLines(Settings.PathEvents));
            }

            if (File.Exists(Settings.PathPrognoses))
            {
                PrognosesAutoComplete.AddRange(File.ReadAllLines(Settings.PathPrognoses));
            }

            HomeTeamTextBox.AutoCompleteCustomSource = TeamsAutoComplete;
            GuestTeamTextBox.AutoCompleteCustomSource = TeamsAutoComplete;
            EventNameTextBox.AutoCompleteCustomSource = EventsAutoComplete;
            PrognosisTextBox.AutoCompleteCustomSource = PrognosesAutoComplete;


        }
    }
}
