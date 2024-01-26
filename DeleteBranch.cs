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
    public partial class DeleteBranch : Form
    {
        Controller controllerObj;
        public DeleteBranch()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int branchID;
            if(BranchIDTextBox.Text == "") { MessageBox.Show("Please enter the ID of the branch you want to remove"); return; }
            try { branchID = int.Parse(BranchIDTextBox.Text); }
            catch { MessageBox.Show("You must enter a number"); return; }

            if(branchID < 0) { MessageBox.Show("Can't enter a negative BranchID"); return; }
            int check = controllerObj.deleteBranch(branchID);
            if (check == 0) { MessageBox.Show("Branch not Deleted. Make sure you entered a valid BranchID"); }
            else { MessageBox.Show("Branch Deleted Successfully"); BranchIDTextBox.Text = "";}
        }
    }
}
