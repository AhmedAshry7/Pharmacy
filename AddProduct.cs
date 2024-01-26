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
    public partial class AddProduct : Form
    {
        Controller controller = new Controller();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool t1 = true;
            bool t2 = true;
            bool t3 = true;
            if (!int.TryParse(textBox1.Text, out _) || string.IsNullOrWhiteSpace(textBox1.Text) || Convert.ToInt32(textBox1.Text) < 0)
            {
                label6.Show();
                t1 = false;
            }
            else
                label6.Hide();
            if (!float.TryParse(textBox3.Text, out _) || string.IsNullOrWhiteSpace(textBox3.Text) || Convert.ToInt32(textBox3.Text) <= 0)
            {
                label7.Show();
                t2 = false;
            }
            else
                label7.Hide();
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                label9.Show();
                t3 = false;
            }
            else
                label9.Hide();
            if (t1 && t2 && t3)
            {
                int x;
                if (checkBox1.Checked)
                    x = controller.AddProduct(textBox1.Text, textBox2.Text, textBox3.Text, "1", comboBox1.SelectedValue.ToString());
                else
                    x = controller.AddProduct(textBox1.Text, textBox2.Text, textBox3.Text, "0", comboBox1.SelectedValue.ToString());
                if(x == 1)
                    MessageBox.Show("Product Added Successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if(x == 0)
                    MessageBox.Show("Product already exists", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Product ID already in use", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controller.GetSup();
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "SupplierID";
            label6.Hide();
            label7.Hide();
            label9.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
