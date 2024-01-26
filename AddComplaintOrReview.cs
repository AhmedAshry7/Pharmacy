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
    public partial class AddComplaintOrReview : Form
    {
        Controller controllerObj;
        public AddComplaintOrReview()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReviewIDBox.Text == "" || DescriptionTextBox.Text == "" || RatingTextBox.Text == "" || CustomerIDTextBox.Text == "" || BranchIDTextBox.Text == "")
            {
                MessageBox.Show("Please enter all the information");
                return;
            }

            int reviewID, customerID, branchID;
            float rating;
            try { reviewID = int.Parse(ReviewIDBox.Text); }
            catch { MessageBox.Show("Enter a Valid Review ID"); return; }

            try { rating = float.Parse(RatingTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid Rating"); return; }
            if(rating > 5 || rating < 1) { MessageBox.Show("Enter a rating between 1 and 5"); }

            try { customerID = int.Parse(CustomerIDTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid Customer ID"); return; }

            try { branchID = int.Parse(BranchIDTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid Branch ID"); return; }

            int check = controllerObj.addReview(reviewID, DescriptionTextBox.Text, rating, customerID, branchID);
            

            if (check == 0) { MessageBox.Show("Review not added. Make sure all the data entered were valid."); }
            else {
                MessageBox.Show("Review Added Successfully");
                ReviewIDBox.Text = "";
                DescriptionTextBox.Text = "";
                RatingTextBox.Text = "";
                CustomerIDTextBox.Text = "";
                BranchIDTextBox.Text = ""; 
            }
        }
    }
}
