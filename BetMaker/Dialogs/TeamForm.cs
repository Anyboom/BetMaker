using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetMaker.Models;
using LiteDB;

namespace BetMaker.Dialogs
{
    public partial class TeamForm : Form
    {
        public TeamForm()
        {
            InitializeComponent();

            this.Load += (sender, args) => LoadForm();
        }

        private void LoadForm()
        {
            using LiteDatabase db = new LiteDatabase(Settings.PathDatabase);

            MainList.DataSource = db.GetCollection<Team>("Team").FindAll().ToList();
            MainList.DisplayMember = "Name";
            MainList.ValueMember = "Id";
        }
    }
}
