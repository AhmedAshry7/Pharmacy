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
    public partial class Restock : Form
    {
        Controller controller = new Controller();
        int BranchID;
        public Restock(int branchID)
        {
            InitializeComponent();
            BranchID = branchID;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool t1 = true;
            bool t2 = true;
            bool t3 = true;
            bool t4 = true;
            if (!int.TryParse(textBox1.Text, out _) || string.IsNullOrWhiteSpace(textBox1.Text) || Convert.ToInt32(textBox1.Text) < 0)
            {
                label6.Show();
                t1 = false;
            }
            else
                label6.Hide() ;
            if (!float.TryParse(textBox3.Text, out _) || string.IsNullOrWhiteSpace(textBox3.Text) || Convert.ToSingle(textBox3.Text) < 0)
            {
                label7.Show();
                t2 = false;
            }
            else
                label7.Hide();
            if (!int.TryParse(textBox2.Text, out _) || string.IsNullOrWhiteSpace(textBox2.Text) || Convert.ToInt32(textBox2.Text) <= 0)
            {
                label4.Show();
                t3 = false;
            }
            else
                label4.Hide();
            if (!DateTime.TryParse(textBox4.Text, out _) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                label9.Show();
                t4 = false;
            }
            else
                label9.Hide();
            if(t1 && t2 && t3 && t4)
            {
                int x = controller.Restock(textBox1.Text, comboBox2.SelectedValue.ToString(), textBox2.Text, textBox3.Text, BranchID.ToString(), textBox4.Text);
                if(x == 1)
                {
                    MessageBox.Show("Restock Successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(x == 0)
                {
                    MessageBox.Show("Expiry Date Has Passed Please Enter A Valid Expiry Date ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Batch ID already In Use", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Restock_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = controller.GetProducts();
            comboBox2.DisplayMember = "Pname";
            comboBox2.ValueMember = "PID";
            label6.Hide();
            label7.Hide();
            label9.Hide();
            label4.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
