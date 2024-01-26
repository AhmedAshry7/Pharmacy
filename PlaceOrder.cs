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
    public partial class PlaceOrder : Form
    {
        Controller controllerObj;
        public int emid { get; set; }
        public int brid { get; set; }
        public PlaceOrder(int employeeid,int branchid)
        {
            InitializeComponent();
            controllerObj = new Controller();
            emid = employeeid;
            brid = branchid;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            label4.Hide();
            comboBox2.DataSource = controllerObj.getcustomerID();
            comboBox2.DisplayMember = "CustomerID";
            comboBox2.ValueMember = "CustomerID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Hide();
            bool c = true;
            int x = 0;
            if (textBox1.Text == "")
            {
                label4.Show();
                c = false;
            }
            else
            {
                if (!int.TryParse(textBox1.Text, out x))
                {
                    MessageBox.Show("The OrderID has to be a number");
                    c = false;
                }
                else
                {
                    if(x< 0)
                    {
                        MessageBox.Show("The OrderID has to be positive");
                        c = false;
                    }
                }
            }
            if (c)
            {
                int f=controllerObj.addorder(x,emid,Convert.ToInt32(comboBox2.SelectedValue));
                if (f == 1)
                {
                    Addproducttoorder a= new Addproducttoorder();
                    a.orderid = x;
                    a.customerid = Convert.ToInt32(comboBox2.SelectedValue);
                    a.branchid= Convert.ToInt32(brid);
                    a.Show();
                }
                else MessageBox.Show("The order ID already exists");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
