using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MenuScreen
{
    public partial class MenuScreenForm : Form
    {
        public MenuScreenForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MenuScreenForm_Load(object sender, EventArgs e)
        {
            GreetingLabel.Text = String.Concat(GreetingLabel.Text, UserMenuScreen.username + "!");

            MenuScreenHelpers.PlayBackgroundMusic();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
