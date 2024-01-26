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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class AddSup : Form
    {
        Controller controller = new Controller();
        public AddSup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                label3.Show();
                t2 = false;
            }
            else
                label3.Hide();
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
                x = controller.AddSup(textBox1.Text, textBox2.Text, textBox3.Text);
                if (x == 1)
                    MessageBox.Show("Supplier Added Successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (x == 0)
                    MessageBox.Show("Supplier already exists", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Supplier ID already in use", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddSup_Load(object sender, EventArgs e)
        {
            label6.Hide();
            label9.Hide();
            label3.Hide();
        }
    }
}
