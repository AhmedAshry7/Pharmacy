using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DBapplication
{
    public partial class StartForm : Form
    {
        Controller controllerobj;
       
        public StartForm()
        {
            InitializeComponent();
            controllerobj = new Controller();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            controllerobj.expiryDiscounts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            string ID = textBox1.Text;
            textBox2.Clear();
            
            string ret = controllerobj.Login(ID,password);

            if (ret == "")
            {
                label3.Visible = true;
            }
            else
            {
                
                MessageBox.Show("Login Succesful! Redirecting....");
                Thread.Sleep(500);
                if (ret == "Manager   ")
                {
                    if(controllerobj.GetBranchID(ID) == 0)
                    {
                        MessageBox.Show("Branch Deleted Please Refer To your supervisor to assign you a new Branch!");
                        return;
                    }
                    Manager m = new Manager(this,ID);
                    m.Show();
                    this.Hide();
                }
                else if (ret == "TopManager")
                {
                    TopManager tm = new TopManager(this,ID);
                    tm.Show();
                    this.Hide();
                }
                else
                {
                    if (controllerobj.GetBranchID(ID) == 0)
                    {
                        MessageBox.Show("Branch Deleted Please Refer To your supervisor to assign you a new Branch!");
                        return;
                    }
                    Employee em = new Employee(this,ID);
                    em.Show();
                    this.Hide();
                }
            }

            
        }

    }
}
