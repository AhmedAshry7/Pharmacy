using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Revenue : Form
    {
        Controller controller = new Controller();
        public Revenue()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool t1 = true;
            if (!int.TryParse(textBox1.Text, out _) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label6.Show();
                t1 = false;
            }
            else
                label6.Hide();
            if(t1)
            {
                DataTable dt = new DataTable();
                dt = controller.Revenue(textBox1.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            label6.Hide();
        }
    }
}
