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
    public partial class AddInBody : Form
    {
        Controller controllerObj;
        public AddInBody()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(InbodyIDTextBox.Text == "" || WeightTextBox.Text == "" || HeightTextBox.Text == "" || AgeTextBox.Text == "" || GenderTextBox.Text == "" || MuscleMassTextBox.Text == "" || FatPercentTextBox.Text == "" || CustomerIDTextBox.Text == "")
            {
                MessageBox.Show("Please enter all the information");
                return;
            }
            int inbodyID, age, customerID;
            float weight, height, muscleMass, fatPercent;

            try { inbodyID = int.Parse(InbodyIDTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid InBody ID"); return; }

            try { weight = float.Parse(WeightTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid Weight"); return; }
            if (weight < 0) { MessageBox.Show("Enter a Valid Weight"); return; }

            try { height = float.Parse(HeightTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid Height"); return; }
            if (height < 0) { MessageBox.Show("Enter a Valid Height"); return; }

            try { age = int.Parse(AgeTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid Age"); return; }
            if(age < 0) { MessageBox.Show("Enter a Valid Age"); return; }

            try { muscleMass = float.Parse(MuscleMassTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid Muscle Mass"); return; }
            if (muscleMass < 0 || muscleMass > 80) { MessageBox.Show("Enter a Valid Muscle Mass"); return; }

            try { fatPercent = float.Parse(FatPercentTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid Fat Percentage"); return; }
            if (fatPercent < 0 || fatPercent > 80) { MessageBox.Show("Enter a Valid Fat Percentage"); return; }

            try { customerID = int.Parse(CustomerIDTextBox.Text); }
            catch { MessageBox.Show("Enter a Valid Customer ID"); return; }

            if(GenderTextBox.Text == "M" || GenderTextBox.Text == "m" || GenderTextBox.Text == "F" || GenderTextBox.Text == "f")
            {
                int check = controllerObj.addInBody(inbodyID, weight, height, age, GenderTextBox.Text, muscleMass, fatPercent, customerID); 
                if (check == 0) { MessageBox.Show("Review not added. Make sure all the data entered were valid."); }
                else
                { 
                    MessageBox.Show("InBody Data Added Successfully");
                    InbodyIDTextBox.Text = "";
                    WeightTextBox.Text = "";
                    HeightTextBox.Text = "";
                    AgeTextBox.Text = "";
                    GenderTextBox.Text = "";
                    MuscleMassTextBox.Text = "";
                    FatPercentTextBox.Text = "";
                    CustomerIDTextBox.Text = "";
                }
            }
            else { MessageBox.Show("Enter a valid gender (M or F)"); return; }
        }
    }
}
