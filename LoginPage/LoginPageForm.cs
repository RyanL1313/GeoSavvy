using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using SignUpPage;
using MenuScreen;

namespace LoginPage
{
    public partial class LoginPageForm : Form
    {
        public LoginPageForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsernameLabel.Parent = LoginPageBackground;
            PasswordLabel.Parent = LoginPageBackground;
            TitleLabel.Parent = LoginPageBackground;
            UsernameLabel.BackColor = Color.Transparent;
            PasswordLabel.BackColor = Color.Transparent;
            TitleLabel.BackColor = Color.Transparent;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool success = LoginPageHelper.CheckValidLoginInfo(UsernameTextbox.Text, LoginPageHelper.HashPassword(PasswordTextBox.Text));

            if (success)
            {
                this.Hide();
                MenuScreenForm Menu = new MenuScreenForm();
                Menu.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Incorrect username/password. Don't have an account? Choose the sign up option.");
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Go to the signup page form
            this.Hide();
            SignUpPageForm Signup = new SignUpPageForm();
            Signup.ShowDialog();
            this.Close();
        }
    }
}
