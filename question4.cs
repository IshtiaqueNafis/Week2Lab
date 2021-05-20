using System;
using System.Windows.Forms;

namespace Week2Lab
{
    public partial class question4 : Form
    {  
        public question4()
        {
            InitializeComponent();
        }

        #region question 4
/*
 * 4.	(Text Qs. 6) Create a Windows application that contains two textboxes and three buttons. One of the textboxes and one of the buttons are initially invisible. The first textbox should be used to input a password. The textbox should be masked to some character of your choosing so that the characters entered by the user are not seen on the screen. When the user clicks the first button, the second textbox and button should be displayed with a prompt asking the user to re-enter his or her password. Set the focus to the second password textbox. Now, when the user clicks the second button, have the application compare the values entered to make sure that they are the same. Display an appropriate message indicating whether they are the same. Once the check is made, display a third button that resets the form
 */
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text == textBox2.Text ? "corect password" : "wrong pass";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            label1.Text = string.Empty;
        }
        #endregion
    }
}