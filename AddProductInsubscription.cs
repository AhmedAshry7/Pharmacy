using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DBapplication
{
    public partial class AddProductInsubscription : Form
    {
        Controller controllerObj;
        public int subscriptionid { get; set; }
        public AddProductInsubscription()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void AddProductInsubscription_Load(object sender, EventArgs e)
        {
            label3.Hide();
            comboBox1.DataSource = controllerObj.getpID();
            comboBox1.DisplayMember = "PID";
            comboBox1.ValueMember = "PID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Hide();
            bool c = true;
            int x = 0;
            if (textBox1.Text == "")
            {
                label3.Show();
                c = false;
            }
            else
            {
                if (!int.TryParse(textBox1.Text, out x))
                {
                    MessageBox.Show("The Quantity has to be a number");
                    c = false;
                }
                else
                {
                    if (x < 0)
                    {
                        MessageBox.Show("The Quantity has to be positive");
                        c = false;
                    }
                }
            }
            if (c)
            {
                    int f = controllerObj.addproductinsubscription(Convert.ToInt32(comboBox1.SelectedValue),subscriptionid, x);
                    if (f !=0)
                    {
                        MessageBox.Show("Added");
                        textBox1.Clear();
                    }
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Hide();
            bool c = true;
            int x = 0;
            if (textBox1.Text == "")
            {
                label3.Show();
                c = false;
            }
            else
            {
                if (!int.TryParse(textBox1.Text, out x))
                {
                    MessageBox.Show("The Quantity has to be a number");
                    c = false;
                }
                else
                {
                    if (x < 0)
                    {
                        MessageBox.Show("The Quantity has to be positive");
                        c = false;
                    }
                }
            }
            if (c)
            {
                int f = controllerObj.addproductinsubscription(Convert.ToInt32(comboBox1.SelectedValue), subscriptionid, x);
                if (f !=0)
                {
                    MessageBox.Show("Subscription saved");
                    textBox1.Clear();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }
