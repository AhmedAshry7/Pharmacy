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
    public partial class AddBranch : Form
    {
        Controller controllerObj;
        public AddBranch()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(BudgetTextBox.Text == "" || LocationTextBox.Text == "" || EmployeeIDTextBox.Text == "")  //checks if any text box is empty
            {
                MessageBox.Show("Please enter all the information");
                return;
            }
            else
            {
                float budget;
                int employeeID;
                try { budget = float.Parse(BudgetTextBox.Text); }
                catch { MessageBox.Show("Enter a valid Budget"); return; }
                if(budget <0)
                {
                    MessageBox.Show("Budget can't be negative");
                    return;
                }

                try { employeeID = int.Parse(EmployeeIDTextBox.Text); }
                catch { MessageBox.Show("Enter a valid ManagerID"); return; }
                if (employeeID < 0)
                {
                    MessageBox.Show("ManagerID can't be negative");
                    return;
                }
                int check = controllerObj.addBranch(budget, LocationTextBox.Text, employeeID);
                

                if(check == 0) { MessageBox.Show("Branch not added. Make sure all the data entered were valid."); }
                else {
                    MessageBox.Show("Branch Added Successfully");
                    BudgetTextBox.Text = "";
                    LocationTextBox.Text = "";
                    EmployeeIDTextBox.Text = "";
                }
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BudgetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBranch_Load(object sender, EventArgs e)
        {

        }
    }
}
