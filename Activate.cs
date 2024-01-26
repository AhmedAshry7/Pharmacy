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
    public partial class Activate : Form
    {
        Controller controllerObj;
        public Activate()
        {
            InitializeComponent();
            
        }

        private void Activate_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            comboBox1.DataSource = controllerObj.get0subs();
            comboBox1.DisplayMember = "SubscriptionID";
            comboBox1.ValueMember = "SubscriptionID";
            //comment
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = controllerObj.activatesub(Convert.ToInt32(comboBox1.SelectedValue));
            if (f != 0)
            {
                MessageBox.Show("activated");
                comboBox1.DataSource = controllerObj.get0subs();
                comboBox1.DisplayMember = "SubscriptionID";
                comboBox1.ValueMember = "SubscriptionID";
            }
        }
    }
}
