using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataLoggerAppV1
{
    public partial class LoginPage : Form
    {
        public static LoginPage instance;
        public LoginPage()
        {
            InitializeComponent();
            instance = this;
            // Set to no text.
            txtPassWord.Text = "";
            // The password character is an asterisk.
            txtPassWord.PasswordChar = '*';
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPassWord.Text == "admin")
            {
                MainForm.instance.UserNameLabelel.Text = txtUser.Text.ToUpper();
                MainForm.IsLogIn = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or Password you entered is incorrect, please try again", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassWord.Clear();
                txtUser.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.instance.UserNameLabelel.Text = "User Name";
            MainForm.IsLogIn = false;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtPassWord.Clear();
            txtUser.Clear();
            txtUser.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
             this.Hide();
        }
    }
}
