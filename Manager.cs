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
    public partial class Manager : Form
    {
        StartForm SF;
        string ID;
        int BranchID;
        Controller controllerObj;
        public Manager(StartForm sf, string iD)
        {
            InitializeComponent();
            controllerObj = new Controller();
            SF = sf;
            ID = iD;
            BranchID = controllerObj.GetBranchID(ID);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SF.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployee f = new AddEmployee();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FireEmployee f = new FireEmployee();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApproveRefund f = new ApproveRefund(int.Parse(ID),BranchID);
            f.Show();
        }   

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdatePrice f = new UpdatePrice();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(ID);
            f.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AddProduct f = new AddProduct();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Restock f = new Restock(BranchID);
            f.Show();
        }
    }
}
