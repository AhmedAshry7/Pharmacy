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
    public partial class Addproducttoorder : Form
    {
        Controller controllerObj;
        public int orderid { get; set; }
        public int customerid { get; set; }

        public int branchid { get; set; }
        public Addproducttoorder()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Addproducttoorder_Load(object sender, EventArgs e)
        {
            label3.Hide();
            comboBox1.DataSource=controllerObj.getbatchids(branchid);
            comboBox1.DisplayMember= "BatchID";
            comboBox1.ValueMember = "BatchID";
            DataTable dt = controllerObj.getbatchids(branchid);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Hide();
            bool c = true; 
            int x = 0;
            if (textBox1.Text == "")
            {
                label3.Show();
                c= false;
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
                int q = (int)controllerObj.getQUANTITY(Convert.ToInt32( comboBox1.SelectedValue));
                if (q > x)
                {
                    int f = controllerObj.addproductinorder(orderid, Convert.ToInt32(comboBox1.SelectedValue), x);
                    if (f == 2)
                    {
                        MessageBox.Show("Added");
                        textBox1.Clear();
                        DataTable dt = controllerObj.getbatchids(branchid);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("No enough quantity");
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
                int q = (int)controllerObj.getQUANTITY(Convert.ToInt32(comboBox1.SelectedValue));
                if (q > x)
                {
                    int f = controllerObj.addproductinorder(orderid, Convert.ToInt32(comboBox1.SelectedValue), x);
                    if (f != 0)
                    {
                        ViewProductsInOrder v=new ViewProductsInOrder();
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
                            DataTable dt = controllerObj.getbatchids(branchid);
                            dataGridView1.DataSource = dt;
                            dataGridView1.Refresh();
                            if (tier2 != tier)
                            {
                                
                                MessageBox.Show("Congratulations the of the customer is now upgraded to tier: " + tier2);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No enough quantity");
                    textBox1.Clear();
                    DataTable dt = controllerObj.getbatchids(branchid);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
