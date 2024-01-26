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
    public partial class UPDATEMANAGER : Form
    {
        Controller controllerObj;
        public UPDATEMANAGER()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void UPDATEMANAGER_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controllerObj.getemployeeID();
            comboBox1.DisplayMember = "EmployeeId";
            comboBox1.ValueMember = "EmployeeId";
            comboBox2.DataSource = controllerObj.getbranchID();
            comboBox2.DisplayMember = "BranchID";
            comboBox2.ValueMember = "BranchID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f=controllerObj.updatemanager(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
            if (f == 1)
            {
                MessageBox.Show("Done");
            }
        }
    }
}
