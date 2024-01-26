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
    public partial class UpdatePrice : Form
    {
        Controller controllerObj;
        public UpdatePrice()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void UpdatePrice_Load(object sender, EventArgs e)
        {
            label3.Hide();
            comboBox1.DataSource=controllerObj.getproductids();
            comboBox1.DisplayMember = "PID";
            comboBox1.ValueMember = "PID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Hide();
            bool c = true;
            float x = 0;
            if (textBox1.Text == "")
            {
                label3.Show();
                c = false;
            }
            else
            {
                if(!float.TryParse(textBox1.Text,out x))
                {
                    MessageBox.Show("The price has to be a number");
                    c = false;
                }
                else
                {
                    if (x < 0)
                    {
                        MessageBox.Show("The price has to be positive");
                        c = false;
                    }
                }
            }
            if (c)
            {
                int f = controllerObj.updateprice(Convert.ToInt32(comboBox1.SelectedValue), x);
                if (f == 1)
                {
                    MessageBox.Show("Done");
                }
            }
        }
    }
}
