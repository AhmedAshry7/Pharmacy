using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class UpdateBranchBudget : Form
    {
        Controller controllerObj;
        public UpdateBranchBudget()
        {
            
            InitializeComponent();
            controllerObj = new Controller();
            
            comboBox1.DataSource = controllerObj.getbranchID();
            comboBox1.DisplayMember = "BranchID";
            comboBox1.ValueMember = "BranchID";
        }

        private void UpdateBranchBudget_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newBudget = textBox1.Text;

            if (!int.TryParse(newBudget, out int budget) && budget > 0)
            {
                label3.Visible = true;
                return;
            }

            int ret = controllerObj.UpdateBudget(comboBox1.SelectedValue.ToString(), newBudget);

            if (ret == 1)
                MessageBox.Show("Budget Updated Successfully!");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
