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
using StatsPage;

namespace MenuScreen
{
    public partial class MenuScreenForm : Form
    {
        public MenuScreenForm()
        {
            InitializeComponent();
        }

        private void MenuScreenForm_Load(object sender, EventArgs e)
        {
            MenuAttributes.muted = false;
            GreetingLabel.Text = String.Concat(GreetingLabel.Text, UserMenuScreen.username + "!");
            QuizAttributes.userID = MenuScreenHelpers.GetUserID();

            MenuScreenHelpers.PlayBackgroundMusic();

        }

        private void MenuScreenForm_VisibleChanged(object sender, EventArgs e)
        {
            MenuAttributes.muted = false;

            if (this.Visible)
                MenuScreenHelpers.PlayBackgroundMusic();
            else
                MenuScreenHelpers.StopBackgroundMusic();
        }

        private void MakeAllGameButtonsInvisible()
        {
            USCapitalsButton.Visible = false;
            USStatesButton.Visible = false;
            USFlagsButton.Visible = false;
            SACapitalsButton.Visible = false;
            SACountriesButton.Visible = false;
            SAFlagsButton.Visible = false;
            NACapitalsButton.Visible = false;
            NACountriesButton.Visible = false;
            NAFlagsButton.Visible = false;
            EuropeanCapitalsButton.Visible = false;
            EuropeanCountriesButton.Visible = false;
            EuropeFlagsButton.Visible = false;
            AfricanCapitalsButton.Visible = false;
            AfricanCountriesButton.Visible = false;
            AfricanFlagsButton.Visible = false;
            OceanicCapitalsButton.Visible = false;
            OceanicCountriesButton.Visible = false;
            OceanicFlagsButton.Visible = false;
            AsianCapitalsButton.Visible = false;
            AsianCountriesButton.Visible = false;
            AsianFlagsButton.Visible = false;
        }
        private void USAButton_Click(object sender, EventArgs e)
        {
            MakeAllGameButtonsInvisible();
            USCapitalsButton.Visible = true;
            USStatesButton.Visible = true;
            USFlagsButton.Visible = true;
        }

        private void SouthAmericaButton_Click(object sender, EventArgs e)
        {
            MakeAllGameButtonsInvisible();
            SACapitalsButton.Visible = true;
            SACountriesButton.Visible = true;
            SAFlagsButton.Visible = true;
        }

        private void NorthAmericaButton_Click(object sender, EventArgs e)
        {
            MakeAllGameButtonsInvisible();
            NACapitalsButton.Visible = true;
            NACountriesButton.Visible = true;
            NAFlagsButton.Visible = true;
        }

        private void EuropeButton_Click(object sender, EventArgs e)
        {
            MakeAllGameButtonsInvisible();
            EuropeanCapitalsButton.Visible = true;
            EuropeanCountriesButton.Visible = true;
            EuropeFlagsButton.Visible = true;
        }

        private void AfricaButton_Click(object sender, EventArgs e)
        {
            MakeAllGameButtonsInvisible();
            AfricanCapitalsButton.Visible = true;
            AfricanCountriesButton.Visible = true;
            AfricanFlagsButton.Visible = true;
        }

        private void OceaniaButton_Click(object sender, EventArgs e)
        {
            MakeAllGameButtonsInvisible();
            OceanicCapitalsButton.Visible = true;
            OceanicCountriesButton.Visible = true;
            OceanicFlagsButton.Visible = true;
        }

        private void AsiaButton_Click(object sender, EventArgs e)
        {
            MakeAllGameButtonsInvisible();
            AsianCapitalsButton.Visible = true;
            AsianCountriesButton.Visible = true;
            AsianFlagsButton.Visible = true;
        }

        private void OpenQuiz()
        {
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

        private void StatsPageButton_Click(object sender, EventArgs e)
        {
            StatsPageForm.userID = QuizAttributes.userID; // To view stats for this user

            this.Hide();
            StatsPageForm stats = new StatsPageForm();
            stats.ShowDialog();
            this.Show(); // When the stats form is closed out
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            if (MenuAttributes.muted)
            {
                MenuScreenHelpers.PlayBackgroundMusic();
                MenuAttributes.muted = false;
            }
            else
            {
                MenuScreenHelpers.StopBackgroundMusic();
                MenuAttributes.muted = true;
            }
        }

        private void USFlagsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "USA";
            QuizAttributes.dataTable = "USA.Flags";

            OpenQuiz();
        }

        private void NAFlagsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "North America";
            QuizAttributes.dataTable = "NorthAmerica.Flags";

            OpenQuiz();
        }

        private void SAFlagsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "South America";
            QuizAttributes.dataTable = "SouthAmerica.Flags";

            OpenQuiz();
        }

        private void EuropeFlagsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Europe";
            QuizAttributes.dataTable = "Europe.Flags";

            OpenQuiz();
        }

        private void AfricanFlagsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Africa";
            QuizAttributes.dataTable = "Africa.Flags";

            OpenQuiz();
        }

        private void AsianFlagsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Asia";
            QuizAttributes.dataTable = "Asia.Flags";

            OpenQuiz();
        }

        private void OceanicFlagsButton_Click(object sender, EventArgs e)
        {
            QuizAttributes.region = "Oceania";
            QuizAttributes.dataTable = "Oceania.Flags";

            OpenQuiz();
        }
    }

    public class MenuAttributes
    {
        public static bool muted = false;
    }
}
