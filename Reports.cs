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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BudgetVsSpent f = new BudgetVsSpent();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DailyReport f = new DailyReport();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Revenue f = new Revenue();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewSubscriptions f = new NewSubscriptions();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewCustomers f = new NewCustomers();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TotalEmployees f = new TotalEmployees();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BranchPerformance f = new BranchPerformance();
            f.Show();
        }
    }
}
