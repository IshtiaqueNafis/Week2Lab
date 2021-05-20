using System;
using System.Drawing;
using System.Security.AccessControl;
using System.Windows.Forms;
using static System.Convert;

namespace Week2Lab
{
    public partial class Question_2 : Form
    {
        public Question_2()
        {
            InitializeComponent();
        }

        #region Question2 

        /*
         * 2.	(Text Qs.5) Create a Trip Calculator Windows application that can be used to determine miles per gallon for a
         * given trip. Set the Form object properties of Name, ForeColor, BackColor, Size, Location, Text, and AcceptButton.
         * The form should contain labels and textboxes to allow the user to input trip destination, miles traveled, and gallons of
         * gas consumed. Right justify the number entries. Left justify the destination entry. Two buttons should be placed on the form.
         * Center the text on the button objects. Name all objects used in program statements. When the user clicks the button that performs the calculations,
         * display on a label the miles per gallon for that trip. The second button should be used to reset or clear all textbox entries. 
         */

        #endregion

        #region question 2 soloution
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                lbOutput.ForeColor = Color.Azure;
                lbOutput.Text = textBox1.Text + (ToDouble(textBox2.Text) * ToDouble(textBox3.Text));
            }
            catch (Exception exception)
            {
                lbOutput.ForeColor = Color.Red;
                lbOutput.Text = "wrong input";

            }
        }
        #endregion

        #region question3 

        /*
         * 3.	For the above Trip Calculator Windows application, create another application with similar functionality using a TripCalculator class. Attributes/data members should be destination, miles travelled, gallons consumed and miles per gallon. It should contain a default constructor as well as an overloaded constructor. Get and Set properties should be provided for all data members. It should also include a method to calculate the miles per gallon and a  toString() method.
Using a form similar to the one created in Question 2 above, run the application using a TripCalculator instance.

         */

        private void btnClass_Click(object sender, EventArgs e)
        {
            try
            {
                var TripCalc = new TripCalculator
                {
                    Name = textBox1.Text,
                    GasMile = ToDouble(textBox2.Text),
                    GasPrice = ToDouble(textBox3.Text)
                };
                lbOutput.ForeColor = Color.Lime;
                lbOutput.Text = TripCalc.ToString();
            }
            catch (Exception exception)
            {
                lbOutput.ForeColor = Color.Red;
                lbOutput.Text = " your input is wrong";

            }
          
        }
        #endregion
    }
}
