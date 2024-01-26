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
    public partial class Manage_Subscriptions : Form
    {
        public Manage_Subscriptions()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Activate f = new Activate();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deactivate f = new Deactivate();
            f.Show();
        }
    }
}
