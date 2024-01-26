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
    public partial class BudgetVsSpent : Form
    {
        Controller controller = new Controller();
        public BudgetVsSpent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controller.BudgetvSpent();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }

        private void BudgetVsSpent_Load(object sender, EventArgs e)
        {

        }
    }
}
