using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsPage
{
    public partial class StatsPageForm : Form
    {
        public static string regionSelected;
        public static int userID;

        public StatsPageForm()
        {
            InitializeComponent();
        }

        private void StatsPage_Load(object sender, EventArgs e)
        {
            StatsAttributes.muted = false;
            StatsPageHelpers.PlayBackgroundMusic();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AfricaButton_Click(object sender, EventArgs e)
        {
            regionSelected = "Africa";

            ResetButtonBorderColors();
            AfricaButton.FlatAppearance.BorderColor = Color.LightSkyBlue;

            CountriesButton.Visible = true;
            CapitalsButton.Visible = true;
            StatesButton.Visible = false;
            FlagsButton.Visible = true;
        }

        private void AsiaButton_Click(object sender, EventArgs e)
        {
            regionSelected = "Asia";

            ResetButtonBorderColors();
            AsiaButton.FlatAppearance.BorderColor = Color.LightSkyBlue;

            CountriesButton.Visible = true;
            CapitalsButton.Visible = true;
            StatesButton.Visible = false;
            FlagsButton.Visible = true;
        }

        private void EuropeButton_Click(object sender, EventArgs e)
        {
            regionSelected = "Europe";

            ResetButtonBorderColors();
            EuropeButton.FlatAppearance.BorderColor = Color.LightSkyBlue;

            CountriesButton.Visible = true;
            CapitalsButton.Visible = true;
            StatesButton.Visible = false;
            FlagsButton.Visible = true;
        }

        private void NorthAmericaButton_Click(object sender, EventArgs e)
        {
            regionSelected = "NorthAmerica";

            ResetButtonBorderColors();
            NorthAmericaButton.FlatAppearance.BorderColor = Color.LightSkyBlue;

            CountriesButton.Visible = true;
            CapitalsButton.Visible = true;
            StatesButton.Visible = false;
            FlagsButton.Visible = true;
        }

        private void OceaniaButton_Click(object sender, EventArgs e)
        {
            regionSelected = "Oceania";

            ResetButtonBorderColors();
            OceaniaButton.FlatAppearance.BorderColor = Color.LightSkyBlue;

            CountriesButton.Visible = true;
            CapitalsButton.Visible = true;
            StatesButton.Visible = false;
            FlagsButton.Visible = true;
        }

        private void SouthAmericaButton_Click(object sender, EventArgs e)
        {
            regionSelected = "SouthAmerica";

            ResetButtonBorderColors();
            SouthAmericaButton.FlatAppearance.BorderColor = Color.LightSkyBlue;

            CountriesButton.Visible = true;
            CapitalsButton.Visible = true;
            StatesButton.Visible = false;
            FlagsButton.Visible = true;
        }

        private void UnitedStatesButton_Click(object sender, EventArgs e)
        {
            regionSelected = "USA";

            ResetButtonBorderColors();
            UnitedStatesButton.FlatAppearance.BorderColor = Color.LightSkyBlue;

            CountriesButton.Visible = false;
            CapitalsButton.Visible = true;
            StatesButton.Visible = true;
            FlagsButton.Visible = true;
        }

        private void ResetButtonBorderColors()
        {
            AfricaButton.FlatAppearance.BorderColor = Color.Empty;
            AsiaButton.FlatAppearance.BorderColor = Color.Empty;
            EuropeButton.FlatAppearance.BorderColor = Color.Empty;
            NorthAmericaButton.FlatAppearance.BorderColor = Color.Empty;
            SouthAmericaButton.FlatAppearance.BorderColor = Color.Empty;
            OceaniaButton.FlatAppearance.BorderColor = Color.Empty;
            UnitedStatesButton.FlatAppearance.BorderColor = Color.Empty;
        }

        private void StatesButton_Click(object sender, EventArgs e)
        {
            RemoveGameTypeFromRegionSelected();
            regionSelected = String.Concat(regionSelected, ".States");

            StatsPageHelpers.DisplayGameStats();
        }

        private void CapitalsButton_Click(object sender, EventArgs e)
        {
            RemoveGameTypeFromRegionSelected();
            regionSelected = String.Concat(regionSelected, ".Capitals");

            StatsPageHelpers.DisplayGameStats();
        }

        private void CountriesButton_Click(object sender, EventArgs e)
        {
            RemoveGameTypeFromRegionSelected();
            regionSelected = String.Concat(regionSelected, ".Countries");

            StatsPageHelpers.DisplayGameStats();
        }

        /// <summary>
        /// Removes the game type substring from regionSelected in case of the user not selecting a different region before selecting consecutive game modes.
        /// </summary>
        private void RemoveGameTypeFromRegionSelected()
        {
            regionSelected = regionSelected.Replace(".States", "");
            regionSelected = regionSelected.Replace(".Capitals", "");
            regionSelected = regionSelected.Replace(".Countries", "");
            regionSelected = regionSelected.Replace(".Flags", "");
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            if (StatsAttributes.muted)
            {
                StatsPageHelpers.PlayBackgroundMusic();
                StatsAttributes.muted = false;
            }
            else
            {
                StatsPageHelpers.StopBackgroundMusic();
                StatsAttributes.muted = true;
            }
        }

        private void FlagsButton_Click(object sender, EventArgs e)
        {
            RemoveGameTypeFromRegionSelected();
            regionSelected = String.Concat(regionSelected, ".Flags");

            StatsPageHelpers.DisplayGameStats();
        }
    }

    public class StatsAttributes
    {
        public static bool muted = false;
    }
}
