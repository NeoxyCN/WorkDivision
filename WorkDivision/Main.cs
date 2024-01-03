using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkDivision
{
    public partial class Main : Form
    {
        MyDataBase db_team = new MyDataBase("team");

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button_list_Click(object sender, EventArgs e)
        {
            TeamMan teamMan= new TeamMan();
            teamMan.Show();
        }
    }
}
