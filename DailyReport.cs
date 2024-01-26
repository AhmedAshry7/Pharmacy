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
    public partial class DailyReport : Form
    {
        Controller controller = new Controller();
        public DailyReport()
        {
            InitializeComponent();

        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            label9.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool t1 = true;
            if (!DateTime.TryParse(textBox4.Text, out DateTime datevalue) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                label9.Show();
                t1 = false;
            }
            else
                label9.Hide();
            if (t1)
            {
                DataTable dt = new DataTable();
                dt = controller.DailyReport(datevalue.ToString());
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
        }
    }
}
