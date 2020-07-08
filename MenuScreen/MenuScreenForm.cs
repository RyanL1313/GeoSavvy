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
using QuizPage;

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
            QuizAttributes.userID = MenuScreenHelpers.GetUserID();

            MenuScreenHelpers.PlayBackgroundMusic();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void MenuScreenForm_VisibleChanged(object sender, EventArgs e)
        {
            MenuScreenHelpers.PlayBackgroundMusic();
        }

        private void USAButton_Click(object sender, EventArgs e)
        {
            USCapitalsButton.Visible = true;
            USStatesButton.Visible = true;
            SACapitalsButton.Visible = false;
            SACountriesButton.Visible = false;
            NACapitalsButton.Visible = false;
            NACountriesButton.Visible = false;
            EuropeanCapitalsButton.Visible = false;
            EuropeanCountriesButton.Visible = false;
            AfricanCapitalsButton.Visible = false;
            AfricanCountriesButton.Visible = false;
            OceanicCapitalsButton.Visible = false;
            OceanicCountriesButton.Visible = false;
            AsianCapitalsButton.Visible = false;
            AsianCountriesButton.Visible = false;
        }

        private void SouthAmericaButton_Click(object sender, EventArgs e)
        {
            USCapitalsButton.Visible = false;
            USStatesButton.Visible = false;
            SACapitalsButton.Visible = true;
            SACountriesButton.Visible = true;
            NACapitalsButton.Visible = false;
            NACountriesButton.Visible = false;
            EuropeanCapitalsButton.Visible = false;
            EuropeanCountriesButton.Visible = false;
            AfricanCapitalsButton.Visible = false;
            AfricanCountriesButton.Visible = false;
            OceanicCapitalsButton.Visible = false;
            OceanicCountriesButton.Visible = false;
            AsianCapitalsButton.Visible = false;
            AsianCountriesButton.Visible = false;
        }

        private void NorthAmericaButton_Click(object sender, EventArgs e)
        {
            USCapitalsButton.Visible = false;
            USStatesButton.Visible = false;
            SACapitalsButton.Visible = false;
            SACountriesButton.Visible = false;
            NACapitalsButton.Visible = true;
            NACountriesButton.Visible = true;
            EuropeanCapitalsButton.Visible = false;
            EuropeanCountriesButton.Visible = false;
            AfricanCapitalsButton.Visible = false;
            AfricanCountriesButton.Visible = false;
            OceanicCapitalsButton.Visible = false;
            OceanicCountriesButton.Visible = false;
            AsianCapitalsButton.Visible = false;
            AsianCountriesButton.Visible = false;
        }

        private void EuropeButton_Click(object sender, EventArgs e)
        {
            USCapitalsButton.Visible = false;
            USStatesButton.Visible = false;
            SACapitalsButton.Visible = false;
            SACountriesButton.Visible = false;
            NACapitalsButton.Visible = false;
            NACountriesButton.Visible = false;
            EuropeanCapitalsButton.Visible = true;
            EuropeanCountriesButton.Visible = true;
            AfricanCapitalsButton.Visible = false;
            AfricanCountriesButton.Visible = false;
            OceanicCapitalsButton.Visible = false;
            OceanicCountriesButton.Visible = false;
            AsianCapitalsButton.Visible = false;
            AsianCountriesButton.Visible = false;
        }

        private void AfricaButton_Click(object sender, EventArgs e)
        {
            USCapitalsButton.Visible = false;
            USStatesButton.Visible = false;
            SACapitalsButton.Visible = false;
            SACountriesButton.Visible = false;
            NACapitalsButton.Visible = false;
            NACountriesButton.Visible = false;
            EuropeanCapitalsButton.Visible = false;
            EuropeanCountriesButton.Visible = false;
            AfricanCapitalsButton.Visible = true;
            AfricanCountriesButton.Visible = true;
            OceanicCapitalsButton.Visible = false;
            OceanicCountriesButton.Visible = false;
            AsianCapitalsButton.Visible = false;
            AsianCountriesButton.Visible = false;
        }

        private void OceaniaButton_Click(object sender, EventArgs e)
        {
            USCapitalsButton.Visible = false;
            USStatesButton.Visible = false;
            SACapitalsButton.Visible = false;
            SACountriesButton.Visible = false;
            NACapitalsButton.Visible = false;
            NACountriesButton.Visible = false;
            EuropeanCapitalsButton.Visible = false;
            EuropeanCountriesButton.Visible = false;
            AfricanCapitalsButton.Visible = false;
            AfricanCountriesButton.Visible = false;
            OceanicCapitalsButton.Visible = true;
            OceanicCountriesButton.Visible = true;
            AsianCapitalsButton.Visible = false;
            AsianCountriesButton.Visible = false;
        }

        private void AsiaButton_Click(object sender, EventArgs e)
        {
            USCapitalsButton.Visible = false;
            USStatesButton.Visible = false;
            SACapitalsButton.Visible = false;
            SACountriesButton.Visible = false;
            NACapitalsButton.Visible = false;
            NACountriesButton.Visible = false;
            EuropeanCapitalsButton.Visible = false;
            EuropeanCountriesButton.Visible = false;
            AfricanCapitalsButton.Visible = false;
            AfricanCountriesButton.Visible = false;
            OceanicCapitalsButton.Visible = false;
            OceanicCountriesButton.Visible = false;
            AsianCapitalsButton.Visible = true;
            AsianCountriesButton.Visible = true;
        }

        private void OpenQuiz()
        {
            MenuScreenHelpers.StopBackgroundMusic();

            this.Hide();
            QuizPageForm Quiz = new QuizPageForm();
            Quiz.ShowDialog();
            this.Show(); // When the quiz form is closed out
        }

        private void USStatesButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "USA";
            QuizAttributes.dataTable = "USA.States";

            OpenQuiz();
        }

        private void USCapitalsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "USA";
            QuizAttributes.dataTable = "USA.Capitals";

            OpenQuiz();
        }

        private void NACountriesButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "North America";
            QuizAttributes.dataTable = "NorthAmerica.Countries";

            OpenQuiz();
        }

        private void NACapitalsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "North America";
            QuizAttributes.dataTable = "NorthAmerica.Capitals";

            OpenQuiz();
        }

        private void SACountriesButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "South America";
            QuizAttributes.dataTable = "SouthAmerica.Countries";

            OpenQuiz();
        }

        private void SACapitalsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "South America";
            QuizAttributes.dataTable = "SouthAmerica.Capitals";

            OpenQuiz();
        }

        private void EuropeanCountriesButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Europe";
            QuizAttributes.dataTable = "Europe.Countries";

            OpenQuiz();
        }

        private void EuropeanCapitalsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Europe";
            QuizAttributes.dataTable = "Europe.Capitals";

            OpenQuiz();
        }

        private void AfricanCountriesButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Africa";
            QuizAttributes.dataTable = "Africa.Countries";

            OpenQuiz();
        }

        private void AfricanCapitalsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Africa";
            QuizAttributes.dataTable = "Africa.Capitals";

            OpenQuiz();
        }

        private void AsianCountriesButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Asia";
            QuizAttributes.dataTable = "Asia.Countries";

            OpenQuiz();
        }

        private void AsianCapitalsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Asia";
            QuizAttributes.dataTable = "Asia.Capitals";

            OpenQuiz();
        }

        private void OceanicCountriesButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Oceania";
            QuizAttributes.dataTable = "Oceania.Countries";

            OpenQuiz();
        }

        private void OceanicCapitalsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Oceania";
            QuizAttributes.dataTable = "Oceania.Capitals";

            OpenQuiz();
        }
    }
}
