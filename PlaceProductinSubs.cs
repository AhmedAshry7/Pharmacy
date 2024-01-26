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
    public partial class PlaceProductinSubs : Form
    {
        Controller controllerObj;
        public int subscriptionid { get; set; }
        public int orderid { get; set; }
        public int customerid { get; set; }

        public PlaceProductinSubs()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void PlaceProductinSubs_Load(object sender, EventArgs e)
        {
            label3.Hide();
            comboBox1.DataSource = controllerObj.getProductsinsub(subscriptionid);
            comboBox1.DisplayMember = "PID";
            comboBox1.ValueMember = "PID";
            DataTable dt = controllerObj.getProductsinsub(subscriptionid);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
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
                    if(x< 0)
                    {
                        MessageBox.Show("The Quantity has to be positive");
                        c = false;
                    }
                }
            }
            if (c)
            {
                int q1 = (int)controllerObj.getsbatchid(Convert.ToInt32(comboBox1.SelectedValue));
                int q = (int)controllerObj.getQUANTITY(q1);
                if (q > x)
                {
                    int f = controllerObj.addproductinsubs(orderid, Convert.ToInt32(comboBox1.SelectedValue), x);
                    if (f !=0)
                    {
                        MessageBox.Show("Added");
                        textBox1.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("No enough quantity there is only:" + q);
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
                    if(x< 0)
                    {
                        MessageBox.Show("The Quantity has to be positive");
                        c = false;
                    }
                }
            }
            if (c)
            {
                int q1 = (int)controllerObj.getsbatchid(Convert.ToInt32(comboBox1.SelectedValue));
                int q = (int)controllerObj.getQUANTITY(q1);
                if (q > x)
                {
                    int f = controllerObj.addproductinsubs(orderid, Convert.ToInt32(comboBox1.SelectedValue), x);
                    if (f != 0)
                    {
                        ViewProductsInOrder v = new ViewProductsInOrder();
                        v.orderid = orderid;
                        v.Show();
                        MessageBox.Show("Order Placed");
                        int BDAO = 0, BD = 0, A = 0;
                        int f2 = controllerObj.calculateorder(orderid, customerid, ref BDAO, ref BD, ref A);
                        if (f2 != 0)
                        {
                            A = (int)controllerObj.getafter(orderid);
                            BDAO = (int)controllerObj.getbdao(orderid);
                            BD = (int)controllerObj.getbd(orderid);
                            MessageBox.Show("The price before discounts and offer :" + BDAO);
                            MessageBox.Show("The price before discounts :" + BD);
                            MessageBox.Show("The price after discounts and offer:" + A);
                            int tier = (int)controllerObj.gettier(customerid);
                            int f3 = controllerObj.upgradetier(customerid);
                            int tier2 = (int)controllerObj.gettier(customerid);
                            if (tier2 != tier)
                            {

                                MessageBox.Show("Congratulations the of the customer is now upgraded to tier: " + tier2);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No enough quantity there is only:"+ q);
                    textBox1.Clear();
                }
            }
        }
    }
}
