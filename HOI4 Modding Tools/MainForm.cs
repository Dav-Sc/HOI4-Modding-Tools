using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechanikaDesign.WinForms.UI.ColorPicker;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace HOI4_Modding_Tools
{
    public partial class Hoi4MainForm : Form
    {

        private HslColor colorHsl = HslColor.FromArgb(0xff, 0xff, 0xff, 0xff);
        //private ColorModes colorMode = ColorModes.Hue;
        private Color colorRgb = Color.Empty;
        private bool lockUpdates = false;

        private String generatedScript;
        private String rgbColorValue;

        private string localizationCode;


        public Hoi4MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load emssages for the text boxes, will use these to give small updates in case no one read the text file
            countryCode.Text = "The country name cannot have spaces, the name input is used as the file name and the Clausewitz Engine does notlike spaces in the names of files.";
            localizationText.Text = "FIX for v0.0.2 Any edits in this text box WILL effect what is added to the localization file.";

            //TODO Clean up these links there has to be a cleaner way to do this, but this was the first method I found
            //Will be adding link to Github
            LinkLabel.Link link = new LinkLabel.Link();
            LinkLabel.Link link2 = new LinkLabel.Link();

            //The Project Website
            link.LinkData = "http://actadiurnadespqr.com/admodding.html";
            webLink.Links.Add(link);
            //Discord Link
            link2.LinkData = "https://discord.gg/hshzSXkBxM";
            discordLink.Links.Add(link2);
        }


        //<-------------------------Begining of Country TXT--------------------------------->
        //Old Uncheck and clear function I was working on
        private void uncheckAndClear(CheckBox selected)
        {
            eastEuroCheck.Checked = false;
            westEuroCheck.Checked = false;
            asianCheck.Checked = false;
            southAmericanCheck.Checked = false;
            middleEastCheck.Checked = false;
            africanCheck.Checked = false;
            commonwealthCheck.Checked = false;
            countryCode.Clear();
        }



        //All of these check boxes are just checking for if they've been check, and if so uncheck all the other boxes, and add thier gfx/culture to the string.
        //TODO Fix bug where you have to double click check box when trying to select diffrent culture gfx, maybe move it to it's own C# script and have it 
        private void westEuroCheck_CheckedChanged(object sender, EventArgs e)
        {

            //uncheckAndClear(westEuroCheck);
            countryCode.Clear();
            //western_european_gfx
            //western_european_2d
            //countryCode.Text += "western_european_gfx\nwestern_european_2d";

            generatedScript = "graphical_culture = western_european_gfx\ngraphical_culture_2d = western_european_2d";
            eastEuroCheck.Checked = false;

            asianCheck.Checked = false;
            southAmericanCheck.Checked = false;
            middleEastCheck.Checked = false;
            africanCheck.Checked = false;
            commonwealthCheck.Checked = false;
        }

        private void eastEuroCheck_CheckedChanged(object sender, EventArgs e)
        {
            //uncheckAndClear(eastEuroCheck);

            countryCode.Clear();
            //countryCode.Text += "eastern_european_gfx\neastern_european_2d";

            generatedScript = "graphical_culture = eastern_european_gfx\ngraphical_culture_2d = eastern_european_2d";

            //eastern_european_gfx
            //eastern_european_2d

            westEuroCheck.Checked = false;
            asianCheck.Checked = false;
            southAmericanCheck.Checked = false;
            middleEastCheck.Checked = false;
            africanCheck.Checked = false;
            commonwealthCheck.Checked = false;
        }

        private void asianCheck_CheckedChanged(object sender, EventArgs e)
        {
            countryCode.Clear();
            //countryCode.Text = "asian_gfx\nasian_2d";
            generatedScript = "graphical_culture = asian_gfx\ngraphical_culture_2d = asian_2d";
            eastEuroCheck.Checked = false;
            westEuroCheck.Checked = false;
            southAmericanCheck.Checked = false;
            middleEastCheck.Checked = false;
            africanCheck.Checked = false;
            commonwealthCheck.Checked = false;
        }

        private void southAmericanCheck_CheckedChanged(object sender, EventArgs e)
        {
            countryCode.Clear();
            generatedScript = "graphical_culture = southamerican_gfx\ngraphical_culture_2d = southamerican_2d";
            eastEuroCheck.Checked = false;
            westEuroCheck.Checked = false;
            asianCheck.Checked = false;
            middleEastCheck.Checked = false;
            africanCheck.Checked = false;
            commonwealthCheck.Checked = false;
        }

        private void middleEastCheck_CheckedChanged(object sender, EventArgs e)
        {
            countryCode.Clear();
            generatedScript = "graphical_culture = middle_eastern_gfx\ngraphical_culture_2d = middle_eastern_2d";
            eastEuroCheck.Checked = false;
            westEuroCheck.Checked = false;
            asianCheck.Checked = false;
            southAmericanCheck.Checked = false;
            africanCheck.Checked = false;
            commonwealthCheck.Checked = false;
        }

        private void africanCheck_CheckedChanged(object sender, EventArgs e)
        {
            countryCode.Clear();
            generatedScript = "graphical_culture = african_gfx\ngraphical_culture_2d = african_2d";
            eastEuroCheck.Checked = false;
            westEuroCheck.Checked = false;
            asianCheck.Checked = false;
            southAmericanCheck.Checked = false;
            middleEastCheck.Checked = false;
            commonwealthCheck.Checked = false;
        }

        private void commonwealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            countryCode.Clear();
            generatedScript = "graphical_culture = commonwealth_gfx\ngraphical_culture_2d = commonwealth_2d";
            eastEuroCheck.Checked = false;
            westEuroCheck.Checked = false;
            asianCheck.Checked = false;
            southAmericanCheck.Checked = false;
            middleEastCheck.Checked = false;
            africanCheck.Checked = false;
        }



        //This is neede by ColorPicker Library to do a live update of the color values and color viewing box, check out:
        // https://www.mechanikadesign.com/software/colorpicker-controls-for-windows-forms/
        private void UpdateColorFields()
        {

            this.lockUpdates = true;
            //Red, Green, and Blue updates
            this.numRed.Value = this.colorRgb.R;
            this.numGreen.Value = this.colorRgb.G;
            this.numBlue.Value = this.colorRgb.B;

            //this.numHue.Value = (int)(((decimal)this.colorHsl.H) * 360M);
            //this.numSaturation.Value = (int)(((decimal)this.colorHsl.S) * 100M);
            //this.numLuminance.Value = (int)(((decimal)this.colorHsl.L) * 100M);

            this.lockUpdates = false;
            //Sets current selected color in the viewing box
            labelCurrentColor.BackColor = colorBox2D1.ColorRGB;
            //updates the color code
            rgbColorValue = ("\ncolor = { " + this.colorRgb.R + " " + this.colorRgb.G + " " + this.colorRgb.B + " }");


            textboxHexColor.Text = ColorTranslator.ToHtml(this.colorRgb);

            //countryCode.Text.Remove(countryCode.Text.LastIndexOf(Environment.NewLine));
        }


        private void colorSliderVertical1_ColorChanged(object sender, MechanikaDesign.WinForms.UI.ColorPicker.ColorChangedEventArgs args)
        {
            if (!this.lockUpdates)
            {
                HslColor colorHSL = this.colorSliderVertical1.ColorHSL;
                this.colorHsl = colorHSL;
                this.colorRgb = this.colorHsl.RgbValue;
                this.lockUpdates = true;
                this.colorBox2D1.ColorHSL = this.colorHsl;
                this.lockUpdates = false;
                //labelCurrentColor.BackColor = this.colorRgb;
                //rgbColor = this.colorRgb.R + this.colorRgb.G + this.colorRgb.B
                // textBoxColor.Text = this.colorRgb.R + this.colorRgb.G + this.colorRgb.B;
                UpdateColorFields();
            }
        }

        private void colorBox2D1_ColorChanged(object sender, MechanikaDesign.WinForms.UI.ColorPicker.ColorChangedEventArgs args)
        {
            if (!this.lockUpdates)
            {
                HslColor colorHSL = this.colorBox2D1.ColorHSL;
                this.colorHsl = colorHSL;
                this.colorRgb = this.colorHsl.RgbValue;
                this.lockUpdates = true;
                this.colorSliderVertical1.ColorHSL = this.colorHsl;
                this.lockUpdates = false;
                //labelCurrentColor.BackColor = this.colorRgb;
                //hexColorBox.Text = ColorTranslator.ToHtml(this.colorRgb);


                UpdateColorFields();
            }
        }

        //clear button
        private void button2_Click(object sender, EventArgs e)
        {
            countryCode.Clear();
            eastEuroCheck.Checked = false;
            westEuroCheck.Checked = false;
            asianCheck.Checked = false;
            southAmericanCheck.Checked = false;
            middleEastCheck.Checked = false;
            africanCheck.Checked = false;
            commonwealthCheck.Checked = false;
        }

        private void colorConfirmation_Click(object sender, EventArgs e)
        {
            //Clear the code
            //countryCode.Clear();

            //generatedScript += rgbColorValue;
            //countryCode.Text += ("\ncolor = { " + this.colorRgb.R + "  " + this.colorRgb.G + " " + this.colorRgb.B + " }");
            countryCode.Text = generatedScript + rgbColorValue;
        }


        private void generatecountryTXTFile_Click(object sender, EventArgs e)
        {
            //create path for country code
            string countryPath = AppDomain.CurrentDomain.BaseDirectory + "countries\\" + countryName.Text + ".txt";

            //Create Directory if doesn not exist
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "countries"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "countries");
                Console.WriteLine("Created");
            }
            //else ignore and print message
            else
            {
                Console.WriteLine("Already Exists!");
            }


            //if the file already exists delete it and replace it
            if (File.Exists(countryPath))
            {
                File.Delete(countryPath);
            }

            // Then create the file. 
            using (FileStream fs = File.Create(countryPath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(countryCode.Text);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

        private void textboxHexColor_TextChanged(object sender, EventArgs e)
        {


            bool isHexCode = Regex.IsMatch(textboxHexColor.Text, @"^#(?:[0-9a-fA-F]{3}){1,2}$");

            if (isHexCode)
            {
                string hexToRGB;
                hexToRGB = ColorTranslator.FromHtml(textboxHexColor.Text).ToString();
                hexToRGB = hexToRGB.Remove(0, 13);
                hexToRGB = RemoveSpecialCharacters(hexToRGB);
                Debug.Print(hexToRGB);

                string[] rgbValues = hexToRGB.Split('R', 'G', 'B');

                string redValue = rgbValues[1];
                string greenValue = rgbValues[2];
                string blueValue = rgbValues[3];

                Debug.Print(redValue);

                //colorBox2D1.ColorRGB = (redValue, greenValue, blueValue);
            }
            else
            {
                //nuffin'
            }
        }

        //Credit https://stackoverflow.com/questions/1120198/most-efficient-way-to-remove-special-characters-from-string
        private string RemoveSpecialCharacters(string charRemove)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in charRemove)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }


        //<-------------------------Begining of Localization--------------------------------->

        private void addLocalizationButton_Click(object sender, EventArgs e)
        {

            localizationCode = (
                //Adds the localization text to the text box and ready to export it to a file
                " " + countryLocalTag.Text + "_fascism:0 " + '"' + fascistName.Text + '"' + "\n "
                + countryLocalTag.Text + "_fascism_DEF:0 " + '"' + fascistDEF.Text + '"' + "\n "
                + countryLocalTag.Text + "_democratic:0 " + '"' + DemoName.Text + '"' + "\n "
                + countryLocalTag.Text + "_democratic_DEF:0 " + '"' + DemoDEF.Text + '"' + "\n "
                + countryLocalTag.Text + "_neutrality:0 " + '"' + NeuName.Text + '"' + "\n "
                + countryLocalTag.Text + "_neutrality_DEF:0 " + '"' + NeuDEF.Text + '"' + "\n "
                + countryLocalTag.Text + "_communism:0 " + '"' + CommName.Text + '"' + "\n "
                + countryLocalTag.Text + "_communism_DEF:0 " + '"' + CommDEF.Text + '"' + "\n "
                + countryLocalTag.Text + "_fascism_ADJ:0 " + '"' + fascistADJ.Text + '"' + "\n "
                + countryLocalTag.Text + "_democratic_ADJ:0 " + '"' + DemoADJ.Text + '"' + "\n "
                + countryLocalTag.Text + "_neutrality_ADJ:0 " + '"' + NeuADJ.Text + '"' + "\n "
                + countryLocalTag.Text + "_communism_ADJ:0 " + '"' + CommADJ.Text + '"' + " ");

            localizationText.Text = localizationCode;
            //countryLocalTag;

        }


        private void exportLocalization_Click_1(object sender, EventArgs e)
        {
            //String countryFileName = countryLocalTag.Text + "_l_english.yml";
            string localizationPath = AppDomain.CurrentDomain.BaseDirectory + /*countryLocalTag.Text + */ "localisation\\countries_mod_l_english.yml";

            {
                // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(localizationPath))
                {
                    sw.WriteLine(localizationText.Text); // Write text to .txt file
                    localizationCode = null;
                    localizationCode = "";
                }

            }
        }

        private void clearLocalizationbutton_Click(object sender, EventArgs e)
        {
            localizationCode = null;
            localizationCode = "";
            localizationText.Clear();
        }




        //<-------------------------Begining of Debug Menu--------------------------------->

        private void createlocalizationButton_Click_1(object sender, EventArgs e)
        {
            string localizationPath = AppDomain.CurrentDomain.BaseDirectory + /*countryLocalTag.Text + */ "localisation\\countries_mod_l_english.yml";

            //Create Directory if doesn not exist
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "localisation"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "localisation");
                Console.WriteLine("Created");
            }
            //else ignore and print message
            else
            {
                Console.WriteLine("Already Exists!");
            }

            // If file does not exists

            if (!File.Exists(localizationPath))
            {// Create file
                File.Create(localizationPath).Dispose();
                using (StreamWriter sw = File.AppendText(localizationPath))
                {
                    // Write text to .txt file
                    sw.WriteLine("l_english:");

                }
            }
        }

        private void webLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);

        }

        private void discordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);

        }


    }
}
