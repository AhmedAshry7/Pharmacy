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
    public partial class FindProduct : Form
    {
        Controller controllerObj;
        public FindProduct()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ProductIDTextBox.Text == "")
            {
                MessageBox.Show("Please enter the ID of the product you want to find");
                return;
            }
            int productID;
            try { productID = int.Parse(ProductIDTextBox.Text); }
            catch { MessageBox.Show("You must enter a number"); return; }

            DataTable dt = controllerObj.findproduct(productID);
            dataGridView1.DataSource = dt;
        }
    }
}
