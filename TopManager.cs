using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class TopManager : Form
    {
        StartForm SF;
        string ID;
        public TopManager(StartForm sf, string iD)
        {
            InitializeComponent();
            SF = sf;
            ID = iD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SF.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FireManager fm = new FireManager();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddManager f = new AddManager();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddBranch f = new AddBranch();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteBranch f = new DeleteBranch();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UPDATEMANAGER f = new UPDATEMANAGER();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CreateManager f = new CreateManager();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddBranch f = new AddBranch();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            UPDATEMANAGER f = new UPDATEMANAGER();
            f.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(ID);
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            UpdateBranchBudget f = new UpdateBranchBudget();
            f.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddSup f = new AddSup();
            f.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DelSup f = new DelSup();
            f.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Reports f = new Reports();
            f.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Reviews f = new Reviews();
            f.Show();
        }

        private void TopManager_Load(object sender, EventArgs e)
        {

        }
    }
}
