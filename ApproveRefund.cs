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
    public partial class ApproveRefund : Form
    {
        Controller controllerObj;
        public int emid { get; set; }
        public int brid { get; set; }
        public ApproveRefund(int employeeid, int branchid)
        {
            InitializeComponent();
            controllerObj = new Controller();
            emid = employeeid;
            brid = branchid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(OrderIDTextBox.Text == "" || DescriptionTextBox.Text == "" )
            {
                MessageBox.Show("Please enter all the information");
                return;
            }
            int orderID;
            try { orderID = int.Parse(OrderIDTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid Order ID"); return; }


            int check = controllerObj.approveRefund(orderID, DescriptionTextBox.Text, emid);
            if (check == 0) { MessageBox.Show("Refund not approved. Make sure all the data entered were valid."); }
            else
            {
                MessageBox.Show("Refund Approved Successfully");
                OrderIDTextBox.Text = "";
                DescriptionTextBox.Text = "";
            }
        }

        private void ApproveRefund_Load(object sender, EventArgs e)
        {

        }
    }
}
