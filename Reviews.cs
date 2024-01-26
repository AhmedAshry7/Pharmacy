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
    public partial class Reviews : Form
    {
        Controller controller = new Controller();
        public Reviews()
        {
            InitializeComponent();

        }

        private void Reviews_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controller.GetBranches();
            comboBox1.DisplayMember = "BranchID";
            comboBox1.ValueMember = "BranchID";
            label6.Hide();
            label2.Hide();
            label4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool t1 = true;
            bool t2 = true;
            bool t3 = true;
            if (!float.TryParse(textBox1.Text, out _) || string.IsNullOrWhiteSpace(textBox1.Text) || Convert.ToSingle(textBox1.Text) < 0)
            {
                label6.Show();
                t1 = false;
            }
            else
                label6.Hide();
            if (!float.TryParse(textBox2.Text, out _) || string.IsNullOrWhiteSpace(textBox2.Text) || Convert.ToSingle(textBox2.Text) > 5)
            {
                label4.Show();
                t2 = false;
            }
            else
                label4.Hide();
            if(t1 && t2)
            {
                if (Convert.ToSingle(textBox1.Text) > Convert.ToSingle(textBox2.Text))
                {
                    label2.Show();
                    t3 = false;
                }
                else
                    label2.Hide();
            }
            if(t1 && t2 && t3)
            {
                DataTable dt = new DataTable();
                dt = controller.Reviews(comboBox1.SelectedValue.ToString(),textBox1.Text,textBox2.Text);
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
