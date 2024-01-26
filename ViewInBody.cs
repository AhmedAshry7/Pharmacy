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
    public partial class ViewInBody : Form
    {
        Controller controller = new Controller();
        public ViewInBody()
        {
            InitializeComponent();

        }

        private void ViewInBody_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controller.GetCustomers();
            comboBox1.DisplayMember = "CustomerID";
            comboBox1.ValueMember = "CustomerID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controller.ViewInBody(comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
