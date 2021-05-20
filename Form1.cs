using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2Lab
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();


        }
        #region QuestionOne
        /*
         * question one
         * 1.	(Text Qs. 3) Create a Windows application that contains two textboxes and three buttons.
         * The textboxes should be used to allow the user to input two positive numeric values.
         * The buttons should be labeled Add and Multiply and Reset. Create event-handler methods that retrieve the values,
         * perform the calculations, and display the result of the calculations on a label. The result label should initially be
         * set to be invisible with a font color of yellow. If invalid data is entered, change the font color to red on the result label and display
         * a message saying “Value must be numeric and > 0.” When the final answer is displayed, the font color should be yellow. Additional labels will be needed
         * for the textboxes captions. Do not allow non-numeric characters to be entered. Invoke the TryParse( )
         * method to retrieve the values. All controls involved in program statements should be named. Right justify values in the textbox.
         */

        #endregion

        #region Question Two answer

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
             lbOutput.ForeColor = Color.Aqua;
             lbOutput.Text = (Convert.ToInt32(tbValue1.Text) + Convert.ToInt32(tbValue1.Text)).ToString();
             
            }
            catch (Exception exception)
            {
                lbOutput.ForeColor = Color.Red;
                lbOutput.Text = "wrong input";
            }
        }

        private bool Checkinputisint(string value) =>Convert.ToBoolean(Convert.ToInt32(value));

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                lbOutput.ForeColor = Color.Aqua;
                lbOutput.Text = (Convert.ToInt32(tbValue1.Text) * Convert.ToInt32(tbValue1.Text)).ToString();
             
            }
            catch (Exception exception)
            {
                lbOutput.ForeColor = Color.Red;
                lbOutput.Text = "wrong input";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbValue1.Text = string.Empty;
            tbValue2.Text = string.Empty;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            var question2 = new Question_2();
            question2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var question4 = new question4();
            question4.Show();
        }
    }

   
}