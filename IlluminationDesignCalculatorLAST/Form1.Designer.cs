namespace IlluminationDesignCalculatorLAST
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUnitEnglish = new System.Windows.Forms.RadioButton();
            this.rbUnitMetric = new System.Windows.Forms.RadioButton();
            this.cbLightFixture = new System.Windows.Forms.ComboBox();
            this.cbTypeBuilding = new System.Windows.Forms.ComboBox();
            this.lbI3 = new System.Windows.Forms.Label();
            this.lbI2 = new System.Windows.Forms.Label();
            this.lbI1 = new System.Windows.Forms.Label();
            this.nudIllumination = new System.Windows.Forms.NumericUpDown();
            this.nudLampFixture = new System.Windows.Forms.NumericUpDown();
            this.nudLampLumens = new System.Windows.Forms.NumericUpDown();
            this.cbIlluminationAny = new System.Windows.Forms.ComboBox();
            this.cbIlluminationIndustrial = new System.Windows.Forms.ComboBox();
            this.cbIlluminationCommercial = new System.Windows.Forms.ComboBox();
            this.cbIlluminationResidential = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLuminaires = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.cbWall = new System.Windows.Forms.ComboBox();
            this.cbCeiling = new System.Windows.Forms.ComboBox();
            this.cbMF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lbA2 = new System.Windows.Forms.Label();
            this.lbA3 = new System.Windows.Forms.Label();
            this.lbA4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIllumination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLampFixture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLampLumens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUnitEnglish);
            this.groupBox1.Controls.Add(this.rbUnitMetric);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a Unit System:";
            // 
            // rbUnitEnglish
            // 
            this.rbUnitEnglish.AutoSize = true;
            this.rbUnitEnglish.Checked = true;
            this.rbUnitEnglish.Location = new System.Drawing.Point(194, 19);
            this.rbUnitEnglish.Name = "rbUnitEnglish";
            this.rbUnitEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbUnitEnglish.TabIndex = 1;
            this.rbUnitEnglish.TabStop = true;
            this.rbUnitEnglish.Text = "English";
            this.rbUnitEnglish.UseVisualStyleBackColor = true;
            this.rbUnitEnglish.Click += new System.EventHandler(this.rbUnitEnglish_Click);
            // 
            // rbUnitMetric
            // 
            this.rbUnitMetric.AutoSize = true;
            this.rbUnitMetric.Location = new System.Drawing.Point(70, 19);
            this.rbUnitMetric.Name = "rbUnitMetric";
            this.rbUnitMetric.Size = new System.Drawing.Size(54, 17);
            this.rbUnitMetric.TabIndex = 0;
            this.rbUnitMetric.Text = "Metric";
            this.rbUnitMetric.UseVisualStyleBackColor = true;
            this.rbUnitMetric.Click += new System.EventHandler(this.rbUnitMetric_Click);
            // 
            // cbLightFixture
            // 
            this.cbLightFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLightFixture.FormattingEnabled = true;
            this.cbLightFixture.Items.AddRange(new object[] {
            "Direct: R.L.M. Dome Reflector",
            "Direct: R.L.M. Deep-Bowl Reflector",
            "Direct: Aluminum High-Bay Reflector, Concentrating",
            "Direct: Aluminum High-Bay Reflector, Medium Spread",
            "Direct: Concentrating or Medium, Heavy-Duty Type",
            "Direct: Wide Spread, Heavy-Duty Type",
            "Direct: R.L.M. Glassteel Diffuser",
            "Direct: R.L.M. Silvered Bowl Diffuser",
            "Direct: Wide Spread, Vapor Tight",
            "Enclosed Lens-Plate Distributing Type",
            "Direct: Two 40-Watt Lamps",
            "Direct: Three 40-Watt Lamps",
            "Direct: Two 100-Watt Lamps",
            "Direct: With Louvers, Two 40-Watt Lamps",
            "Direct: Vapor and Dust Tight, Two or Three 40-Watt Lamps",
            "Direct: Three Kw Reflector, One 3,000-Watt Mercury Lamp",
            "Direct: Troffer, Open Type",
            "Direct: Troffer with Louvers, One Lamp",
            "Direct: Troffer with Louvers, Two Lamps",
            "Direct: Troffer with Ribbed-Glass Cover",
            "Direct: With Louvers for 40-Watt Lamps",
            "Direct: Bare Lamp with White Reflecting Surface",
            "Semi-indirect: Glass-Enclosed One 40-watt Lamp ",
            "Semi-indirect: Glass-Enclosed Two 40-Watt Lamps",
            "Semi-indirect: Glass-Enclosed Three 40-Watt Lamps",
            "Semi-indirect: Exposed Lamps ",
            "General Diffuse: Totally Enclosed",
            "Direct-Indirect: Suspension Type Two 40-Watt Lamps",
            "Semi-indirect: Ceiling Type Two 40-Watt Lamps",
            "Direct-Indirect: With Ribbed-Glass Bottom Four 40-Watt Lamps",
            "Semindirect: With Ribbed-Glass Bottom, Ceiling Type 40-Watt Lamps",
            "Direct-Indirect with Louvers Suspension Type Four 40-Watt Lamps",
            "Semindirect: With Louvers, Ceiling Type Four 40-Watt Lamps",
            "Semi-indirect: Totally Enclosed",
            "Semi-indirect: Two 40-Watt Lamps",
            "Indirect: Glass",
            "Indirect: Silvered Bowl",
            "Indirect: Two Lamps"});
            this.cbLightFixture.Location = new System.Drawing.Point(6, 37);
            this.cbLightFixture.Name = "cbLightFixture";
            this.cbLightFixture.Size = new System.Drawing.Size(245, 21);
            this.cbLightFixture.TabIndex = 2;
            this.cbLightFixture.Text = "Lighting Fixture";
            // 
            // cbTypeBuilding
            // 
            this.cbTypeBuilding.FormattingEnabled = true;
            this.cbTypeBuilding.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial",
            "All"});
            this.cbTypeBuilding.Location = new System.Drawing.Point(6, 10);
            this.cbTypeBuilding.Name = "cbTypeBuilding";
            this.cbTypeBuilding.Size = new System.Drawing.Size(245, 21);
            this.cbTypeBuilding.TabIndex = 0;
            this.cbTypeBuilding.Text = "Building Type";
            this.cbTypeBuilding.SelectedIndexChanged += new System.EventHandler(this.cbTypeBuilding_SelectedIndexChanged);
            // 
            // lbI3
            // 
            this.lbI3.AutoSize = true;
            this.lbI3.Location = new System.Drawing.Point(262, 93);
            this.lbI3.Name = "lbI3";
            this.lbI3.Size = new System.Drawing.Size(16, 13);
            this.lbI3.TabIndex = 27;
            this.lbI3.Text = "fc";
            // 
            // lbI2
            // 
            this.lbI2.AutoSize = true;
            this.lbI2.Location = new System.Drawing.Point(261, 37);
            this.lbI2.Name = "lbI2";
            this.lbI2.Size = new System.Drawing.Size(34, 13);
            this.lbI2.TabIndex = 26;
            this.lbI2.Text = "lamps";
            // 
            // lbI1
            // 
            this.lbI1.AutoSize = true;
            this.lbI1.Location = new System.Drawing.Point(261, 11);
            this.lbI1.Name = "lbI1";
            this.lbI1.Size = new System.Drawing.Size(40, 13);
            this.lbI1.TabIndex = 23;
            this.lbI1.Text = "lumens";
            // 
            // nudIllumination
            // 
            this.nudIllumination.DecimalPlaces = 2;
            this.nudIllumination.Location = new System.Drawing.Point(151, 91);
            this.nudIllumination.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudIllumination.Name = "nudIllumination";
            this.nudIllumination.Size = new System.Drawing.Size(100, 20);
            this.nudIllumination.TabIndex = 25;
            this.nudIllumination.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudLampFixture
            // 
            this.nudLampFixture.DecimalPlaces = 2;
            this.nudLampFixture.Location = new System.Drawing.Point(152, 35);
            this.nudLampFixture.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLampFixture.Name = "nudLampFixture";
            this.nudLampFixture.Size = new System.Drawing.Size(100, 20);
            this.nudLampFixture.TabIndex = 24;
            this.nudLampFixture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudLampLumens
            // 
            this.nudLampLumens.DecimalPlaces = 2;
            this.nudLampLumens.Location = new System.Drawing.Point(152, 9);
            this.nudLampLumens.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLampLumens.Name = "nudLampLumens";
            this.nudLampLumens.Size = new System.Drawing.Size(100, 20);
            this.nudLampLumens.TabIndex = 23;
            this.nudLampLumens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbIlluminationAny
            // 
            this.cbIlluminationAny.FormattingEnabled = true;
            this.cbIlluminationAny.Items.AddRange(new object[] {
            "Entrance Hall/Stairways/Stair Landings",
            "Living Room ",
            "Dining Room",
            "Kitchen",
            "Kitchen - Counter/Range/Sink",
            "Bedroom",
            "Bathroom",
            "Bathroom - Mirror",
            "Laundry",
            "Study Table",
            "Task: Accounting and Auditing",
            "Task: Business-machine operation",
            "Task: Transcribing and tabulation",
            "Task: Bookkeeping",
            "Task: Drafting",
            "Task: Designing",
            "Task: Office Work",
            "Conference Room",
            "File Room",
            "Mail Room",
            "Classrooms",
            "Study Halls",
            "Library",
            "Shops",
            "Lecture Rooms",
            "Laboratory",
            "Drafting Room",
            "Gymnasium",
            "Swimming Pool",
            "Auditorium",
            "Cafeteria",
            "Reception Room",
            "Locker Room",
            "Washroom",
            "Corridor",
            "Storeroom",
            "Boilers",
            "Bottle Storage",
            "Bottle Sorting",
            "Cap Washers",
            "Cooling Equipment",
            "Filling and Inspection",
            "Laboratories",
            "Loading Platforms",
            "Pasteurizers",
            "Receiving Room",
            "Separators",
            "Storage Refrigerator",
            "Weighing Room",
            "Office and Stock Room",
            "Task: Detailed Mechanical Work"});
            this.cbIlluminationAny.Location = new System.Drawing.Point(6, 64);
            this.cbIlluminationAny.Name = "cbIlluminationAny";
            this.cbIlluminationAny.Size = new System.Drawing.Size(245, 21);
            this.cbIlluminationAny.TabIndex = 9;
            this.cbIlluminationAny.Text = "Recommended Illumination for Rooms";
            this.cbIlluminationAny.SelectedIndexChanged += new System.EventHandler(this.cbIlluminationAny_SelectedIndexChanged);
            // 
            // cbIlluminationIndustrial
            // 
            this.cbIlluminationIndustrial.FormattingEnabled = true;
            this.cbIlluminationIndustrial.Items.AddRange(new object[] {
            "Boilers",
            "Bottle Storage",
            "Bottle Sorting",
            "Cap Washers",
            "Cooling Equipment",
            "Filling and Inspection",
            "Laboratories",
            "Loading Platforms",
            "Pasteurizers",
            "Receiving Room",
            "Separators",
            "Storage Refrigerator",
            "Weighing Room",
            "Office and Stock Room",
            "Task: Detailed Mechanical Work"});
            this.cbIlluminationIndustrial.Location = new System.Drawing.Point(6, 64);
            this.cbIlluminationIndustrial.Name = "cbIlluminationIndustrial";
            this.cbIlluminationIndustrial.Size = new System.Drawing.Size(245, 21);
            this.cbIlluminationIndustrial.TabIndex = 8;
            this.cbIlluminationIndustrial.Text = "Recommended Illumination for Rooms";
            this.cbIlluminationIndustrial.Visible = false;
            this.cbIlluminationIndustrial.SelectedIndexChanged += new System.EventHandler(this.cbIlluminationIndustrial_SelectedIndexChanged);
            // 
            // cbIlluminationCommercial
            // 
            this.cbIlluminationCommercial.FormattingEnabled = true;
            this.cbIlluminationCommercial.Items.AddRange(new object[] {
            "Task: Accounting and Auditing",
            "Task: Business-machine operation",
            "Task: Transcribing and tabulation",
            "Task: Bookkeeping",
            "Task: Drafting",
            "Task: Designing",
            "Task: Office Work",
            "Conference Room",
            "File Room",
            "Mail Room",
            "Classrooms",
            "Study Halls",
            "Library",
            "Shops",
            "Lecture Rooms",
            "Laboratory",
            "Drafting Room",
            "Gymnasium",
            "Swimming Pool",
            "Auditorium",
            "Cafeteria",
            "Reception Room",
            "Locker Room",
            "Washroom",
            "Corridor",
            "Storeroom"});
            this.cbIlluminationCommercial.Location = new System.Drawing.Point(6, 64);
            this.cbIlluminationCommercial.Name = "cbIlluminationCommercial";
            this.cbIlluminationCommercial.Size = new System.Drawing.Size(245, 21);
            this.cbIlluminationCommercial.TabIndex = 7;
            this.cbIlluminationCommercial.Text = "Recommended Illumination for Rooms";
            this.cbIlluminationCommercial.Visible = false;
            this.cbIlluminationCommercial.SelectedIndexChanged += new System.EventHandler(this.cbIlluminationCommercial_SelectedIndexChanged);
            // 
            // cbIlluminationResidential
            // 
            this.cbIlluminationResidential.FormattingEnabled = true;
            this.cbIlluminationResidential.Items.AddRange(new object[] {
            "Entrance Hall/Stairways/Stair Landings",
            "Living Room ",
            "Dining Room",
            "Kitchen",
            "Kitchen - Counter/Range/Sink",
            "Bedroom",
            "Bathroom",
            "Bathroom - Mirror",
            "Laundry",
            "Study Table"});
            this.cbIlluminationResidential.Location = new System.Drawing.Point(6, 64);
            this.cbIlluminationResidential.Name = "cbIlluminationResidential";
            this.cbIlluminationResidential.Size = new System.Drawing.Size(245, 21);
            this.cbIlluminationResidential.TabIndex = 6;
            this.cbIlluminationResidential.Text = "Recommended Illumination for Rooms";
            this.cbIlluminationResidential.Visible = false;
            this.cbIlluminationResidential.SelectedIndexChanged += new System.EventHandler(this.cbIlluminationResidential_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Maintained Illumination:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lamps per Fixture:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lumens per Lamp:";
            // 
            // tbLuminaires
            // 
            this.tbLuminaires.Location = new System.Drawing.Point(37, 31);
            this.tbLuminaires.Multiline = true;
            this.tbLuminaires.Name = "tbLuminaires";
            this.tbLuminaires.ReadOnly = true;
            this.tbLuminaires.Size = new System.Drawing.Size(250, 20);
            this.tbLuminaires.TabIndex = 10;
            this.tbLuminaires.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Number of Luminaires:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalculate.Location = new System.Drawing.Point(175, 29);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 40);
            this.buttonCalculate.TabIndex = 20;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // cbWall
            // 
            this.cbWall.FormattingEnabled = true;
            this.cbWall.Items.AddRange(new object[] {
            "50%",
            "30%",
            "10%"});
            this.cbWall.Location = new System.Drawing.Point(6, 13);
            this.cbWall.Name = "cbWall";
            this.cbWall.Size = new System.Drawing.Size(121, 21);
            this.cbWall.TabIndex = 20;
            this.cbWall.Text = "Wall Reflectance";
            // 
            // cbCeiling
            // 
            this.cbCeiling.FormattingEnabled = true;
            this.cbCeiling.Items.AddRange(new object[] {
            "70%",
            "50%",
            "30%"});
            this.cbCeiling.Location = new System.Drawing.Point(6, 40);
            this.cbCeiling.Name = "cbCeiling";
            this.cbCeiling.Size = new System.Drawing.Size(121, 21);
            this.cbCeiling.TabIndex = 21;
            this.cbCeiling.Text = "Ceiling Reflectance";
            // 
            // cbMF
            // 
            this.cbMF.FormattingEnabled = true;
            this.cbMF.Items.AddRange(new object[] {
            "Good",
            "Average",
            "Poor"});
            this.cbMF.Location = new System.Drawing.Point(6, 67);
            this.cbMF.Name = "cbMF";
            this.cbMF.Size = new System.Drawing.Size(121, 21);
            this.cbMF.TabIndex = 22;
            this.cbMF.Text = "Room Maintenance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Length:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Width:";
            // 
            // nudWidth
            // 
            this.nudWidth.DecimalPlaces = 2;
            this.nudWidth.Location = new System.Drawing.Point(61, 39);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(190, 20);
            this.nudWidth.TabIndex = 14;
            this.nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudLength
            // 
            this.nudLength.DecimalPlaces = 2;
            this.nudLength.Location = new System.Drawing.Point(61, 13);
            this.nudLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(190, 20);
            this.nudLength.TabIndex = 15;
            this.nudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Height:";
            // 
            // nudHeight
            // 
            this.nudHeight.DecimalPlaces = 2;
            this.nudHeight.Location = new System.Drawing.Point(61, 65);
            this.nudHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(190, 20);
            this.nudHeight.TabIndex = 17;
            this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbA2
            // 
            this.lbA2.AutoSize = true;
            this.lbA2.Location = new System.Drawing.Point(259, 15);
            this.lbA2.Name = "lbA2";
            this.lbA2.Size = new System.Drawing.Size(25, 13);
            this.lbA2.TabIndex = 20;
            this.lbA2.Text = "feet";
            // 
            // lbA3
            // 
            this.lbA3.AutoSize = true;
            this.lbA3.Location = new System.Drawing.Point(259, 41);
            this.lbA3.Name = "lbA3";
            this.lbA3.Size = new System.Drawing.Size(25, 13);
            this.lbA3.TabIndex = 21;
            this.lbA3.Text = "feet";
            // 
            // lbA4
            // 
            this.lbA4.AutoSize = true;
            this.lbA4.Location = new System.Drawing.Point(259, 67);
            this.lbA4.Name = "lbA4";
            this.lbA4.Size = new System.Drawing.Size(25, 13);
            this.lbA4.TabIndex = 22;
            this.lbA4.Text = "feet";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbA4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbA3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbA2);
            this.panel1.Controls.Add(this.nudWidth);
            this.panel1.Controls.Add(this.nudHeight);
            this.panel1.Controls.Add(this.nudLength);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lbI3);
            this.panel2.Controls.Add(this.cbTypeBuilding);
            this.panel2.Controls.Add(this.cbLightFixture);
            this.panel2.Controls.Add(this.cbIlluminationResidential);
            this.panel2.Controls.Add(this.cbIlluminationAny);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nudIllumination);
            this.panel2.Controls.Add(this.cbIlluminationIndustrial);
            this.panel2.Controls.Add(this.cbIlluminationCommercial);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 126);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbI2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbI1);
            this.panel3.Controls.Add(this.nudLampFixture);
            this.panel3.Controls.Add(this.nudLampLumens);
            this.panel3.Location = new System.Drawing.Point(12, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 67);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.tbLuminaires);
            this.panel4.Location = new System.Drawing.Point(12, 479);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 74);
            this.panel4.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cbWall);
            this.panel5.Controls.Add(this.cbCeiling);
            this.panel5.Controls.Add(this.cbMF);
            this.panel5.Controls.Add(this.buttonCalculate);
            this.panel5.Location = new System.Drawing.Point(12, 373);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 100);
            this.panel5.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "help";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 561);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Anime is Trash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIllumination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLampFixture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLampLumens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUnitEnglish;
        private System.Windows.Forms.RadioButton rbUnitMetric;
        private System.Windows.Forms.ComboBox cbLightFixture;
        private System.Windows.Forms.ComboBox cbTypeBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIlluminationResidential;
        private System.Windows.Forms.ComboBox cbIlluminationIndustrial;
        private System.Windows.Forms.ComboBox cbIlluminationCommercial;
        private System.Windows.Forms.ComboBox cbIlluminationAny;
        private System.Windows.Forms.TextBox tbLuminaires;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.NumericUpDown nudLampLumens;
        private System.Windows.Forms.NumericUpDown nudIllumination;
        private System.Windows.Forms.NumericUpDown nudLampFixture;
        private System.Windows.Forms.Label lbI3;
        private System.Windows.Forms.Label lbI2;
        private System.Windows.Forms.Label lbI1;
        private System.Windows.Forms.ComboBox cbWall;
        private System.Windows.Forms.ComboBox cbCeiling;
        private System.Windows.Forms.ComboBox cbMF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lbA2;
        private System.Windows.Forms.Label lbA3;
        private System.Windows.Forms.Label lbA4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
    }
}

