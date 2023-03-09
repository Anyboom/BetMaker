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

namespace BetMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddBetTool_Click(object sender, EventArgs e)
        {
            AddBetForm tempForm = new AddBetForm();
            tempForm.ShowDialog();
        }
    }
}
