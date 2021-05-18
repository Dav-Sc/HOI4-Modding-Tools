
namespace HOI4_Modding_Tools
{
    partial class Hoi4MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoi4MainForm));
            this.westEuroCheck = new System.Windows.Forms.CheckBox();
            this.colorBox2D1 = new MechanikaDesign.WinForms.UI.ColorPicker.ColorBox2D();
            this.countryCode = new System.Windows.Forms.RichTextBox();
            this.colorSliderVertical1 = new MechanikaDesign.WinForms.UI.ColorPicker.ColorSliderVertical();
            this.label3 = new System.Windows.Forms.Label();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.commonwealthCheck = new System.Windows.Forms.CheckBox();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.africanCheck = new System.Windows.Forms.CheckBox();
            this.numBlue = new System.Windows.Forms.NumericUpDown();
            this.middleEastCheck = new System.Windows.Forms.CheckBox();
            this.colorConfirmation = new System.Windows.Forms.Button();
            this.southAmericanCheck = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.asianCheck = new System.Windows.Forms.CheckBox();
            this.labelCurrentColor = new System.Windows.Forms.Label();
            this.eastEuroCheck = new System.Windows.Forms.CheckBox();
            this.generatecountryTXTFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countryName = new System.Windows.Forms.TextBox();
            this.countryLocalTag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fascistName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fascistDEF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fascistADJ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CommADJ = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CommDEF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CommName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DemoADJ = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DemoDEF = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DemoName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.NeuADJ = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.NeuDEF = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.NeuName = new System.Windows.Forms.TextBox();
            this.localizationText = new System.Windows.Forms.RichTextBox();
            this.addLocalizationButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearLocalizationbutton = new System.Windows.Forms.Button();
            this.exportLocalization = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.discordLink = new System.Windows.Forms.LinkLabel();
            this.webLink = new System.Windows.Forms.LinkLabel();
            this.createlocalizationButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textboxHexColor = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // westEuroCheck
            // 
            this.westEuroCheck.AutoSize = true;
            this.westEuroCheck.Location = new System.Drawing.Point(9, 82);
            this.westEuroCheck.Name = "westEuroCheck";
            this.westEuroCheck.Size = new System.Drawing.Size(115, 17);
            this.westEuroCheck.TabIndex = 13;
            this.westEuroCheck.Text = "Western European";
            this.westEuroCheck.UseVisualStyleBackColor = true;
            this.westEuroCheck.CheckedChanged += new System.EventHandler(this.westEuroCheck_CheckedChanged);
            // 
            // colorBox2D1
            // 
            this.colorBox2D1.ColorMode = MechanikaDesign.WinForms.UI.ColorPicker.ColorModes.Hue;
            this.colorBox2D1.ColorRGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorBox2D1.Location = new System.Drawing.Point(9, 273);
            this.colorBox2D1.Name = "colorBox2D1";
            this.colorBox2D1.Size = new System.Drawing.Size(150, 150);
            this.colorBox2D1.TabIndex = 14;
            this.colorBox2D1.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorBox2D.ColorChangedEventHandler(this.colorBox2D1_ColorChanged);
            // 
            // countryCode
            // 
            this.countryCode.Location = new System.Drawing.Point(208, 45);
            this.countryCode.Name = "countryCode";
            this.countryCode.Size = new System.Drawing.Size(259, 246);
            this.countryCode.TabIndex = 12;
            this.countryCode.Text = "";
            // 
            // colorSliderVertical1
            // 
            this.colorSliderVertical1.ColorMode = MechanikaDesign.WinForms.UI.ColorPicker.ColorModes.Hue;
            this.colorSliderVertical1.ColorRGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorSliderVertical1.Location = new System.Drawing.Point(165, 273);
            this.colorSliderVertical1.Name = "colorSliderVertical1";
            this.colorSliderVertical1.NubColor = System.Drawing.Color.Empty;
            this.colorSliderVertical1.Position = 0;
            this.colorSliderVertical1.Size = new System.Drawing.Size(37, 150);
            this.colorSliderVertical1.TabIndex = 15;
            this.colorSliderVertical1.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorSliderVertical.ColorChangedEventHandler(this.colorSliderVertical1_ColorChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nation Color";
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(274, 400);
            this.numRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRed.Name = "numRed";
            this.numRed.Size = new System.Drawing.Size(54, 20);
            this.numRed.TabIndex = 16;
            this.numRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // commonwealthCheck
            // 
            this.commonwealthCheck.AutoSize = true;
            this.commonwealthCheck.Location = new System.Drawing.Point(9, 220);
            this.commonwealthCheck.Name = "commonwealthCheck";
            this.commonwealthCheck.Size = new System.Drawing.Size(98, 17);
            this.commonwealthCheck.TabIndex = 9;
            this.commonwealthCheck.Text = "Commonwealth";
            this.commonwealthCheck.UseVisualStyleBackColor = true;
            this.commonwealthCheck.CheckedChanged += new System.EventHandler(this.commonwealthCheck_CheckedChanged);
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(334, 400);
            this.numGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreen.Name = "numGreen";
            this.numGreen.Size = new System.Drawing.Size(54, 20);
            this.numGreen.TabIndex = 17;
            // 
            // africanCheck
            // 
            this.africanCheck.AutoSize = true;
            this.africanCheck.Location = new System.Drawing.Point(9, 197);
            this.africanCheck.Name = "africanCheck";
            this.africanCheck.Size = new System.Drawing.Size(59, 17);
            this.africanCheck.TabIndex = 8;
            this.africanCheck.Text = "African";
            this.africanCheck.UseVisualStyleBackColor = true;
            this.africanCheck.CheckedChanged += new System.EventHandler(this.africanCheck_CheckedChanged);
            // 
            // numBlue
            // 
            this.numBlue.Location = new System.Drawing.Point(394, 400);
            this.numBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlue.Name = "numBlue";
            this.numBlue.Size = new System.Drawing.Size(54, 20);
            this.numBlue.TabIndex = 18;
            // 
            // middleEastCheck
            // 
            this.middleEastCheck.AutoSize = true;
            this.middleEastCheck.Location = new System.Drawing.Point(9, 174);
            this.middleEastCheck.Name = "middleEastCheck";
            this.middleEastCheck.Size = new System.Drawing.Size(96, 17);
            this.middleEastCheck.TabIndex = 7;
            this.middleEastCheck.Text = "Middle Eastern";
            this.middleEastCheck.UseVisualStyleBackColor = true;
            this.middleEastCheck.CheckedChanged += new System.EventHandler(this.middleEastCheck_CheckedChanged);
            // 
            // colorConfirmation
            // 
            this.colorConfirmation.Location = new System.Drawing.Point(9, 429);
            this.colorConfirmation.Name = "colorConfirmation";
            this.colorConfirmation.Size = new System.Drawing.Size(193, 23);
            this.colorConfirmation.TabIndex = 19;
            this.colorConfirmation.Text = "Generate";
            this.colorConfirmation.UseVisualStyleBackColor = true;
            this.colorConfirmation.Click += new System.EventHandler(this.colorConfirmation_Click);
            // 
            // southAmericanCheck
            // 
            this.southAmericanCheck.AutoSize = true;
            this.southAmericanCheck.Location = new System.Drawing.Point(9, 151);
            this.southAmericanCheck.Name = "southAmericanCheck";
            this.southAmericanCheck.Size = new System.Drawing.Size(101, 17);
            this.southAmericanCheck.TabIndex = 6;
            this.southAmericanCheck.Text = "South American";
            this.southAmericanCheck.UseVisualStyleBackColor = true;
            this.southAmericanCheck.CheckedChanged += new System.EventHandler(this.southAmericanCheck_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Clear Culture Selection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // asianCheck
            // 
            this.asianCheck.AutoSize = true;
            this.asianCheck.Location = new System.Drawing.Point(9, 128);
            this.asianCheck.Name = "asianCheck";
            this.asianCheck.Size = new System.Drawing.Size(52, 17);
            this.asianCheck.TabIndex = 5;
            this.asianCheck.Text = "Asian";
            this.asianCheck.UseVisualStyleBackColor = true;
            this.asianCheck.CheckedChanged += new System.EventHandler(this.asianCheck_CheckedChanged);
            // 
            // labelCurrentColor
            // 
            this.labelCurrentColor.BackColor = System.Drawing.Color.White;
            this.labelCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentColor.Location = new System.Drawing.Point(208, 320);
            this.labelCurrentColor.Name = "labelCurrentColor";
            this.labelCurrentColor.Size = new System.Drawing.Size(54, 103);
            this.labelCurrentColor.TabIndex = 21;
            // 
            // eastEuroCheck
            // 
            this.eastEuroCheck.AutoSize = true;
            this.eastEuroCheck.Location = new System.Drawing.Point(9, 105);
            this.eastEuroCheck.Name = "eastEuroCheck";
            this.eastEuroCheck.Size = new System.Drawing.Size(111, 17);
            this.eastEuroCheck.TabIndex = 4;
            this.eastEuroCheck.Text = "Eastern European";
            this.eastEuroCheck.UseVisualStyleBackColor = true;
            this.eastEuroCheck.CheckedChanged += new System.EventHandler(this.eastEuroCheck_CheckedChanged);
            // 
            // generatecountryTXTFile
            // 
            this.generatecountryTXTFile.Location = new System.Drawing.Point(349, 429);
            this.generatecountryTXTFile.Name = "generatecountryTXTFile";
            this.generatecountryTXTFile.Size = new System.Drawing.Size(118, 23);
            this.generatecountryTXTFile.TabIndex = 22;
            this.generatecountryTXTFile.Text = "Export";
            this.generatecountryTXTFile.UseVisualStyleBackColor = true;
            this.generatecountryTXTFile.Click += new System.EventHandler(this.generatecountryTXTFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Culture Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country Name";
            // 
            // countryName
            // 
            this.countryName.Location = new System.Drawing.Point(9, 43);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(100, 20);
            this.countryName.TabIndex = 0;
            // 
            // countryLocalTag
            // 
            this.countryLocalTag.Location = new System.Drawing.Point(9, 43);
            this.countryLocalTag.Name = "countryLocalTag";
            this.countryLocalTag.Size = new System.Drawing.Size(100, 20);
            this.countryLocalTag.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "TAG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fascist name";
            // 
            // fascistName
            // 
            this.fascistName.Location = new System.Drawing.Point(9, 82);
            this.fascistName.Name = "fascistName";
            this.fascistName.Size = new System.Drawing.Size(100, 20);
            this.fascistName.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fascist DEF";
            // 
            // fascistDEF
            // 
            this.fascistDEF.Location = new System.Drawing.Point(9, 121);
            this.fascistDEF.Name = "fascistDEF";
            this.fascistDEF.Size = new System.Drawing.Size(100, 20);
            this.fascistDEF.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Fascist Adjective";
            // 
            // fascistADJ
            // 
            this.fascistADJ.Location = new System.Drawing.Point(9, 160);
            this.fascistADJ.Name = "fascistADJ";
            this.fascistADJ.Size = new System.Drawing.Size(100, 20);
            this.fascistADJ.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Communist Adjective";
            // 
            // CommADJ
            // 
            this.CommADJ.Location = new System.Drawing.Point(120, 160);
            this.CommADJ.Name = "CommADJ";
            this.CommADJ.Size = new System.Drawing.Size(100, 20);
            this.CommADJ.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Communist DEF";
            // 
            // CommDEF
            // 
            this.CommDEF.Location = new System.Drawing.Point(120, 121);
            this.CommDEF.Name = "CommDEF";
            this.CommDEF.Size = new System.Drawing.Size(100, 20);
            this.CommDEF.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Communist name";
            // 
            // CommName
            // 
            this.CommName.Location = new System.Drawing.Point(120, 82);
            this.CommName.Name = "CommName";
            this.CommName.Size = new System.Drawing.Size(100, 20);
            this.CommName.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Democratic Adjective";
            // 
            // DemoADJ
            // 
            this.DemoADJ.Location = new System.Drawing.Point(234, 160);
            this.DemoADJ.Name = "DemoADJ";
            this.DemoADJ.Size = new System.Drawing.Size(100, 20);
            this.DemoADJ.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Democratic DEF";
            // 
            // DemoDEF
            // 
            this.DemoDEF.Location = new System.Drawing.Point(234, 121);
            this.DemoDEF.Name = "DemoDEF";
            this.DemoDEF.Size = new System.Drawing.Size(100, 20);
            this.DemoDEF.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Democratic name";
            // 
            // DemoName
            // 
            this.DemoName.Location = new System.Drawing.Point(234, 82);
            this.DemoName.Name = "DemoName";
            this.DemoName.Size = new System.Drawing.Size(100, 20);
            this.DemoName.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(345, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Neutral Adjective";
            // 
            // NeuADJ
            // 
            this.NeuADJ.Location = new System.Drawing.Point(348, 160);
            this.NeuADJ.Name = "NeuADJ";
            this.NeuADJ.Size = new System.Drawing.Size(100, 20);
            this.NeuADJ.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(345, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Neutral DEF";
            // 
            // NeuDEF
            // 
            this.NeuDEF.Location = new System.Drawing.Point(348, 121);
            this.NeuDEF.Name = "NeuDEF";
            this.NeuDEF.Size = new System.Drawing.Size(100, 20);
            this.NeuDEF.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(345, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 48;
            this.label16.Text = "Neutral name";
            // 
            // NeuName
            // 
            this.NeuName.Location = new System.Drawing.Point(348, 82);
            this.NeuName.Name = "NeuName";
            this.NeuName.Size = new System.Drawing.Size(100, 20);
            this.NeuName.TabIndex = 47;
            // 
            // localizationText
            // 
            this.localizationText.Location = new System.Drawing.Point(9, 192);
            this.localizationText.Name = "localizationText";
            this.localizationText.Size = new System.Drawing.Size(439, 231);
            this.localizationText.TabIndex = 53;
            this.localizationText.Text = "";
            // 
            // addLocalizationButton
            // 
            this.addLocalizationButton.Location = new System.Drawing.Point(9, 429);
            this.addLocalizationButton.Name = "addLocalizationButton";
            this.addLocalizationButton.Size = new System.Drawing.Size(142, 23);
            this.addLocalizationButton.TabIndex = 54;
            this.addLocalizationButton.Text = "Generate localization";
            this.addLocalizationButton.UseVisualStyleBackColor = true;
            this.addLocalizationButton.Click += new System.EventHandler(this.addLocalizationButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 8);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 499);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.textboxHexColor);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.colorConfirmation);
            this.tabPage1.Controls.Add(this.middleEastCheck);
            this.tabPage1.Controls.Add(this.southAmericanCheck);
            this.tabPage1.Controls.Add(this.numBlue);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.africanCheck);
            this.tabPage1.Controls.Add(this.asianCheck);
            this.tabPage1.Controls.Add(this.numGreen);
            this.tabPage1.Controls.Add(this.labelCurrentColor);
            this.tabPage1.Controls.Add(this.commonwealthCheck);
            this.tabPage1.Controls.Add(this.eastEuroCheck);
            this.tabPage1.Controls.Add(this.numRed);
            this.tabPage1.Controls.Add(this.generatecountryTXTFile);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.colorSliderVertical1);
            this.tabPage1.Controls.Add(this.colorBox2D1);
            this.tabPage1.Controls.Add(this.westEuroCheck);
            this.tabPage1.Controls.Add(this.countryCode);
            this.tabPage1.Controls.Add(this.countryName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nation Color/Culture";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(391, 384);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "Blue";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(331, 384);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Green";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(271, 384);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Red";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(208, 304);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Color";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearLocalizationbutton);
            this.tabPage2.Controls.Add(this.exportLocalization);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.countryLocalTag);
            this.tabPage2.Controls.Add(this.addLocalizationButton);
            this.tabPage2.Controls.Add(this.fascistName);
            this.tabPage2.Controls.Add(this.localizationText);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.fascistDEF);
            this.tabPage2.Controls.Add(this.NeuADJ);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.fascistADJ);
            this.tabPage2.Controls.Add(this.NeuDEF);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.CommName);
            this.tabPage2.Controls.Add(this.NeuName);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.CommDEF);
            this.tabPage2.Controls.Add(this.DemoADJ);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.CommADJ);
            this.tabPage2.Controls.Add(this.DemoDEF);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.DemoName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(479, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Localization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearLocalizationbutton
            // 
            this.clearLocalizationbutton.Location = new System.Drawing.Point(376, 6);
            this.clearLocalizationbutton.Name = "clearLocalizationbutton";
            this.clearLocalizationbutton.Size = new System.Drawing.Size(100, 23);
            this.clearLocalizationbutton.TabIndex = 59;
            this.clearLocalizationbutton.Text = "Clear Localization";
            this.clearLocalizationbutton.UseVisualStyleBackColor = true;
            // 
            // exportLocalization
            // 
            this.exportLocalization.Location = new System.Drawing.Point(306, 429);
            this.exportLocalization.Name = "exportLocalization";
            this.exportLocalization.Size = new System.Drawing.Size(142, 23);
            this.exportLocalization.TabIndex = 56;
            this.exportLocalization.Text = "Export localization";
            this.exportLocalization.UseVisualStyleBackColor = true;
            this.exportLocalization.Click += new System.EventHandler(this.exportLocalization_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.discordLink);
            this.tabPage3.Controls.Add(this.webLink);
            this.tabPage3.Controls.Add(this.createlocalizationButton);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(479, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Debug Stuff";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // discordLink
            // 
            this.discordLink.AutoSize = true;
            this.discordLink.Location = new System.Drawing.Point(330, 34);
            this.discordLink.Name = "discordLink";
            this.discordLink.Size = new System.Drawing.Size(143, 13);
            this.discordLink.TabIndex = 58;
            this.discordLink.TabStop = true;
            this.discordLink.Text = "To Report Bugs Join Discord";
            this.discordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discordLink_LinkClicked);
            // 
            // webLink
            // 
            this.webLink.AutoSize = true;
            this.webLink.Location = new System.Drawing.Point(394, 13);
            this.webLink.Name = "webLink";
            this.webLink.Size = new System.Drawing.Size(79, 13);
            this.webLink.TabIndex = 57;
            this.webLink.TabStop = true;
            this.webLink.Text = "Go To Website";
            this.webLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.webLink_LinkClicked);
            // 
            // createlocalizationButton
            // 
            this.createlocalizationButton.Location = new System.Drawing.Point(9, 29);
            this.createlocalizationButton.Name = "createlocalizationButton";
            this.createlocalizationButton.Size = new System.Drawing.Size(142, 23);
            this.createlocalizationButton.TabIndex = 56;
            this.createlocalizationButton.Text = "Create localization file";
            this.createlocalizationButton.UseVisualStyleBackColor = true;
            this.createlocalizationButton.Click += new System.EventHandler(this.createlocalizationButton_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Under Development";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(431, 506);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "Alpha v.0.0.2";
            // 
            // textboxHexColor
            // 
            this.textboxHexColor.Location = new System.Drawing.Point(271, 337);
            this.textboxHexColor.Name = "textboxHexColor";
            this.textboxHexColor.Size = new System.Drawing.Size(100, 20);
            this.textboxHexColor.TabIndex = 27;
            this.textboxHexColor.TextChanged += new System.EventHandler(this.textboxHexColor_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(268, 321);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Hex";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(268, 371);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 13);
            this.label24.TabIndex = 29;
            this.label24.Text = "RGB";
            // 
            // Hoi4MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 519);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hoi4MainForm";
            this.Text = "Hoi4 Modding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox countryName;
        private System.Windows.Forms.RichTextBox countryCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generatecountryTXTFile;
        private System.Windows.Forms.CheckBox eastEuroCheck;
        private System.Windows.Forms.Label labelCurrentColor;
        private System.Windows.Forms.CheckBox asianCheck;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox southAmericanCheck;
        private System.Windows.Forms.Button colorConfirmation;
        private System.Windows.Forms.CheckBox middleEastCheck;
        private System.Windows.Forms.NumericUpDown numBlue;
        private System.Windows.Forms.CheckBox africanCheck;
        private System.Windows.Forms.NumericUpDown numGreen;
        private System.Windows.Forms.CheckBox commonwealthCheck;
        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.Label label3;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorSliderVertical colorSliderVertical1;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorBox2D colorBox2D1;
        private System.Windows.Forms.CheckBox westEuroCheck;
        private System.Windows.Forms.TextBox countryLocalTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fascistName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fascistDEF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fascistADJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CommADJ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CommDEF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CommName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DemoADJ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DemoDEF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DemoName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox NeuADJ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NeuDEF;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox NeuName;
        private System.Windows.Forms.RichTextBox localizationText;
        private System.Windows.Forms.Button addLocalizationButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button exportLocalization;
        private System.Windows.Forms.Button createlocalizationButton;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button clearLocalizationbutton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel webLink;
        private System.Windows.Forms.LinkLabel discordLink;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textboxHexColor;
    }
}

