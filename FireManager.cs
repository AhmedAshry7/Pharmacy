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
    public partial class FireManager : Form
    {
        Controller controllerObj;
        public FireManager()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void FireManager_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controllerObj.getmanagers();
            comboBox1.DisplayMember = "EmployeeId";
            comboBox1.ValueMember = "EmployeeId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = controllerObj.deletemanager(Convert.ToInt32(comboBox1.SelectedValue));
            if (f == 1)
                MessageBox.Show("Done");
            comboBox1.DataSource = controllerObj.getmanagers();
            comboBox1.DisplayMember = "EmployeeId";
            comboBox1.ValueMember = "EmployeeId";
        }
    }
}
