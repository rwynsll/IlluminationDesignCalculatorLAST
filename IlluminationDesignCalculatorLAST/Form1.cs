using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlluminationDesignCalculatorLAST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbTypeBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTypeBuilding.SelectedIndex == 0)
            {
                cbLightingSystem0.Visible = true;
                cbLightingSystem1.Visible = false;
                cbLightingSystem2.Visible = false;
                cbLightingSystem3.Visible = false;
                //groupbox2
                cbIlluminationResidential.Visible = true;
                cbIlluminationCommercial.Visible = false;
                cbIlluminationIndustrial.Visible = false;
                cbIlluminationAny.Visible = false;
            }
            if (cbTypeBuilding.SelectedIndex == 1)
            {
                cbLightingSystem0.Visible = false;
                cbLightingSystem1.Visible = true;
                cbLightingSystem2.Visible = false;
                cbLightingSystem3.Visible = false;
                //groupbox2
                cbIlluminationResidential.Visible = false;
                cbIlluminationCommercial.Visible = true;
                cbIlluminationIndustrial.Visible = false;
                cbLightingSystem3.Visible = false;
                cbIlluminationAny.Visible = false;
            }
            if (cbTypeBuilding.SelectedIndex == 2)
            {
                cbLightingSystem0.Visible = false;
                cbLightingSystem1.Visible = false;
                cbLightingSystem2.Visible = true;
                cbLightingSystem3.Visible = false;
                //groupbox2
                cbIlluminationResidential.Visible = false;
                cbIlluminationCommercial.Visible = false;
                cbIlluminationIndustrial.Visible = true;
                cbIlluminationAny.Visible = false;
            }
            if (cbTypeBuilding.SelectedIndex == 3)
            {

                cbLightingSystem0.Visible = false;
                cbLightingSystem1.Visible = false;
                cbLightingSystem2.Visible = false;
                cbLightingSystem3.Visible = true;
                //groupbox2
                cbIlluminationResidential.Visible = false;
                cbIlluminationCommercial.Visible = false;
                cbIlluminationIndustrial.Visible = false;
                cbIlluminationAny.Visible = true;
            }
        }

        //tabbing    

        //Area
        #region Area
        private void rdbArea_Click(object sender, EventArgs e)
        {
            nudLength.ReadOnly = true;
            nudWidth.ReadOnly = true;
            nudArea.ReadOnly = false;
        }

        private void rdbLenghtWidth_Click(object sender, EventArgs e)
        {
            nudLength.ReadOnly = false;
            nudWidth.ReadOnly = false;
            nudArea.ReadOnly = true;
            nudArea.Value = nudLength.Value * nudWidth.Value;
        }

        private void nudLength_ValueChanged(object sender, EventArgs e)
        {
            nudArea.Value = nudLength.Value * nudWidth.Value;
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            nudArea.Value = nudLength.Value * nudWidth.Value;
        }
        #endregion


        //Illumination
        #region illumination
        private void illuminationResidential()
        {
            int[] fcResidential = new int[] { 5, 5, 5, 10, 40, 5, 5, 40, 40, 40 };
            if (rbUnitMetric.Checked == true)
            {
                nudIllumination.Value = fcResidential[cbIlluminationResidential.SelectedIndex] * ftm;
            }
            else
            {
                nudIllumination.Value = fcResidential[cbIlluminationResidential.SelectedIndex];
            }
        }
        private void illuminationCommercial()
        {
            int[] fcCommercial = new int[] { 50, 50, 50, 50, 50, 50, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 50, 20, 20, 10, 10, 10, 10, 10, 5, 5 };
            if (rbUnitMetric.Checked == true)
            {
                nudIllumination.Value = fcCommercial[cbIlluminationCommercial.SelectedIndex] * ftm;
            }
            else
            {
                nudIllumination.Value = fcCommercial[cbIlluminationCommercial.SelectedIndex];
            }
        }
        private void illuminationIndustrial()
        {
            int[] fcIndustrial = new int[] { 10, 10, 50, 20, 20, 50, 20, 10, 20, 30, 20, 10, 10, 30, 150 };
            if (rbUnitMetric.Checked == true)
            {
                nudIllumination.Value = fcIndustrial[cbIlluminationIndustrial.SelectedIndex] * ftm;
            }
            else
            {
                nudIllumination.Value = fcIndustrial[cbIlluminationIndustrial.SelectedIndex];
            }
        }
        private void illuminationAny()
        {
            int[] fcAny = new int[] { 5, 5, 5, 10, 40, 5, 5, 40, 40, 40, 50, 50, 50, 50, 50, 50, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 50, 20, 20, 10, 10, 10, 10, 10, 5, 5, 10, 10, 50, 20, 20, 50, 20, 10, 20, 30, 20, 10, 10, 30, 150 };
            if (rbUnitMetric.Checked == true)
            {
                nudIllumination.Value = fcAny[cbIlluminationAny.SelectedIndex] * ftm;
            }
            else
            {
                nudIllumination.Value = fcAny[cbIlluminationAny.SelectedIndex];
            }
        }
        private void cbIlluminationResidential_SelectedIndexChanged(object sender, EventArgs e)
        {
            illuminationResidential();

        }
        private void cbIlluminationCommercial_SelectedIndexChanged(object sender, EventArgs e)
        {
            illuminationCommercial();
        }

        private void cbIlluminationIndustrial_SelectedIndexChanged(object sender, EventArgs e)
        {
            illuminationIndustrial();
        }
        private void cbIlluminationAny_SelectedIndexChanged(object sender, EventArgs e)
        {
            illuminationAny();
        }
        #endregion


        //unit system 
        #region units
        decimal mft = 0.092903M;
        decimal ftm = 10.7639M;
        private void rbUnitEnglish_Click(object sender, EventArgs e)
        {
            nudIllumination.Value = (decimal)nudIllumination.Value * mft;
            lbA1.Text = "ft^2";
            lbA2.Text = "feet";
            lbA3.Text = "feet";
            lbA4.Text = "feet";
            lbI3.Text = "fc";
        }

        private void rbUnitMetric_Click(object sender, EventArgs e)
        {
            nudIllumination.Value = (decimal)nudIllumination.Value * ftm;
            lbA1.Text = "m^2";
            lbA2.Text = "meters";
            lbA3.Text = "meters";
            lbA4.Text = "meters";
            lbI3.Text = "lux";
        }
        #endregion

        //output
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var area = nudArea.Value;
            var illumination = nudIllumination.Value;
            double cu = 1;
            var llf = 1;
            var lumens = nudLampLumens.Value;
            var lamp = nudLampFixture.Value;
            double top = (double)area * (double)illumination;
            double bottom = (double)lamp * (double)lumens * (double)cu * (double)llf;

            double results = top / bottom;
            results = indexes;
            tbLuminaires.Text = results.ToString("#.##");
        }

        //cu
        int reflectance = 0; // header column (placeholder)
        double indexes = 0;
        private void reflectances()
        {
            if (cbCeiling.SelectedIndex == 0 && cbWall.SelectedIndex == 0)
            {
                reflectance = 0;
            }
            if (cbCeiling.SelectedIndex == 0 && cbWall.SelectedIndex == 1)
            {
                reflectance = 1;
            }
            if (cbCeiling.SelectedIndex == 0 && cbWall.SelectedIndex == 2)
            {
                reflectance = 2;
            }
            if (cbCeiling.SelectedIndex == 1 && cbWall.SelectedIndex == 0)
            {
                reflectance = 3;
            }
            if (cbCeiling.SelectedIndex == 1 && cbWall.SelectedIndex == 1)
            {
                reflectance = 4;
            }
            if (cbCeiling.SelectedIndex == 1 && cbWall.SelectedIndex == 2)
            {
                reflectance = 5;
            }
            if (cbCeiling.SelectedIndex == 2 && cbWall.SelectedIndex == 0)
            {
                reflectance = 6;
            }
            if (cbCeiling.SelectedIndex == 2 && cbWall.SelectedIndex == 1)
            {
                reflectance = 7;
            }
            if (cbCeiling.SelectedIndex == 2 && cbWall.SelectedIndex == 2)
            {
                reflectance = 8;
            }
        }
        //test
        private void index()
        {
            double top = 2 * (double)nudWidth.Value;
            top = top + (double)nudLength.Value;
            double bottom = 6 * (double)nudHeight.Value;
            bottom = bottom - 2.5;
            indexes = top / bottom;
        }
        private void cU()
        {
            reflectances();
            #region cu arrays
            //direct rlm dome reflector
            int[] cuDirectReflectorJ = new int[] { 37, 31, 27, 36, 31, 27, 31, 27 };
            int[] cuDirectReflectorI = new int[] { 45, 41, 38, 45, 40, 37, 40, 37 };
            int[] cuDirectReflectorH = new int[] { 49, 45, 42, 49, 45, 42, 45, 42 };
            int[] cuDirectReflectorG = new int[] { 53, 49, 46, 53, 49, 46, 48, 46 };
            int[] cuDirectReflectorF = new int[] { 56, 53, 49, 55, 52, 49, 51, 49 };
            int[] cuDirectReflectorE = new int[] { 61, 58, 55, 60, 57, 55, 56, 55 };
            int[] cuDirectReflectorD = new int[] { 66, 63, 60, 64, 62, 60, 61, 60 };
            int[] cuDirectReflectorC = new int[] { 67, 65, 62, 66, 64, 62, 63, 61 };
            int[] cuDirectReflectorB = new int[] { 71, 68, 66, 69, 67, 65, 66, 64 };
            int[] cuDirectReflectorA = new int[] { 72, 70, 67, 71, 68, 67, 67, 66 };
            //direct rlm deepbowl reflector
            int[] cuDirectDeepReflectorJ = new int[] { 35, 31, 28, 34, 31, 28, 30, 28 };
            int[] cuDirectDeepReflectorI = new int[] { 43, 39, 37, 42, 39, 37, 39, 37 };
            int[] cuDirectDeepReflectorH = new int[] { 46, 44, 42, 46, 44, 42, 43, 42 };
            int[] cuDirectDeepReflectorG = new int[] { 50, 47, 45, 49, 47, 45, 46, 45 };
            int[] cuDirectDeepReflectorF = new int[] { 53, 50, 47, 51, 49, 47, 49, 47 };
            int[] cuDirectDeepReflectorE = new int[] { 56, 54, 51, 56, 54, 51, 53, 51 };
            int[] cuDirectDeepReflectorD = new int[] { 61, 58, 56, 59, 57, 56, 56, 56 };
            int[] cuDirectDeepReflectorC = new int[] { 62, 60, 57, 61, 58, 57, 58, 56 };
            int[] cuDirectDeepReflectorB = new int[] { 64, 62, 61, 63, 61, 60, 60, 59 };
            int[] cuDirectDeepReflectorA = new int[] { 65, 63, 61, 64, 66, 61, 61, 60 };
            //direct aluminum highbay spacing 0.6
            int[] cuDirectAluminumHighBay1J = new int[] { 43, 40, 39, 42, 40, 39, 40, 38 };
            int[] cuDirectAluminumHighBay1I = new int[] { 51, 50, 49, 50, 49, 48, 49, 46 };
            int[] cuDirectAluminumHighBay1H = new int[] { 55, 54, 53, 54, 53, 52, 53, 52 };
            int[] cuDirectAluminumHighBay1G = new int[] { 59, 58, 57, 58, 56, 55, 56, 55 };
            int[] cuDirectAluminumHighBay1F = new int[] { 61, 60, 58, 59, 58, 58, 58, 57 };
            int[] cuDirectAluminumHighBay1E = new int[] { 64, 63, 62, 63, 62, 61, 61, 60 };
            int[] cuDirectAluminumHighBay1D = new int[] { 68, 65, 64, 66, 65, 64, 64, 63 };
            int[] cuDirectAluminumHighBay1C = new int[] { 69, 67, 65, 67, 66, 64, 64, 64 };
            int[] cuDirectAluminumHighBay1B = new int[] { 70, 68, 67, 68, 67, 66, 66, 65 };
            int[] cuDirectAluminumHighBay1A = new int[] { 71, 70, 68, 69, 67, 67, 67, 66 };
            //direct aluminum high bay spacing 1
            int[] cuDirectAluminumHighBay2J = new int[] { 40, 36, 34, 39, 36, 34, 36, 33 };
            int[] cuDirectAluminumHighBay2I = new int[] { 48, 45, 43, 47, 44, 43, 44, 42 };
            int[] cuDirectAluminumHighBay2H = new int[] { 52, 50, 48, 51, 49, 47, 49, 47 };
            int[] cuDirectAluminumHighBay2G = new int[] { 55, 53, 52, 55, 52, 51, 52, 51 };
            int[] cuDirectAluminumHighBay2F = new int[] { 58, 56, 53, 56, 55, 53, 55, 53 };
            int[] cuDirectAluminumHighBay2E = new int[] { 62, 60, 58, 61, 64, 62, 63, 62 };
            int[] cuDirectAluminumHighBay2D = new int[] { 66, 63, 61, 64, 62, 61, 62, 61 };
            int[] cuDirectAluminumHighBay2C = new int[] { 67, 65, 62, 66, 64, 62, 63, 62 };
            int[] cuDirectAluminumHighBay2B = new int[] { 69, 67, 62, 66, 64, 62, 63, 62 };
            int[] cuDirectAluminumHighBay2A = new int[] { 70, 68, 67, 69, 67, 65, 66, 64 };
            //direct concentrating or medium
            int[] cuDirectConcentratingMediumJ = new int[] { 40, 38, 36, 39, 38, 36, 38, 36 };
            int[] cuDirectConcentratingMediumI = new int[] { 48, 46, 45, 47, 46, 45, 45, 43 };
            int[] cuDirectConcentratingMediumH = new int[] { 52, 51, 50, 55, 50, 49, 50, 48 };
            int[] cuDirectConcentratingMediumG = new int[] { 55, 54, 53, 54, 53, 52, 53, 51 };
            int[] cuDirectConcentratingMediumF = new int[] { 57, 56, 55, 56, 55, 54, 55, 53 };
            int[] cuDirectConcentratingMediumE = new int[] { 60, 59, 58, 59, 58, 57, 57, 56 };
            int[] cuDirectConcentratingMediumD = new int[] { 64, 61, 60, 62, 60, 57, 60, 59 };
            int[] cuDirectConcentratingMediumC = new int[] { 64, 63, 61, 63, 62, 60, 60, 60 };
            int[] cuDirectConcentratingMediumB = new int[] { 65, 64, 63, 64, 63, 62, 62, 61 };
            int[] cuDirectConcentratingMediumA = new int[] { 66, 65, 64, 64, 63, 62, 62, 62 };
            //direct wide spread heavyduty type
            int[] cuDirectWideHeavyJ = new int[] { 37, 34, 31, 36, 34, 31, 34, 31 };
            int[] cuDirectWideHeavyI = new int[] { 45, 42, 41, 44, 41, 40, 41, 39 };
            int[] cuDirectWideHeavyH = new int[] { 48, 46, 45, 49, 45, 44, 45, 44 };
            int[] cuDirectWideHeavyG = new int[] { 52, 50, 48, 51, 49, 48, 49, 48 };
            int[] cuDirectWideHeavyF = new int[] { 55, 52, 51, 54, 55, 50, 51, 50 };
            int[] cuDirectWideHeavyE = new int[] { 47, 56, 54, 57, 55, 53, 55, 53 };
            int[] cuDirectWideHeavyD = new int[] { 62, 59, 57, 60, 58, 57, 57, 56 };
            int[] cuDirectWideHeavyC = new int[] { 63, 61, 58, 62, 59, 58, 59, 58 };
            int[] cuDirectWideHeavyB = new int[] { 64, 62, 61, 63, 61, 60, 60, 59 };
            int[] cuDirectWideHeavyA = new int[] { 66, 64, 62, 64, 62, 61, 62, 60 };
            //direct rlm glassteel
            int[] cuDirectGlassteelJ = new int[] { 27, 23, 20, 26, 23, 20, 22, 20 };
            int[] cuDirectGlassteelI = new int[] { 34, 30, 28, 33, 29, 27, 29, 27 };
            int[] cuDirectGlassteelH = new int[] { 37, 34, 31, 33, 33, 31, 32, 30 };
            int[] cuDirectGlassteelG = new int[] { 40, 37, 34, 39, 36, 34, 35, 33 };
            int[] cuDirectGlassteelF = new int[] { 42, 39, 37, 40, 38, 36, 37, 36 };
            int[] cuDirectGlassteelE = new int[] { 46, 43, 41, 45, 42, 40, 41, 40 };
            int[] cuDirectGlassteelD = new int[] { 49, 47, 44, 48, 46, 44, 44, 43 };
            int[] cuDirectGlassteelC = new int[] { 51, 49, 46, 49, 47, 46, 46, 44 };
            int[] cuDirectGlassteelB = new int[] { 53, 51, 49, 51, 49, 48, 48, 47 };
            int[] cuDirectGlassteelA = new int[] { 54, 53, 51, 53, 51, 49, 49, 48 };
            //direct rlm silvered bowl diffuser
            int[] cuDirectSilverBowlJ = new int[] { 38, 36, 35, 38, 36, 35, 38, 35 };
            int[] cuDirectSilverBowlI = new int[] { 46, 45, 44, 45, 44, 43, 44, 42 };
            int[] cuDirectSilverBowlH = new int[] { 49, 49, 48, 49, 48, 47, 48, 47 };
            int[] cuDirectSilverBowlG = new int[] { 53, 52, 51, 52, 51, 50, 51, 49 };
            int[] cuDirectSilverBowlF = new int[] { 55, 51, 53, 53, 53, 52, 53, 51 };
            int[] cuDirectSilverBowlE = new int[] { 57, 57, 56, 57, 56, 55, 55, 54 };
            int[] cuDirectSilverBowlD = new int[] { 61, 59, 58, 59, 58, 57, 57, 56 };
            int[] cuDirectSilverBowlC = new int[] { 62, 61, 61, 59, 60, 59, 59, 58 };
            int[] cuDirectSilverBowlB = new int[] { 63, 62, 61, 61, 60, 59, 59, 58 };
            int[] cuDirectSilverBowlA = new int[] { 64, 63, 62, 62, 61, 60, 60, 59 };
            //direct widespread vapor tight
            int[] cuDirectWideVaporJ = new int[] { 31, 26, 23, 30, 26, 23, 26, 23 };
            int[] cuDirectWideVaporI = new int[] { 38, 34, 31, 37, 33, 31, 33, 31 };
            int[] cuDirectWideVaporH = new int[] { 41, 38, 34, 41, 38, 34, 37, 34 };
            int[] cuDirectWideVaporG = new int[] { 45, 41, 39, 44, 41, 39, 40, 39 };
            int[] cuDirectWideVaporF = new int[] { 47, 44, 41, 46, 43, 41, 43, 41 };
            int[] cuDirectWideVaporE = new int[] { 51, 48, 46, 50, 48, 46, 47, 46 };
            int[] cuDirectWideVaporD = new int[] { 55, 52, 50, 54, 52, 50, 51, 50 };
            int[] cuDirectWideVaporC = new int[] { 56, 54, 52, 55, 53, 52, 52, 51 };
            int[] cuDirectWideVaporB = new int[] { 59, 57, 55, 58, 56, 54, 55, 54 };
            int[] cuDirectWideVaporA = new int[] { 60, 58, 56, 59, 57, 56, 56, 55 };
            //Enclosed lensplate distributing type
            int[] cuEnclosedLensJ = new int[] { 25, 22, 20, 24, 22, 20, 22, 20 };
            int[] cuEnclosedLensI = new int[] { 31, 28, 26, 29, 28, 26, 28, 26 };
            int[] cuEnclosedLensH = new int[] { 34, 31, 29, 32, 31, 29, 30, 29 };
            int[] cuEnclosedLensG = new int[] { 36, 34, 36, 34, 33, 31, 32, 30 };
            int[] cuEnclosedLensF = new int[] { 38, 35, 34, 36, 34, 33, 34, 32 };
            int[] cuEnclosedLensE = new int[] { 40, 39, 38, 39, 37, 36, 37, 35 };
            int[] cuEnclosedLensD = new int[] { 43, 47, 40, 42, 40, 39, 39, 38 };
            int[] cuEnclosedLensC = new int[] { 45, 43, 42, 44, 41, 40, 40, 40 };
            int[] cuEnclosedLensB = new int[] { 48, 45, 44, 47, 43, 42, 42, 41 };
            int[] cuEnclosedLensA = new int[] { 50, 47, 46, 48, 46, 45, 45, 44 };
            //direct two 40watt lamps
            int[] cuDirectTwo40J = new int[] { 38, 32, 28, 37, 32, 28, 31, 28 };
            int[] cuDirectTwo40I = new int[] { 47, 42, 39, 46, 41, 38, 40, 37 };
            int[] cuDirectTwo40H = new int[] { 51, 47, 44, 50, 47, 43, 46, 43 };
            int[] cuDirectTwo40G = new int[] { 55, 51, 48, 54, 51, 47, 50, 47 };
            int[] cuDirectTwo40F = new int[] { 58, 54, 51, 57, 53, 51, 52, 50 };
            int[] cuDirectTwo40E = new int[] { 63, 60, 57, 62, 59, 56, 58, 55 };
            int[] cuDirectTwo40D = new int[] { 68, 64, 61, 66, 64, 61, 63, 60 };
            int[] cuDirectTwo40C = new int[] { 70, 67, 63, 68, 65, 64, 64, 62 };
            int[] cuDirectTwo40B = new int[] { 73, 70, 68, 71, 68, 67, 67, 66 };
            int[] cuDirectTwo40A = new int[] { 74, 72, 70, 72, 70, 68, 69, 67 };
            //direct three 40watt lamps
            int[] cuDirectThree40J = new int[] { 34, 29, 25, 33, 29, 25, 28, 25 };
            int[] cuDirectThree40I = new int[] { 42, 38, 35, 41, 37, 34, 37, 34 };
            int[] cuDirectThree40H = new int[] { 46, 32, 39, 44, 42, 39, 41, 39 };
            int[] cuDirectThree40G = new int[] { 50, 46, 54, 48, 45, 41, 44, 41 };
            int[] cuDirectThree40F = new int[] { 53, 49, 46, 51, 47, 44, 47, 44 };
            int[] cuDirectThree40E = new int[] { 57, 54, 51, 56, 52, 50, 52, 50 };
            int[] cuDirectThree40D = new int[] { 61, 58, 55, 59, 56, 54, 56, 54 };
            int[] cuDirectThree40C = new int[] { 63, 60, 57, 61, 58, 56, 58, 56 };
            int[] cuDirectThree40B = new int[] { 66, 64, 61, 64, 60, 59, 60, 59 };
            int[] cuDirectThree40A = new int[] { 67, 65, 62, 66, 62, 61, 62, 60 };
            //direct twoo 100watt lamp
            int[] cuDirectTwo100J = new int[] { 33, 28, 25, 33, 28, 25, 28, 25 };
            int[] cuDirectTwo100I = new int[] { 41, 37, 34, 40, 36, 33, 36, 33 };
            int[] cuDirectTwo100H = new int[] { 45, 41, 38, 44, 41, 38, 40, 38 };
            int[] cuDirectTwo100G = new int[] { 48, 45, 42, 48, 45, 42, 43, 42 };
            int[] cuDirectTwo100F = new int[] { 51, 48, 45, 50, 47, 45, 46, 45 };
            int[] cuDirectTwo100E = new int[] { 55, 53, 50, 55, 52, 50, 51, 50 };
            int[] cuDirectTwo100D = new int[] { 60, 57, 54, 58, 56, 54, 55, 54 };
            int[] cuDirectTwo100C = new int[] { 61, 59, 56, 60, 57, 56, 57, 55 };
            int[] cuDirectTwo100B = new int[] { 64, 62, 60, 62, 60, 59, 60, 58 };
            int[] cuDirectTwo100A = new int[] { 65, 63, 61, 64, 62, 60, 61, 60 };

            //Direct: With Louvers, Two 40-Watt Lamps
            int[] cuDirectWithLouversJ = new int[] { 33, 28, 26, 32, 28, 26, 28, 28 };
            int[] cuDirectWithLouversI = new int[] { 39, 36, 34, 39, 35, 34, 35, 34 };
            int[] cuDirectWithLouversH = new int[] { 43, 40, 38, 42, 40, 38, 39, 38 };
            int[] cuDirectWithLouversG = new int[] { 46, 43, 41, 45, 43, 41, 42, 41 };
            int[] cuDirectWithLouversF = new int[] { 48, 46, 43, 47, 45, 43, 45, 43 };
            int[] cuDirectWithLouversE = new int[] { 52, 50, 47, 54, 49, 47, 48, 47 };
            int[] cuDirectWithLouversD = new int[] { 55, 53, 51, 54, 52, 51, 52, 51 };
            int[] cuDirectWithLouversC = new int[] { 57, 55, 52, 56, 53, 52, 51, 52 };
            int[] cuDirectWithLouversB = new int[] { 59, 57, 56, 57, 56, 55, 55, 54 };
            int[] cuDirectWithLouversA = new int[] { 60, 56, 56, 59, 57, 56, 56, 55 };

            //Direct: Vapor and Dust Tight, Two or Three 40-Watt Lamps
            int[] cuDirectVaporandDustTightJ = new int[] { 29, 26, 23, 28, 26, 23, 25, 23 };
            int[] cuDirectVaporandDustTightI = new int[] { 35, 32, 31, 35, 32, 30, 32, 30 };
            int[] cuDirectVaporandDustTightH = new int[] { 38, 36, 34, 38, 36, 34, 35, 34 };
            int[] cuDirectVaporandDustTightG = new int[] { 41, 39, 37, 41, 39, 37, 38, 37 };
            int[] cuDirectVaporandDustTightF = new int[] { 44, 41, 39, 42, 41, 39, 40, 39 };
            int[] cuDirectVaporandDustTightE = new int[] { 46, 45, 42, 46, 44, 42, 44, 42 };
            int[] cuDirectVaporandDustTightD = new int[] { 50, 48, 46, 49, 47, 46, 46, 46 };
            int[] cuDirectVaporandDustTightC = new int[] { 51, 49, 47, 50, 48, 47, 48, 46 };
            int[] cuDirectVaporandDustTightB = new int[] { 53, 51, 50, 52, 50, 49, 49, 49 };
            int[] cuDirectVaporandDustTightA = new int[] { 54, 52, 50, 53, 51, 50, 50, 47 };

            //Direct: Troffer, Open Type
            int[] cuDirectTrofferOpenJ = new int[] { 40, 37, 35, 39, 37, 35, 37, 35 };
            int[] cuDirectTrofferOpenI = new int[] { 48, 46, 45, 47, 45, 44, 44, 43 };
            int[] cuDirectTrofferOpenH = new int[] { 52, 50, 50, 51, 49, 49, 48, 48 };
            int[] cuDirectTrofferOpenG = new int[] { 55, 54, 53, 54, 53, 51, 51, 50 };
            int[] cuDirectTrofferOpenF = new int[] { 58, 56, 54, 55, 54, 53, 53, 52 };
            int[] cuDirectTrofferOpenE = new int[] { 60, 59, 57, 59, 58, 56, 57, 55 };
            int[] cuDirectTrofferOpenD = new int[] { 65, 62, 60, 62, 61, 59, 59, 58 };
            int[] cuDirectTrofferOpenC = new int[] { 66, 64, 61, 64, 62, 61, 61, 60 };
            int[] cuDirectTrofferOpenB = new int[] { 67, 65, 64, 65, 63, 62, 62, 61 };
            int[] cuDirectTrofferOpenA = new int[] { 68, 66, 65, 66, 65, 63, 64, 62 };

            //Direct: Troffer with Louvers, One Lamp
            int[] cuDirectTrofferwithLouversOneLampJ = new int[] { 32, 28, 25, 32, 28, 25, 28, 25 };
            int[] cuDirectTrofferwithLouversOneLampI = new int[] { 40, 36, 34, 39, 35, 33, 35, 33 };
            int[] cuDirectTrofferwithLouversOneLampH = new int[] { 43, 39, 37, 42, 39, 37, 39, 36 };
            int[] cuDirectTrofferwithLouversOneLampG = new int[] { 46, 43, 41, 45, 43, 41, 43, 40 };
            int[] cuDirectTrofferwithLouversOneLampF = new int[] { 48, 45, 43, 47, 45, 43, 45, 42 };
            int[] cuDirectTrofferwithLouversOneLampE = new int[] { 52, 50, 48, 51, 49, 47, 49, 46 };
            int[] cuDirectTrofferwithLouversOneLampD = new int[] { 56, 54, 52, 55, 53, 51, 53, 50 };
            int[] cuDirectTrofferwithLouversOneLampC = new int[] { 57, 55, 53, 56, 54, 52, 54, 51 };
            int[] cuDirectTrofferwithLouversOneLampB = new int[] { 60, 58, 56, 59, 57, 55, 56, 54 };
            int[] cuDirectTrofferwithLouversOneLampA = new int[] { 61, 59, 57, 60, 58, 57, 57, 56 };

            //Direct: Troffer with Louvers, Two Lamps
            int[] cuDirectTrofferwithLouversTwoLampsJ = new int[] { 30, 26, 23, 29, 26, 23, 26, 23 };
            int[] cuDirectTrofferwithLouversTwoLampsI = new int[] { 37, 33, 31, 36, 32, 30, 32, 30 };
            int[] cuDirectTrofferwithLouversTwoLampsH = new int[] { 40, 36, 34, 39, 36, 34, 36, 33 };
            int[] cuDirectTrofferwithLouversTwoLampsG = new int[] { 42, 40, 38, 41, 40, 38, 40, 37 };
            int[] cuDirectTrofferwithLouversTwoLampsF = new int[] { 44, 41, 40, 43, 41, 40, 41, 39 };
            int[] cuDirectTrofferwithLouversTwoLampsE = new int[] { 48, 46, 44, 47, 45, 43, 45, 42 };
            int[] cuDirectTrofferwithLouversTwoLampsD = new int[] { 52, 50, 48, 51, 49, 47, 49, 46 };
            int[] cuDirectTrofferwithLouversTwoLampsC = new int[] { 53, 51, 49, 52, 50, 48, 50, 47 };
            int[] cuDirectTrofferwithLouversTwoLampsB = new int[] { 50, 53, 52, 54, 53, 51, 52, 50 };
            int[] cuDirectTrofferwithLouversTwoLampsA = new int[] { 56, 54, 53, 55, 54, 53, 53, 52 };

            //Direct: Troffer with Ribbed-Glass Cover
            int[] cuDirectTrofferwithRibbedGlassCoverJ = new int[] { 28, 24, 22, 27, 24, 22, 24, 22 };
            int[] cuDirectTrofferwithRibbedGlassCoverI = new int[] { 34, 31, 29, 33, 30, 29, 30, 29 };
            int[] cuDirectTrofferwithRibbedGlassCoverH = new int[] { 37, 34, 33, 36, 34, 32, 33, 32 };
            int[] cuDirectTrofferwithRibbedGlassCoverG = new int[] { 39, 37, 36, 38, 37, 35, 38, 37 };
            int[] cuDirectTrofferwithRibbedGlassCoverF = new int[] { 42, 39, 37, 40, 38, 37, 41, 40 };
            int[] cuDirectTrofferwithRibbedGlassCoverE = new int[] { 44, 43, 40, 43, 42, 40, 42, 41 };
            int[] cuDirectTrofferwithRibbedGlassCoverD = new int[] { 47, 45, 43, 46, 45, 43, 44, 43 };
            int[] cuDirectTrofferwithRibbedGlassCoverC = new int[] { 49, 47, 45, 47, 46, 45, 45, 44 };
            int[] cuDirectTrofferwithRibbedGlassCoverB = new int[] { 50, 48, 47, 49, 47, 46, 46, 45 };
            int[] cuDirectTrofferwithRibbedGlassCoverA = new int[] { 51, 50, 48, 40, 48, 47, 47, 46 };

            //Direct: With Louvers for 40-Watt Lamps
            int[] cuDirectWithLouversfor40WattLampsJ = new int[] { 29, 46, 23, 28, 26, 23, 25, 23 };
            int[] cuDirectWithLouversfor40WattLampsI = new int[] { 35, 32, 31, 35, 32, 30, 32, 30 };
            int[] cuDirectWithLouversfor40WattLampsH = new int[] { 38, 36, 34, 38, 36, 34, 35, 34 };
            int[] cuDirectWithLouversfor40WattLampsG = new int[] { 41, 39, 37, 41, 39, 37, 38, 37 };
            int[] cuDirectWithLouversfor40WattLampsF = new int[] { 44, 41, 39, 42, 41, 39, 40, 39 };
            int[] cuDirectWithLouversfor40WattLampsE = new int[] { 46, 45, 42, 46, 44, 42, 44, 42 };
            int[] cuDirectWithLouversfor40WattLampsD = new int[] { 50, 48, 46, 49, 47, 46, 46, 46 };
            int[] cuDirectWithLouversfor40WattLampsC = new int[] { 51, 49, 47, 50, 48, 47, 48, 46 };
            int[] cuDirectWithLouversfor40WattLampsB = new int[] { 53, 51, 50, 52, 50, 49, 49, 49 };
            int[] cuDirectWithLouversfor40WattLampsA = new int[] { 54, 52, 50, 53, 51, 50, 50, 49 };

            //Direct: Bare Lamp with White Reflecting Surface
            int[] cuDirectBareLampJ = new int[] { 32, 27, 23, 32, 26, 23, 25, 23 };
            int[] cuDirectBareLampI = new int[] { 40, 35, 31, 39, 34, 30, 34, 30 };
            int[] cuDirectBareLampH = new int[] { 44, 39, 36, 43, 39, 35, 36, 35 };
            int[] cuDirectBareLampG = new int[] { 48, 43, 40, 46, 42, 39, 41, 39 };
            int[] cuDirectBareLampF = new int[] { 52, 47, 43, 50, 46, 42, 45, 42 };
            int[] cuDirectBareLampE = new int[] { 57, 52, 48, 55, 51, 47, 50, 46 };
            int[] cuDirectBareLampD = new int[] { 62, 56, 52, 59, 55, 51, 57, 51 };
            int[] cuDirectBareLampC = new int[] { 56, 59, 54, 62, 57, 54, 56, 53 };
            int[] cuDirectBareLampB = new int[] { 69, 63, 59, 65, 61, 58, 60, 58 };
            int[] cuDirectBareLampA = new int[] { 71, 66, 62, 67, 63, 60, 61, 60 };

            //Semidirect: Glass-Enclosed Two 40-Watt Lamps
            int[] cuSemidirectGlassEnclosed1J = new int[] { 23, 19, 17, 23, 18, 16, 17, 16 };
            int[] cuSemidirectGlassEnclosed1I = new int[] { 29, 25, 22, 28, 24, 21, 23, 21 };
            int[] cuSemidirectGlassEnclosed1H = new int[] { 32, 28, 25, 31, 28, 25, 26, 24 };
            int[] cuSemidirectGlassEnclosed1G = new int[] { 36, 32, 29, 34, 30, 27, 29, 26 };
            int[] cuSemidirectGlassEnclosed1F = new int[] { 40, 35, 31, 37, 33, 30, 31, 29 };
            int[] cuSemidirectGlassEnclosed1E = new int[] { 43, 39, 35, 41, 37, 34, 35, 32 };
            int[] cuSemidirectGlassEnclosed1D = new int[] { 47, 42, 39, 44, 40, 37, 38, 30 };
            int[] cuSemidirectGlassEnclosed1C = new int[] { 49, 45, 41, 46, 42, 39, 40, 38 };
            int[] cuSemidirectGlassEnclosed1B = new int[] { 52, 48, 45, 49, 45, 43, 43, 41 };
            int[] cuSemidirectGlassEnclosed1A = new int[] { 54, 51, 47, 51, 47, 45, 44, 43 };

            //Semidirect: Glass-Enclosed Two 40-Watt Lamps
            int[] cuSemidirectGlassEnclosed2J = new int[] { 23, 19, 17, 23, 18, 16, 17, 16 };
            int[] cuSemidirectGlassEnclosed2I = new int[] { 29, 25, 22, 28, 24, 21, 23, 21 };
            int[] cuSemidirectGlassEnclosed2H = new int[] { 32, 28, 25, 31, 28, 25, 26, 24 };
            int[] cuSemidirectGlassEnclosed2G = new int[] { 36, 32, 29, 34, 30, 27, 29, 26 };
            int[] cuSemidirectGlassEnclosed2F = new int[] { 40, 35, 31, 37, 33, 30, 31, 29 };
            int[] cuSemidirectGlassEnclosed2E = new int[] { 43, 39, 35, 41, 37, 34, 35, 32 };
            int[] cuSemidirectGlassEnclosed2D = new int[] { 47, 42, 39, 44, 40, 37, 38, 30 };
            int[] cuSemidirectGlassEnclosed2C = new int[] { 49, 45, 41, 46, 42, 39, 40, 38 };
            int[] cuSemidirectGlassEnclosed2B = new int[] { 52, 48, 45, 49, 45, 43, 43, 41 };
            int[] cuSemidirectGlassEnclosed2A = new int[] { 54, 51, 47, 51, 47, 45, 44, 43 };

            //Semidirect: Glass Enclosed Three 40-Watt Lamps
            int[] cuSemidirectGlassEnclosed3J = new int[] { 21, 17, 14, 12, 16, 14, 16, 14 };
            int[] cuSemidirectGlassEnclosed3I = new int[] { 26, 22, 20, 24, 21, 19, 21, 19 };
            int[] cuSemidirectGlassEnclosed3H = new int[] { 29, 25, 23, 28, 25, 22, 24, 22 };
            int[] cuSemidirectGlassEnclosed3G = new int[] { 32, 28, 25, 30, 27, 25, 26, 24 };
            int[] cuSemidirectGlassEnclosed3F = new int[] { 34, 30, 27, 33, 30, 27, 29, 27 };
            int[] cuSemidirectGlassEnclosed3E = new int[] { 38, 34, 31, 36, 33, 31, 32, 30 };
            int[] cuSemidirectGlassEnclosed3D = new int[] { 41, 37, 34, 39, 36, 34, 35, 33 };
            int[] cuSemidirectGlassEnclosed3C = new int[] { 42, 39, 36, 41, 38, 36, 37, 35 };
            int[] cuSemidirectGlassEnclosed3B = new int[] { 45, 42, 39, 42, 40, 39, 39, 38 };
            int[] cuSemidirectGlassEnclosed3A = new int[] { 47, 44, 41, 45, 42, 40, 41, 39 };

            //Semidirect: ExposedLamps
            int[] cuSemidirectExposedLampsJ = new int[] { 27, 25, 19, 26, 22, 19, 20, 18 };
            int[] cuSemidirectExposedLampsI = new int[] { 35, 29, 26, 33, 28, 25, 27, 24 };
            int[] cuSemidirectExposedLampsH = new int[] { 38, 34, 30, 36, 32, 29, 30, 28 };
            int[] cuSemidirectExposedLampsG = new int[] { 43, 38, 34, 40, 36, 32, 33, 31 };
            int[] cuSemidirectExposedLampsF = new int[] { 46, 41, 37, 43, 39, 35, 37, 33 };
            int[] cuSemidirectExposedLampsE = new int[] { 50, 46, 42, 47, 43, 40, 40, 38 };
            int[] cuSemidirectExposedLampsD = new int[] { 55, 50, 46, 51, 47, 44, 44, 42 };
            int[] cuSemidirectExposedLampsC = new int[] { 58, 53, 49, 53, 49, 46, 46, 44 };
            int[] cuSemidirectExposedLampsB = new int[] { 62, 57, 53, 57, 53, 51, 50, 48 };
            int[] cuSemidirectExposedLampsA = new int[] { 64, 60, 56, 59, 55, 52, 51, 49 };

            //General Diffuse: Totally Enclosed
            int[] cuGeneralDiffuseTotallyEnclosedJ = new int[] { 24, 19, 16, 22, 18, 15, 16, 14 };
            int[] cuGeneralDiffuseTotallyEnclosedI = new int[] { 29, 25, 22, 27, 23, 20, 21, 19 };
            int[] cuGeneralDiffuseTotallyEnclosedH = new int[] { 33, 28, 26, 30, 26, 24, 24, 21 };
            int[] cuGeneralDiffuseTotallyEnclosedG = new int[] { 37, 32, 29, 33, 29, 26, 26, 24 };
            int[] cuGeneralDiffuseTotallyEnclosedF = new int[] { 40, 36, 31, 36, 32, 29, 29, 26 };
            int[] cuGeneralDiffuseTotallyEnclosedE = new int[] { 45, 40, 36, 40, 36, 33, 32, 29 };
            int[] cuGeneralDiffuseTotallyEnclosedD = new int[] { 48, 43, 39, 43, 39, 36, 34, 33 };
            int[] cuGeneralDiffuseTotallyEnclosedC = new int[] { 51, 46, 42, 45, 41, 38, 37, 34 };
            int[] cuGeneralDiffuseTotallyEnclosedB = new int[] { 55, 50, 47, 49, 45, 42, 40, 38 };
            int[] cuGeneralDiffuseTotallyEnclosedA = new int[] { 57, 53, 49, 51, 47, 44, 41, 40 };

            //Direct-Indirect: Suspension Type Two 40-Watt Lamps
            int[] cuDirectIndirectSuspensionJ = new int[] { 26, 21, 18, 22, 19, 16, 16, 15 };
            int[] cuDirectIndirectSuspensionI = new int[] { 31, 26, 24, 27, 24, 22, 21, 19 };
            int[] cuDirectIndirectSuspensionH = new int[] { 34, 30, 28, 30, 27, 25, 24, 22 };
            int[] cuDirectIndirectSuspensionG = new int[] { 38, 34, 31, 34, 30, 28, 20, 25 };
            int[] cuDirectIndirectSuspensionF = new int[] { 41, 37, 33, 36, 33, 30, 28, 27 };
            int[] cuDirectIndirectSuspensionE = new int[] { 45, 41, 38, 40, 36, 34, 31, 30 };
            int[] cuDirectIndirectSuspensionD = new int[] { 49, 45, 42, 42, 41, 37, 34, 33 };
            int[] cuDirectIndirectSuspensionC = new int[] { 41, 48, 44, 44, 44, 39, 36, 34 };
            int[] cuDirectIndirectSuspensionB = new int[] { 55, 51, 49, 47, 45, 43, 38, 37 };
            int[] cuDirectIndirectSuspensionA = new int[] { 57, 53, 51, 59, 46, 44, 40, 38 };

            //Semidirect: Ceiling Type Two 40-Watt Lamps
            int[] cuSemidirectCeilingTypeJ = new int[] { 24, 20, 17, 23, 19, 16, 18, 16 };
            int[] cuSemidirectCeilingTypeI = new int[] { 30, 26, 23, 28, 24, 22, 24, 21 };
            int[] cuSemidirectCeilingTypeH = new int[] { 33, 29, 27, 23, 28, 26, 27, 25 };
            int[] cuSemidirectCeilingTypeG = new int[] { 36, 32, 29, 34, 31, 28, 29, 27 };
            int[] cuSemidirectCeilingTypeF = new int[] { 39, 35, 32, 36, 33, 31, 31, 30 };
            int[] cuSemidirectCeilingTypeE = new int[] { 42, 39, 36, 40, 37, 35, 35, 33 };
            int[] cuSemidirectCeilingTypeD = new int[] { 46, 43, 40, 43, 40, 38, 38, 37 };
            int[] cuSemidirectCeilingTypeC = new int[] { 48, 45, 42, 44, 42, 40, 40, 38 };
            int[] cuSemidirectCeilingTypeB = new int[] { 51, 48, 45, 47, 45, 43, 42, 41 };
            int[] cuSemidirectCeilingTypeA = new int[] { 52, 50, 47, 49, 50, 45, 53, 52 };


            //Direct-indirect with ribbed glass bottom four 40 w lamps
            int[] cuDirectIndirectRibbedGlassBottomJ = new int[] { 27, 24, 22, 24, 22, 21, 21, 19 };
            int[] cuDirectIndirectRibbedGlassBottomI = new int[] { 33, 30, 29, 29, 27, 26, 25, 23 };
            int[] cuDirectIndirectRibbedGlassBottomH = new int[] { 36, 34, 32, 32, 30, 29, 28, 26 };
            int[] cuDirectIndirectRibbedGlassBottomG = new int[] { 39, 37, 35, 36, 33, 32, 30, 28 };
            int[] cuDirectIndirectRibbedGlassBottomF = new int[] { 43, 40, 37, 38, 35, 34, 31, 30 };
            int[] cuDirectIndirectRibbedGlassBottomE = new int[] { 46, 43, 41, 41, 38, 37, 34, 32 };
            int[] cuDirectIndirectRibbedGlassBottomD = new int[] { 50, 46, 44, 43, 41, 39, 36, 35 };
            int[] cuDirectIndirectRibbedGlassBottomC = new int[] { 52, 49, 46, 45, 43, 41, 37, 36 };
            int[] cuDirectIndirectRibbedGlassBottomB = new int[] { 55, 52, 50, 47, 45, 44, 38, 37 };
            int[] cuDirectIndirectRibbedGlassBottomA = new int[] { 56, 54, 52, 49, 47, 45, 40, 38 };


            //Semidirect with ribbed glass bottom ceiling type
            int[] cuSemiDirectRibbedGlassBottomJ = new int[] { 25, 21, 19, 22, 20, 19, 18, 17 };
            int[] cuSemiDirectRibbedGlassBottomI = new int[] { 30, 28, 27, 27, 25, 24, 22, 21 };
            int[] cuSemiDirectRibbedGlassBottomH = new int[] { 33, 31, 30, 29, 27, 26, 25, 24 };
            int[] cuSemiDirectRibbedGlassBottomG = new int[] { 36, 34, 32, 31, 30, 28, 26, 26 };
            int[] cuSemiDirectRibbedGlassBottomF = new int[] { 38, 36, 34, 33, 31, 30, 28, 27 };
            int[] cuSemiDirectRibbedGlassBottomE = new int[] { 40, 39, 37, 35, 34, 32, 31, 29 };
            int[] cuSemiDirectRibbedGlassBottomD = new int[] { 43, 41, 39, 37, 36, 34, 32, 31 };
            int[] cuSemiDirectRibbedGlassBottomC = new int[] { 45, 43, 40, 39, 37, 36, 33, 32 };
            int[] cuSemiDirectRibbedGlassBottomB = new int[] { 47, 44, 43, 40, 38, 37, 34, 33 };
            int[] cuSemiDirectRibbedGlassBottomA = new int[] { 48, 46, 44, 41, 39, 38, 35, 34 };

            //Direct-indirect with Louvers suspension type
            int[] cuDirectIndirectWithLouversJ = new int[] { 26, 23, 20, 23, 20, 19, 19, 17 };
            int[] cuDirectIndirectWithLouversI = new int[] { 31, 28, 27, 28, 26, 24, 23, 20 };
            int[] cuDirectIndirectWithLouversH = new int[] { 35, 32, 30, 31, 28, 27, 26, 24 };
            int[] cuDirectIndirectWithLouversG = new int[] { 38, 35, 33, 34, 31, 30, 28, 27 };
            int[] cuDirectIndirectWithLouversF = new int[] { 41, 38, 35, 36, 34, 32, 30, 28 };
            int[] cuDirectIndirectWithLouversE = new int[] { 44, 42, 39, 39, 37, 35, 32, 31 };
            int[] cuDirectIndirectWithLouversD = new int[] { 48, 45, 42, 42, 39, 38, 34, 33 };
            int[] cuDirectIndirectWithLouversC = new int[] { 50, 49, 44, 43, 41, 39, 35, 34 };
            int[] cuDirectIndirectWithLouversB = new int[] { 53, 50, 48, 46, 43, 42, 37, 36 };
            int[] cuDirectIndirectWithLouversA = new int[] { 57, 52, 50, 47, 45, 43, 39, 37 };


            //Semi Direct with louvers ceiling type
            int[] cuSemiDIrectWithLouversJ = new int[] { 24, 21, 19, 21, 19, 18, 19, 17 };
            int[] cuSemiDIrectWithLouversI = new int[] { 30, 27, 25, 26, 24, 23, 23, 21 };
            int[] cuSemiDIrectWithLouversH = new int[] { 32, 30, 28, 29, 27, 25, 25, 24 };
            int[] cuSemiDIrectWithLouversG = new int[] { 36, 33, 31, 31, 29, 28, 27, 26 };
            int[] cuSemiDIrectWithLouversF = new int[] { 38, 35, 32, 32, 31, 29, 29, 27 };
            int[] cuSemiDIrectWithLouversE = new int[] { 40, 39, 36, 35, 35, 32, 31, 29 };
            int[] cuSemiDIrectWithLouversD = new int[] { 43, 40, 39, 38, 36, 34, 32, 32 };
            int[] cuSemiDIrectWithLouversC = new int[] { 46, 42, 40, 39, 37, 35, 33, 32 };
            int[] cuSemiDIrectWithLouversB = new int[] { 47, 45, 43, 41, 39, 38, 34, 34 };
            int[] cuSemiDIrectWithLouversA = new int[] { 48, 46, 44, 42, 40, 38, 35, 34 };

            //Semi-indirect Totally Enclosed
            int[] cuSemiIndirectTotallyEnclosedJ = new int[] { 20, 16, 13, 16, 13, 11, 10, 9 };
            int[] cuSemiIndirectTotallyEnclosedI = new int[] { 24, 20, 18, 20, 17, 15, 13, 12 };
            int[] cuSemiIndirectTotallyEnclosedH = new int[] { 28, 24, 21, 23, 19, 17, 15, 13 };
            int[] cuSemiIndirectTotallyEnclosedG = new int[] { 31, 27, 24, 26, 22, 20, 17, 15 };
            int[] cuSemiIndirectTotallyEnclosedF = new int[] { 34, 30, 27, 28, 24, 22, 19, 17 };
            int[] cuSemiIndirectTotallyEnclosedE = new int[] { 38, 34, 31, 31, 27, 25, 21, 19 };
            int[] cuSemiIndirectTotallyEnclosedD = new int[] { 42, 38, 35, 34, 30, 28, 23, 22 };
            int[] cuSemiIndirectTotallyEnclosedC = new int[] { 45, 41, 37, 36, 32, 30, 25, 23 };
            int[] cuSemiIndirectTotallyEnclosedB = new int[] { 49, 45, 42, 39, 36, 34, 27, 25 };
            int[] cuSemiIndirectTotallyEnclosedA = new int[] { 51, 47, 44, 41, 38, 36, 28, 27 };

            //Semi-indirect Two 40 W lamps
            int[] cuSemiIndirectTwoLampsJ = new int[] { 18, 14, 12, 14, 1, 9, 8, 7 };
            int[] cuSemiIndirectTwoLampsI = new int[] { 22, 19, 17, 17, 15, 13, 10, 9 };
            int[] cuSemiIndirectTwoLampsH = new int[] { 26, 22, 19, 20, 17, 15, 12, 10 };
            int[] cuSemiIndirectTwoLampsG = new int[] { 29, 25, 22, 22, 19, 17, 14, 12 };
            int[] cuSemiIndirectTwoLampsF = new int[] { 32, 28, 25, 24, 21, 19, 15, 14 };
            int[] cuSemiIndirectTwoLampsE = new int[] { 35, 32, 29, 27, 24, 21, 17, 15 };
            int[] cuSemiIndirectTwoLampsD = new int[] { 39, 35, 32, 29, 26, 24, 19, 18 };
            int[] cuSemiIndirectTwoLampsC = new int[] { 42, 38, 35, 31, 28, 27, 20, 19 };
            int[] cuSemiIndirectTwoLampsB = new int[] { 46, 42, 39, 34, 31, 29, 22, 21 };
            int[] cuSemiIndirectTwoLampsA = new int[] { 48, 44, 42, 36, 33, 31, 23, 22 };


            //Indirect Glass
            int[] cuIndirectGlassJ = new int[] { 16, 13, 11, 12, 10, 8, 6, 5 };
            int[] cuIndirectGlassI = new int[] { 20, 16, 15, 15, 13, 11, 8, 7 };
            int[] cuIndirectGlassH = new int[] { 23, 20, 17, 17, 14, 13, 10, 8 };
            int[] cuIndirectGlassG = new int[] { 26, 23, 20, 20, 17, 15, 11, 10 };
            int[] cuIndirectGlassF = new int[] { 29, 26, 22, 22, 19, 17, 12, 11 };
            int[] cuIndirectGlassE = new int[] { 32, 29, 26, 24, 21, 19, 13, 12 };
            int[] cuIndirectGlassD = new int[] { 36, 32, 30, 26, 24, 20, 15, 14 };
            int[] cuIndirectGlassC = new int[] { 38, 35, 32, 28, 25, 24, 16, 15 };
            int[] cuIndirectGlassB = new int[] { 42, 39, 36, 30, 29, 27, 18, 17 };
            int[] cuIndirectGlassA = new int[] { 44, 41, 39, 33, 30, 29, 19, 18 };


            //Indirect Silvered Bowl
            int[] cuIndirectSilveredBowlJ = new int[] { 17, 14, 12, 13, 11, 9, 7, 6 };
            int[] cuIndirectSilveredBowlI = new int[] { 21, 17, 16, 16, 14, 12, 9, 8 };
            int[] cuIndirectSilveredBowlH = new int[] { 24, 21, 18, 18, 15, 14, 11, 9 };
            int[] cuIndirectSilveredBowlG = new int[] { 27, 24, 21, 21, 18, 16, 12, 11 };
            int[] cuIndirectSilveredBowlF = new int[] { 30, 27, 23, 23, 20, 18, 13, 12 };
            int[] cuIndirectSilveredBowlE = new int[] { 33, 30, 27, 25, 22, 20, 14, 13 };
            int[] cuIndirectSilveredBowlD = new int[] { 37, 33, 31, 27, 25, 23, 16, 15 };
            int[] cuIndirectSilveredBowlC = new int[] { 39, 36, 33, 29, 26, 25, 17, 16 };
            int[] cuIndirectSilveredBowlB = new int[] { 43, 40, 37, 31, 30, 28, 19, 18 };
            int[] cuIndirectSilveredBowlA = new int[] { 45, 42, 40, 34, 31, 30, 20, 19 };

            //Indirect Two Lamp
            int[] cuIndirectTwoLampJ = new int[] { 15, 11, 10, 9, 8, 6, 4, 3 };
            int[] cuIndirectTwoLampI = new int[] { 19, 15, 13, 12, 10, 9, 6, 4 };
            int[] cuIndirectTwoLampH = new int[] { 22, 19, 16, 14, 12, 10, 7, 5 };
            int[] cuIndirectTwoLampG = new int[] { 26, 22, 19, 17, 14, 13, 8, 7 };
            int[] cuIndirectTwoLampF = new int[] { 28, 24, 21, 19, 16, 14, 9, 8 };
            int[] cuIndirectTwoLampE = new int[] { 32, 28, 25, 21, 18, 17, 11, 10 };
            int[] cuIndirectTwoLampD = new int[] { 35, 31, 29, 23, 21, 19, 12, 11 };
            int[] cuIndirectTwoLampC = new int[] { 38, 34, 31, 25, 22, 21, 13, 12 };
            int[] cuIndirectTwoLampB = new int[] { 42, 39, 36, 27, 25, 24, 15, 14 };
            int[] cuIndirectTwoLampA = new int[] { 43, 41, 38, 29, 27, 25, 16, 15 };
            #endregion
            #region porn
            int[] cuDirectReflector = new int[] { cuDirectReflectorJ[reflectance], cuDirectReflectorI[reflectance], cuDirectReflectorH[reflectance], cuDirectReflectorG[reflectance], cuDirectReflectorF[reflectance], cuDirectReflectorE[reflectance], cuDirectReflectorD[reflectance], cuDirectReflectorC[reflectance], cuDirectReflectorB[reflectance], cuDirectReflectorA[reflectance] };
            int[] cuDirectDeepReflector = new int[] { cuDirectDeepReflectorJ[reflectance], cuDirectDeepReflectorI[reflectance], cuDirectDeepReflectorH[reflectance], cuDirectDeepReflectorG[reflectance], cuDirectDeepReflectorF[reflectance], cuDirectDeepReflectorE[reflectance], cuDirectDeepReflectorD[reflectance], cuDirectDeepReflectorC[reflectance], cuDirectDeepReflectorB[reflectance], cuDirectDeepReflectorA[reflectance] };
            int[] cuDirectAluminumHighBay1 = new int[] { cuDirectAluminumHighBay1J[reflectance], cuDirectAluminumHighBay1I[reflectance], cuDirectAluminumHighBay1H[reflectance], cuDirectAluminumHighBay1G[reflectance], cuDirectAluminumHighBay1F[reflectance], cuDirectAluminumHighBay1E[reflectance], cuDirectAluminumHighBay1D[reflectance], cuDirectAluminumHighBay1C[reflectance], cuDirectAluminumHighBay1B[reflectance], cuDirectAluminumHighBay1A[reflectance] };
            int[] cuDirectAluminumHighBay2 = new int[] { cuDirectAluminumHighBay2J[reflectance], cuDirectAluminumHighBay2I[reflectance], cuDirectAluminumHighBay2H[reflectance], cuDirectAluminumHighBay2G[reflectance], cuDirectAluminumHighBay2F[reflectance], cuDirectAluminumHighBay2E[reflectance], cuDirectAluminumHighBay2D[reflectance], cuDirectAluminumHighBay2C[reflectance], cuDirectAluminumHighBay2B[reflectance], cuDirectAluminumHighBay2A[reflectance] };
            int[] cuDirectConcentratingMedium = new int[] { cuDirectConcentratingMediumJ[reflectance], cuDirectConcentratingMediumI[reflectance], cuDirectConcentratingMediumH[reflectance], cuDirectConcentratingMediumG[reflectance], cuDirectConcentratingMediumF[reflectance], cuDirectConcentratingMediumE[reflectance], cuDirectConcentratingMediumD[reflectance], cuDirectConcentratingMediumC[reflectance], cuDirectConcentratingMediumB[reflectance], cuDirectConcentratingMediumA[reflectance] };
            int[] cuDirectWideHeavy = new int[] { cuDirectWideHeavyJ[reflectance], cuDirectWideHeavyI[reflectance], cuDirectWideHeavyH[reflectance], cuDirectWideHeavyG[reflectance], cuDirectWideHeavyF[reflectance], cuDirectWideHeavyE[reflectance], cuDirectWideHeavyD[reflectance], cuDirectWideHeavyC[reflectance], cuDirectWideHeavyB[reflectance], cuDirectWideHeavyA[reflectance] };
            int[] cuDirectGlassteel = new int[] { cuDirectGlassteelJ[reflectance], cuDirectGlassteelI[reflectance], cuDirectGlassteelH[reflectance], cuDirectGlassteelG[reflectance], cuDirectGlassteelF[reflectance], cuDirectGlassteelE[reflectance], cuDirectGlassteelD[reflectance], cuDirectGlassteelC[reflectance], cuDirectGlassteelB[reflectance], cuDirectGlassteelA[reflectance] };
            int[] cuDirectSilverBowl = new int[] { cuDirectSilverBowlJ[reflectance], cuDirectSilverBowlI[reflectance], cuDirectSilverBowlH[reflectance], cuDirectSilverBowlG[reflectance], cuDirectSilverBowlF[reflectance], cuDirectSilverBowlE[reflectance], cuDirectSilverBowlD[reflectance], cuDirectSilverBowlC[reflectance], cuDirectSilverBowlB[reflectance], cuDirectSilverBowlA[reflectance] };
            int[] cuDirectWideVapor = new int[] { cuDirectWideVaporJ[reflectance], cuDirectWideVaporI[reflectance], cuDirectWideVaporH[reflectance], cuDirectWideVaporG[reflectance], cuDirectWideVaporF[reflectance], cuDirectWideVaporE[reflectance], cuDirectWideVaporD[reflectance], cuDirectWideVaporC[reflectance], cuDirectWideVaporB[reflectance], cuDirectWideVaporA[reflectance] };
            int[] cuEnclosedLens = new int[] { cuEnclosedLensJ[reflectance], cuEnclosedLensI[reflectance], cuEnclosedLensH[reflectance], cuEnclosedLensG[reflectance], cuEnclosedLensF[reflectance], cuEnclosedLensE[reflectance], cuEnclosedLensD[reflectance], cuEnclosedLensC[reflectance], cuEnclosedLensB[reflectance], cuEnclosedLensA[reflectance] };
            int[] cuDirectTwo40 = new int[] { cuDirectTwo40J[reflectance], cuDirectTwo40I[reflectance], cuDirectTwo40H[reflectance], cuDirectTwo40G[reflectance], cuDirectTwo40F[reflectance], cuDirectTwo40E[reflectance], cuDirectTwo40D[reflectance], cuDirectTwo40C[reflectance], cuDirectTwo40B[reflectance], cuDirectTwo40A[reflectance] };
            int[] cuDirectThree40 = new int[] { cuDirectThree40J[reflectance], cuDirectThree40I[reflectance], cuDirectThree40H[reflectance], cuDirectThree40G[reflectance], cuDirectThree40F[reflectance], cuDirectThree40E[reflectance], cuDirectThree40D[reflectance], cuDirectThree40C[reflectance], cuDirectThree40B[reflectance], cuDirectThree40A[reflectance] };
            int[] cuDirectTwo100 = new int[] { cuDirectTwo100J[reflectance], cuDirectTwo100I[reflectance], cuDirectTwo100H[reflectance], cuDirectTwo100G[reflectance], cuDirectTwo100F[reflectance], cuDirectTwo100E[reflectance], cuDirectTwo100D[reflectance], cuDirectTwo100C[reflectance], cuDirectTwo100B[reflectance], cuDirectTwo100A[reflectance]};
            int[] cuDirectWithLouvers = new int[] { cuDirectWithLouversJ[reflectance], cuDirectWithLouversI[reflectance], cuDirectWithLouversH[reflectance], cuDirectWithLouversG[reflectance], cuDirectWithLouversF[reflectance], cuDirectWithLouversE[reflectance], cuDirectWithLouversD[reflectance], cuDirectWithLouversC[reflectance], cuDirectWithLouversB[reflectance], cuDirectWithLouversA[reflectance] };
            int[] cuDirectVaporandDustTight = new int[] {cuDirectVaporandDustTightJ[reflectance], cuDirectVaporandDustTightI[reflectance], cuDirectVaporandDustTightH[reflectance], cuDirectVaporandDustTightG[reflectance], cuDirectVaporandDustTightF[reflectance], cuDirectVaporandDustTightE[reflectance], cuDirectVaporandDustTightD[reflectance], cuDirectVaporandDustTightC[reflectance], cuDirectVaporandDustTightB[reflectance], cuDirectVaporandDustTightA[reflectance]};
            int[] cuDirectTrofferOpen = new int[] { cuDirectTrofferOpenJ[reflectance], cuDirectTrofferOpenI[reflectance], cuDirectTrofferOpenH[reflectance], cuDirectTrofferOpenG[reflectance], cuDirectTrofferOpenF[reflectance], cuDirectTrofferOpenE[reflectance], cuDirectTrofferOpenD[reflectance], cuDirectTrofferOpenC[reflectance], cuDirectTrofferOpenB[reflectance], cuDirectTrofferOpenA[reflectance]};
            int[] cuDirectTrofferwithLouversOneLamp = new int[] { cuDirectTrofferwithLouversOneLampJ[reflectance], cuDirectTrofferwithLouversOneLampI[reflectance], cuDirectTrofferwithLouversOneLampH[reflectance], cuDirectTrofferwithLouversOneLampG[reflectance], cuDirectTrofferwithLouversOneLampF[reflectance], cuDirectTrofferwithLouversOneLampE[reflectance], cuDirectTrofferwithLouversOneLampD[reflectance], cuDirectTrofferwithLouversOneLampC[reflectance], cuDirectTrofferwithLouversOneLampB[reflectance], cuDirectTrofferwithLouversOneLampA[reflectance]};
            int[] cuDirectTrofferwithLouversTwoLamps = new int[] { cuDirectTrofferwithLouversTwoLampsJ[reflectance], cuDirectTrofferwithLouversTwoLampsI[reflectance], cuDirectTrofferwithLouversTwoLampsH[reflectance], cuDirectTrofferwithLouversTwoLampsG[reflectance], cuDirectTrofferwithLouversTwoLampsF[reflectance], cuDirectTrofferwithLouversTwoLampsE[reflectance], cuDirectTrofferwithLouversTwoLampsD[reflectance], cuDirectTrofferwithLouversTwoLampsC[reflectance], cuDirectTrofferwithLouversTwoLampsB[reflectance], cuDirectTrofferwithLouversTwoLampsA[reflectance]};
            int[] cuDirectWithLouversfor40WattLamps = new int[] {cuDirectWithLouversfor40WattLampsJ[reflectance], cuDirectWithLouversfor40WattLampsI[reflectance], cuDirectWithLouversfor40WattLampsH[reflectance], cuDirectWithLouversfor40WattLampsG[reflectance], cuDirectWithLouversfor40WattLampsF[reflectance], cuDirectWithLouversfor40WattLampsE[reflectance], cuDirectWithLouversfor40WattLampsD[reflectance], cuDirectWithLouversfor40WattLampsC[reflectance], cuDirectWithLouversfor40WattLampsB[reflectance], cuDirectWithLouversfor40WattLampsA[reflectance], };
            int[] cuDirectBareLamp = new int[] {cuDirectBareLampJ[reflectance], cuDirectBareLampI[reflectance], cuDirectBareLampH[reflectance], cuDirectBareLampG[reflectance], cuDirectBareLampF[reflectance], cuDirectBareLampE[reflectance], cuDirectBareLampD[reflectance], cuDirectBareLampC[reflectance], cuDirectBareLampB[reflectance], cuDirectBareLampA[reflectance], };
            int[] cuSemidirectGlassEnclosed1 = new int[] {cuSemidirectGlassEnclosed1J[reflectance], cuSemidirectGlassEnclosed1I[reflectance], cuSemidirectGlassEnclosed1H[reflectance], cuSemidirectGlassEnclosed1G[reflectance], cuSemidirectGlassEnclosed1F[reflectance], cuSemidirectGlassEnclosed1E[reflectance], cuSemidirectGlassEnclosed1D[reflectance], cuSemidirectGlassEnclosed1C[reflectance], cuSemidirectGlassEnclosed1B[reflectance], cuSemidirectGlassEnclosed1A[reflectance], };
            int[] cuSemidirectGlassEnclosed2 = new int[] {cuSemidirectGlassEnclosed2J[reflectance], cuSemidirectGlassEnclosed2I[reflectance], cuSemidirectGlassEnclosed2H[reflectance], cuSemidirectGlassEnclosed2G[reflectance], cuSemidirectGlassEnclosed2F[reflectance], cuSemidirectGlassEnclosed2E[reflectance], cuSemidirectGlassEnclosed2D[reflectance], cuSemidirectGlassEnclosed2C[reflectance], cuSemidirectGlassEnclosed2B[reflectance], cuSemidirectGlassEnclosed2A[reflectance], };
            int[] cuSemidirectGlassEnclosed3 = new int[] {cuSemidirectGlassEnclosed3J[reflectance], cuSemidirectGlassEnclosed3I[reflectance], cuSemidirectGlassEnclosed3H[reflectance], cuSemidirectGlassEnclosed3G[reflectance], cuSemidirectGlassEnclosed3F[reflectance], cuSemidirectGlassEnclosed3E[reflectance], cuSemidirectGlassEnclosed3D[reflectance], cuSemidirectGlassEnclosed3C[reflectance], cuSemidirectGlassEnclosed3B[reflectance], cuSemidirectGlassEnclosed3A[reflectance], };
            int[] cuSemidirectExposedLamps = new int[] {cuSemidirectExposedLampsJ[reflectance], cuSemidirectExposedLampsI[reflectance], cuSemidirectExposedLampsH[reflectance], cuSemidirectExposedLampsG[reflectance], cuSemidirectExposedLampsF[reflectance], cuSemidirectExposedLampsE[reflectance], cuSemidirectExposedLampsD[reflectance], cuSemidirectExposedLampsC[reflectance], cuSemidirectExposedLampsB[reflectance], cuSemidirectExposedLampsA[reflectance], };
            int[] cuGeneralDiffuseTotallyEnclosed = new int[] {cuGeneralDiffuseTotallyEnclosedJ[reflectance], cuGeneralDiffuseTotallyEnclosedI[reflectance], cuGeneralDiffuseTotallyEnclosedH[reflectance], cuGeneralDiffuseTotallyEnclosedG[reflectance], cuGeneralDiffuseTotallyEnclosedF[reflectance], cuGeneralDiffuseTotallyEnclosedE[reflectance], cuGeneralDiffuseTotallyEnclosedD[reflectance], cuGeneralDiffuseTotallyEnclosedC[reflectance], cuGeneralDiffuseTotallyEnclosedB[reflectance], cuGeneralDiffuseTotallyEnclosedA[reflectance], };
            int[] cuDirectIndirectSuspension = new int[] {cuDirectIndirectSuspensionJ[reflectance], cuDirectIndirectSuspensionI[reflectance], cuDirectIndirectSuspensionH[reflectance], cuDirectIndirectSuspensionG[reflectance], cuDirectIndirectSuspensionF[reflectance], cuDirectIndirectSuspensionE[reflectance], cuDirectIndirectSuspensionD[reflectance], cuDirectIndirectSuspensionC[reflectance], cuDirectIndirectSuspensionB[reflectance], cuDirectIndirectSuspensionA[reflectance], };
            int[] cuSemidirectCeilingType = new int[] {cuSemidirectCeilingTypeJ[reflectance], cuSemidirectCeilingTypeI[reflectance], cuSemidirectCeilingTypeH[reflectance], cuSemidirectCeilingTypeG[reflectance], cuSemidirectCeilingTypeF[reflectance], cuSemidirectCeilingTypeE[reflectance], cuSemidirectCeilingTypeD[reflectance], cuSemidirectCeilingTypeC[reflectance], cuSemidirectCeilingTypeB[reflectance], cuSemidirectCeilingTypeA[reflectance], };
            int[] cuDirectIndirectRibbedGlassBottom = new int[] {cuDirectIndirectRibbedGlassBottomJ[reflectance], cuDirectIndirectRibbedGlassBottomI[reflectance], cuDirectIndirectRibbedGlassBottomH[reflectance], cuDirectIndirectRibbedGlassBottomG[reflectance], cuDirectIndirectRibbedGlassBottomF[reflectance], cuDirectIndirectRibbedGlassBottomE[reflectance], cuDirectIndirectRibbedGlassBottomD[reflectance], cuDirectIndirectRibbedGlassBottomC[reflectance], cuDirectIndirectRibbedGlassBottomB[reflectance], cuDirectIndirectRibbedGlassBottomA[reflectance], };
            int[] cuSemiDirectRibbedGlassBottom = new int[] {cuSemiDirectRibbedGlassBottomJ[reflectance], cuSemiDirectRibbedGlassBottomI[reflectance], cuSemiDirectRibbedGlassBottomH[reflectance], cuSemiDirectRibbedGlassBottomG[reflectance], cuSemiDirectRibbedGlassBottomF[reflectance], cuSemiDirectRibbedGlassBottomE[reflectance], cuSemiDirectRibbedGlassBottomD[reflectance], cuSemiDirectRibbedGlassBottomC[reflectance], cuSemiDirectRibbedGlassBottomB[reflectance], cuSemiDirectRibbedGlassBottomA[reflectance], };
            int[] cuDirectIndirectWithLouvers = new int[] {cuDirectIndirectWithLouversJ[reflectance], cuDirectIndirectWithLouversI[reflectance], cuDirectIndirectWithLouversH[reflectance], cuDirectIndirectWithLouversG[reflectance], cuDirectIndirectWithLouversF[reflectance], cuDirectIndirectWithLouversE[reflectance], cuDirectIndirectWithLouversD[reflectance], cuDirectIndirectWithLouversC[reflectance], cuDirectIndirectWithLouversB[reflectance], cuDirectIndirectWithLouversA[reflectance], };
            int[] cuSemiDIrectWithLouvers = new int[] {cuSemiDIrectWithLouversJ[reflectance], cuSemiDIrectWithLouversI[reflectance], cuSemiDIrectWithLouversH[reflectance], cuSemiDIrectWithLouversG[reflectance], cuSemiDIrectWithLouversF[reflectance], cuSemiDIrectWithLouversE[reflectance], cuSemiDIrectWithLouversD[reflectance], cuSemiDIrectWithLouversC[reflectance], cuSemiDIrectWithLouversB[reflectance], cuSemiDIrectWithLouversA[reflectance], };
            int[] cuSemiIndirectTotallyEnclosed = new int[] {cuSemiIndirectTotallyEnclosedJ[reflectance], cuSemiIndirectTotallyEnclosedI[reflectance], cuSemiIndirectTotallyEnclosedH[reflectance], cuSemiIndirectTotallyEnclosedG[reflectance], cuSemiIndirectTotallyEnclosedF[reflectance], cuSemiIndirectTotallyEnclosedE[reflectance], cuSemiIndirectTotallyEnclosedD[reflectance], cuSemiIndirectTotallyEnclosedC[reflectance], cuSemiIndirectTotallyEnclosedB[reflectance], cuSemiIndirectTotallyEnclosedA[reflectance], };
            int[] cuSemiIndirectTwoLamps = new int[] {cuSemiIndirectTwoLampsJ[reflectance], cuSemiIndirectTwoLampsI[reflectance], cuSemiIndirectTwoLampsH[reflectance], cuSemiIndirectTwoLampsG[reflectance], cuSemiIndirectTwoLampsF[reflectance], cuSemiIndirectTwoLampsE[reflectance], cuSemiIndirectTwoLampsD[reflectance], cuSemiIndirectTwoLampsC[reflectance], cuSemiIndirectTwoLampsB[reflectance], cuSemiIndirectTwoLampsA[reflectance], };
            int[] cuIndirectGlass = new int[] {cuIndirectGlassJ[reflectance], cuIndirectGlassI[reflectance], cuIndirectGlassH[reflectance], cuIndirectGlassG[reflectance], cuIndirectGlassF[reflectance], cuIndirectGlassE[reflectance], cuIndirectGlassD[reflectance], cuIndirectGlassC[reflectance], cuIndirectGlassB[reflectance], cuIndirectGlassA[reflectance], };
            int[] cuIndirectSilveredBowl = new int[] {cuIndirectSilveredBowlJ[reflectance], cuIndirectSilveredBowlI[reflectance], cuIndirectSilveredBowlH[reflectance], cuIndirectSilveredBowlG[reflectance], cuIndirectSilveredBowlF[reflectance], cuIndirectSilveredBowlE[reflectance], cuIndirectSilveredBowlD[reflectance], cuIndirectSilveredBowlC[reflectance], cuIndirectSilveredBowlB[reflectance], cuIndirectSilveredBowlA[reflectance], };
            int[] cuIndirectTwoLamp = new int[] {cuIndirectTwoLampJ[reflectance], cuIndirectTwoLampI[reflectance], cuIndirectTwoLampH[reflectance], cuIndirectTwoLampG[reflectance], cuIndirectTwoLampF[reflectance], cuIndirectTwoLampE[reflectance], cuIndirectTwoLampD[reflectance], cuIndirectTwoLampC[reflectance], cuIndirectTwoLampB[reflectance], cuIndirectTwoLampA[reflectance], };
            #endregion


        }
    }
}