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
    public partial class AddSubscription : Form
    {
        Controller controllerObj;
        public AddSubscription()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddSubscription_Load(object sender, EventArgs e)
        {
            label4.Hide();
            label3.Hide();
            label6.Hide();
            comboBox1.DataSource=controllerObj.getcustomerID();
            comboBox1.DisplayMember = "CustomerID";
            comboBox1.ValueMember = "CustomerID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Hide();
            label3.Hide();
            label6.Hide();
            bool c = true;
            int x = 0,y=0,z=0;
            if (textBox1.Text == "")
            {
                label4.Show();
                c = false;
            }
            else
            {
                if (!int.TryParse(textBox1.Text, out x))
                {
                    MessageBox.Show("The Subscribtion has to be an integer");
                    c = false;
                }
                else
                {
                    if (x < 0)
                    {
                        MessageBox.Show("The Subscribtion has to be positive");
                        c = false;
                    }
                }
            }
            if (textBox2.Text == "")
            {
                label3.Show();
                c = false;
            }
            else
            {
                if (!int.TryParse(textBox2.Text, out y))
                {
                    MessageBox.Show("The interval has to be an integer");
                    c = false;
                }
                else
                {
                    if (y < 0)
                    {
                        MessageBox.Show("The interval has to be postive");
                        c = false;
                    }
                }
            }
            if (textBox3.Text == "")
            {
                label6.Show();
                c = false;
            }
            else
            {
                if (!int.TryParse(textBox3.Text, out z))
                {
                    MessageBox.Show("Active has to be a 1 or 0");
                    c = false;
                }
                else if (z != 0 && z != 1)
                {
                    MessageBox.Show("Active has to be a 1 or 0");
                    c = false;
                }
            }
            if (c)
            {
                int f = controllerObj.addsubscription(x, y, z, Convert.ToInt32(comboBox1.SelectedValue));
                if (f != 0)
                {
                    AddProductInsubscription a=new AddProductInsubscription();
                    a.subscriptionid = x;
                    a.Show();
                }
                else MessageBox.Show("The subscription ID already exists");
            }
        }
    }
}
