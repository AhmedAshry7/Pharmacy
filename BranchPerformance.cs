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
    public partial class BranchPerformance : Form
    {
        Controller controllerObj;
        public BranchPerformance()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.branchPerformance();
            dataGridView1.DataSource = dt;
        }

        private void BranchPerformance_Load(object sender, EventArgs e)
        {
            
        }
    }
}
