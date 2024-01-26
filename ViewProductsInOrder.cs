using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DBapplication
{
    
    public partial class ViewProductsInOrder : Form
    {
        Controller controllerObj;
        public int orderid { get; set; }
        public ViewProductsInOrder()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void ViewProductsInOrder_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getproductsinorder(orderid);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
