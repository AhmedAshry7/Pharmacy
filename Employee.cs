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
    public partial class Employee : Form
    {
        StartForm SF;
        string ID;
        int BranchID;
        Controller controllerobj;
        public Employee(StartForm sf, string iD)
        {
            InitializeComponent();
            SF = sf;
            ID = iD;
            controllerobj = new Controller();
            BranchID = controllerobj.GetBranchID(ID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SF.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PlaceOrder f = new PlaceOrder(int.Parse(ID), BranchID);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindProduct f = new FindProduct();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddCustomer f = new AddCustomer();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddComplaintOrReview f = new AddComplaintOrReview();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(ID);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddSubscription f = new AddSubscription();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Manage_Subscriptions f = new Manage_Subscriptions();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TodaySubscription f = new TodaySubscription(int.Parse(ID),BranchID);
            f.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ViewInBody f = new ViewInBody();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddInBody f = new AddInBody();
            f.Show();
        }
    }
}
