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

        private void SignupButton_Click(object sender, EventArgs e)
        {
            bool userInfoValid = SignUpPageHelper.ValidUserInformation(UsernameTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text);

            if (userInfoValid)
            {
                SignUpPageHelper.StoreUserInfo(UsernameTextBox.Text, SignUpPageHelper.HashPassword(PasswordTextBox.Text), EmailTextBox.Text);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SignupButton_Click(sender, e);
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SignupButton_Click(sender, e);
        }

        private void EmailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SignupButton_Click(sender, e);
        }
    }
}
