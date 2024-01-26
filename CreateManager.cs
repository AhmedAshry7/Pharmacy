using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DBapplication
{
    public partial class CreateManager : Form
    {
        Controller controllerObj;
        public CreateManager()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string Name = textBox2.Text;
            string salary = textBox3.Text;
            string phoneNumber = textBox5.Text;
            string Address = textBox6.Text;
            string Password = textBox7.Text;
            Name = Name.Trim();
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label16.Visible = false;
            label14.Visible = false;



            if (!int.TryParse(ID, out int id) || id < 0)
            {
                label9.Visible = true;
                return;
            }
            if((Name.Any(x => x != ' ' && !char.IsLetter(x))))
            {   
                label10.Visible = true;
                return;
            }
            if (!int.TryParse(salary, out int s) || s < 0)
            {
                label11.Visible = true;
                return;
            }
            if(!ulong.TryParse(phoneNumber, out ulong n) || n < 0)
            {
                label12.Visible = true;
                return;
            }
            if (phoneNumber.Length != 11)
            {
                label16.Visible = true;
                return;
            }
            if(Password.Length <8 || Password.Length > 10)
            {
                label14.Visible = true;
                return;
            }


            int ret =controllerObj.insertmanager(id, Name, float.Parse(salary), "TopManager", phoneNumber, Address, Password,0);
            if (ret == 1)
                MessageBox.Show("Success!");
            else
            {
                MessageBox.Show("ID already Exists!");
            }


            






        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
