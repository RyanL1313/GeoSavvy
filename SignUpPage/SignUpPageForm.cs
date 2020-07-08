using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MenuScreen;

namespace SignUpPage
{
    public partial class SignUpPageForm : Form
    {
        public SignUpPageForm()
        {
            InitializeComponent();
        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void SignUpPageForm_Load(object sender, EventArgs e)
        {
            SignupLabel.Parent = SignupPageBackground;
            UsernameLabel.Parent = SignupPageBackground;
            PasswordLabel.Parent = SignupPageBackground;
            EmailLabel.Parent = SignupPageBackground;
            SignupLabel.BackColor = Color.Transparent;
            UsernameLabel.BackColor = Color.Transparent;
            PasswordLabel.BackColor = Color.Transparent;
            EmailLabel.BackColor = Color.Transparent;
        }

        private void SignupLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            bool userInfoValid = SignUpPageHelper.ValidUserInformation(UsernameTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text);

            if (userInfoValid)
            {
                SignUpPageHelper.StoreUserInfo(UsernameTextBox.Text, SignUpPageHelper.HashPassword(PasswordTextBox.Text), EmailTextBox.Text);

                this.Hide();
                MenuScreenForm Menu = new MenuScreenForm();
                UserMenuScreen.username = UsernameTextBox.Text;
                Menu.ShowDialog();
                this.Close();
            }
        }
    }
}
