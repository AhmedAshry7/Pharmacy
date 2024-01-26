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
    public partial class ChangePassword : Form
    {
        string ID;

        Controller controllerobj;
        public ChangePassword(string iD)
        {
            InitializeComponent();
            ID = iD;
            controllerobj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldpass = textBox1.Text;
            string p1 = textBox2.Text;
            string p2 = textBox3.Text;
            label4.Visible = false;
            label5.Visible = false;

            if (p1.Length < 8 || p1.Length > 10 )
            {
                label5.Visible = true;
                return;
            }
            if (p1 != p2)
            {
                label4.Visible = true;
                return;
            }



            int ret =controllerobj.ChangePassword(ID,p1,oldpass);
            if (ret == 1)
            {
                MessageBox.Show("Password Changed Successfully!");
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
