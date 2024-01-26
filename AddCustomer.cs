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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class AddCustomer : Form
    {
        Controller controllerObj;
        public AddCustomer()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            bool c = true;
            if (textBox1.Text == "")
            {
                label6.Show();
                c = false;
            }
            if (textBox2.Text == "")
            {
                label7.Show();
                c = false;
            }
            if (textBox3.Text == "")
            {
                label8.Show();
                c = false;
            }
            if (textBox4.Text == "")
            {
                label9.Show();
                c = false;
            }
            int x;
            ulong y;
            if (!int.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("The Customer ID has to be an integer");
                c = false;
            }
            else
            {
                if (x < 0)
                {
                    MessageBox.Show("The ID has to be an positive");
                    c = false;
                }
            }
            if (!ulong.TryParse(textBox4.Text, out y))
            {
                MessageBox.Show("The Phone number has to be an integer");
                c = false;
            }
            else
            {
                if (y < 0)
                {
                    MessageBox.Show("The Phone number has to be an positive");
                    c = false;
                }
            }
            if (textBox4.Text.Length != 11)
            {
                MessageBox.Show("The Phone number has to be 11 number");
                c = false;
            }
            if (c)
            {
                int f=controllerObj.insertcustomer(x,textBox2.Text,textBox3.Text,textBox4.Text);
                if (f == 1)
                {
                    MessageBox.Show("Done");
                }
                else
                    MessageBox.Show("This ID is already existing");
            }
        }
    }
}
