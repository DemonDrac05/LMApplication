using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Paint(object sender, PaintEventArgs e) {
            Button btn = (Button)sender;
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = btn.ClientRectangle;
            int cornerRadius = 90; // Adjust the corner radius to your preference
            buttonPath.AddArc(newRectangle.X, newRectangle.Y, cornerRadius, cornerRadius, 180, 90);
            buttonPath.AddArc(newRectangle.Right - cornerRadius, newRectangle.Y, cornerRadius, cornerRadius, 270, 90);
            buttonPath.AddArc(newRectangle.Right - cornerRadius, newRectangle.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            buttonPath.AddArc(newRectangle.X, newRectangle.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            buttonPath.CloseFigure();
            btn.Region = new System.Drawing.Region(buttonPath);
        }

        private void accBox_GotFocus(object sender, EventArgs e)
        {
            if (accBox.Text == "Account")
            {
                accBox.Text = "";
            }
        }

        private void accBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(accBox.Text))
            {
                accBox.Text = "Account";
            }
        }

        private void pswBox_GotFocus(object sender, EventArgs e)
        {
            if (pswBox.Text == "Password") 
            {
                pswBox.Text = "";
                pswBox.PasswordChar = '*';
            }
        }

        private void pswBox_LostFocus(object s, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pswBox.Text)) 
            {
                pswBox.Text = "Password";
            }
        }


        private void logInButton_Click(object sender, EventArgs e)
        {
            InterfaceForm interfaceForm = new InterfaceForm();

            interfaceForm.Show();

            this.Hide();
        }   

        private void eyePictureBox_Click(object sender, EventArgs e)
        {
            if (pswBox.PasswordChar == '*')
            {
                pswBox.PasswordChar = '\0';
                eyePictureBox.Image = Properties.Resources.view;
            }
            else
            {
                pswBox.PasswordChar = '*';
                eyePictureBox.Image = Properties.Resources.hide;
            }
        }
    }
}
