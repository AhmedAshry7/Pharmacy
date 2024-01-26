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
    public partial class TodaySubscription : Form
    {
        Controller controllerObj;
        public int emid { get; set; }
        public int brid { get; set; }
        public TodaySubscription(int employeeid, int branchid)
        {
            InitializeComponent();
            controllerObj = new Controller();
            emid = employeeid;
            brid = branchid;
        }

        private void TodaySubscription_Load(object sender, EventArgs e)
        {
            label3.Hide();
            comboBox1.DataSource=controllerObj.getSubscriptionID();
            comboBox1.DisplayMember="SubscriptionID";
            comboBox1.ValueMember = "SubscriptionID";
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
                    MessageBox.Show("The OrderID has to be a number");
                    c = false;
                }
                else
                {
                    if (x < 0)
                    {
                        MessageBox.Show("The OrderID has to be positive");
                        c = false;
                    }
                }
            }
            if (c)
            {
                int subscriptionid= Convert.ToInt32(comboBox1.SelectedValue);
                int cusid = (int)controllerObj.getcusinsubs(subscriptionid);
                int f = controllerObj.addorder(x, emid,cusid );
                if (f != 0)
                {
                    PlaceProductinSubs p = new PlaceProductinSubs();
                    p.subscriptionid = subscriptionid;
                    p.orderid = Convert.ToInt32(x);
                    p.customerid = cusid;
                    p.Show();
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
