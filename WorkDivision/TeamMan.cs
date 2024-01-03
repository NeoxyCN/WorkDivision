using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace WorkDivision
{
    public partial class TeamMan : Form
    {
        public TeamMan()
        {
            InitializeComponent();
        }

        private void TeamMan_Load(object sender, EventArgs e)
        {
            DataPhrase dp=new DataPhrase();
            string path = Application.StartupPath;
            path += "\\data.txt";
            MyDataBase db=new MyDataBase(path);
            string data=db.ReadData();

            if (data == "None")
            {
                panel_cover.Visible = true;
                button_add.Enabled = false;
                button_save.Enabled = false;
                textBox_name.Enabled = false;
                listBox_team.Enabled = false;
                return;
            }

            //List data load
            dp.Phrase(data);
            //dp.r

            List<string> ls=dp.GetNameList();
            
            foreach (string s in ls)
            {
                listBox_team.Items.Add(s);
            }
        }

        void CreateDB()
        {
            //WriteData
            string StartupPath = Application.StartupPath;
            StartupPath += "\\team.db";
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //listBox_team.
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var name = this.textBox_name.Text.ToString().Replace(" ","");
            if (name == "")
            {
                return;
            }

            if (this.listBox_team.Items.Contains(name))
            {
                MessageBox.Show("这个人已经存在了", "错误", MessageBoxButtons.OK);
            }
            else
            {
                this.listBox_team.Items.Add(name);
                this.textBox_name.Text="";
            }
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //this.listBox_team.Items
        }

        private void listBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.button_delete.Enabled = true;
        }

        private void panel_cover_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
