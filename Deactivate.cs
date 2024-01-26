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
    public partial class Deactivate : Form
    {
        Controller controllerObj;
        public Deactivate()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Deactivate_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controllerObj.get1subs();
            comboBox1.DisplayMember = "SubscriptionID";
            comboBox1.ValueMember = "SubscriptionID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int f =controllerObj.deactivatesub(Convert.ToInt32(comboBox1.SelectedValue));
            if (f != 0)
            {
                MessageBox.Show("Deactivated");
                comboBox1.DataSource = controllerObj.get1subs();
                comboBox1.DisplayMember = "SubscriptionID";
                comboBox1.ValueMember = "SubscriptionID";
            }
        }
    }
}
