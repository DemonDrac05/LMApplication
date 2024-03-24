using System;

namespace LibraryManagement
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.accBox = new System.Windows.Forms.TextBox();
            this.pswBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.eyePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eyePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // accBox
            // 
            this.accBox.Location = new System.Drawing.Point(536, 445);
            this.accBox.Name = "accBox";
            this.accBox.Size = new System.Drawing.Size(283, 22);
            this.accBox.TabIndex = 0;
            this.accBox.Text = "Account";
            this.accBox.GotFocus += new System.EventHandler(this.accBox_GotFocus);
            this.accBox.LostFocus += new System.EventHandler(this.accBox_LostFocus);
            // 
            // pswBox
            // 
            this.pswBox.Location = new System.Drawing.Point(536, 482);
            this.pswBox.Name = "pswBox";
            this.pswBox.Size = new System.Drawing.Size(283, 22);
            this.pswBox.TabIndex = 1;
            this.pswBox.Text = "Password";
            this.pswBox.GotFocus += new System.EventHandler(this.pswBox_GotFocus);
            this.pswBox.LostFocus += new System.EventHandler(this.pswBox_LostFocus);
            // 
            // logInButton
            // 
            this.logInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logInButton.BackColor = System.Drawing.Color.Transparent;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logInButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logInButton.Location = new System.Drawing.Point(536, 535);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(283, 40);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            this.logInButton.Paint += new System.Windows.Forms.PaintEventHandler(this.logInButton_Paint);
            // 
            // eyePictureBox
            // 
            this.eyePictureBox.Image = global::LibraryManagement.Properties.Resources.hide;
            this.eyePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("eyePictureBox.InitialImage")));
            this.eyePictureBox.Location = new System.Drawing.Point(835, 476);
            this.eyePictureBox.Name = "eyePictureBox";
            this.eyePictureBox.Size = new System.Drawing.Size(35, 37);
            this.eyePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyePictureBox.TabIndex = 3;
            this.eyePictureBox.TabStop = false;
            this.eyePictureBox.Click += new System.EventHandler(this.eyePictureBox_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.eyePictureBox);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.pswBox);
            this.Controls.Add(this.accBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.eyePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accBox;
        private System.Windows.Forms.TextBox pswBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.PictureBox eyePictureBox;
    }
}

