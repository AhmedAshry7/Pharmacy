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
    public partial class AddManager : Form
    {
        Controller controllerObj;
        public AddManager()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AddManager_Load(object sender, EventArgs e)
        {
            label9.Hide();
            label10.Hide();
            label11.Hide();
   
            label13.Hide();
            label14.Hide();
            label15.Hide();
            comboBox1.DataSource = controllerObj.getbranchID();
            comboBox1.DisplayMember = "BranchID";
            comboBox1.ValueMember = "BranchID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Hide();
            label10.Hide();
            label11.Hide();

            label13.Hide();
            label14.Hide();
            label15.Hide();
            bool c = true;
            int x = 0;
            ulong z=0;
            float y = 0;


            if (textBox1.Text == "")
            {
                label9.Show();
                c = false;
            }
            else
            {
                if (!int.TryParse(textBox1.Text, out x))
                {
                    MessageBox.Show("The Manager ID has to be an integer");
                    c = false;
                }
                else
                {
                    if (x < 0)
                    {
                        MessageBox.Show("The ID has to be positive");
                        c = false;
                    }
                }
            }
            if (textBox2.Text == "")
            {
                label10.Show();
                c = false;
            }
            if (textBox3.Text == "")
            {
                label11.Show();
                c = false;
            }
            else
            {
                if (!float.TryParse(textBox3.Text, out y))
                {
                    MessageBox.Show("The Salary has to be a number");
                    c = false;
                }
                else
                {
                    if (y < 0)
                    {
                        MessageBox.Show("The Salary has to be positive");
                        c = false;
                    }
                }
            }

            if (textBox5.Text == "")
            {
                label13.Show();
                c = false;
            }
            else
            {
                if (!ulong.TryParse(textBox5.Text, out z))
                {
                    MessageBox.Show("The Phone Number has to be an integer");
                    c = false;
                }
                else
                {
                    if (textBox5.Text.Length != 11)
                    {
                        MessageBox.Show("The Phone number has to be 11 number");
                        c = false;
                    }
                    else
                    {
                        if (z < 0)
                        {
                            MessageBox.Show("The Phone number has to be positive");
                            c = false;
                        }
                    }
                }
            }
            if (textBox6.Text == "")
            {
                label14.Show();
                c = false;
            }
            if (textBox7.Text == "")
            {
                label15.Show();
                c = false;
            }
            else
            {
                if (textBox7.Text.Length < 8)
                {
                    MessageBox.Show("The Password has to be more than 8 characters");
                    c = false;
                }
            }
            if (c)
            {
                int f = controllerObj.insertmanager(x, textBox2.Text, y, "Manager", textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToInt32(comboBox1.SelectedValue));
                if (f == 2)
                {
                    MessageBox.Show("Done");
                }
                else
                    MessageBox.Show("This ID is already existing ");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
