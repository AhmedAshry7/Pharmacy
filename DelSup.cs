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
    public partial class DelSup : Form
    {

        Controller controller = new Controller();
        public DelSup()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool s;
            s=controller.DelSup(comboBox1.SelectedValue.ToString());
            if(s)
            {
                MessageBox.Show("Supplier Deleted Successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.DataSource = controller.GetSup();
                comboBox1.DisplayMember = "SupplierName";
                comboBox1.ValueMember = "SupplierName";
                comboBox1.Refresh();
            }
            else
                MessageBox.Show("Supplier Not Deleted", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DelSup_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controller.GetSup();
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "SupplierName";
        }
    }
}
