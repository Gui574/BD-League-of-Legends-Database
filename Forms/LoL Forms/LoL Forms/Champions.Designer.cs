namespace LoL_Forms
{
    partial class Champions
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChampions = new System.Windows.Forms.ComboBox();
            this.searchChampName = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.champImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.champDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.champName = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.champSpecies = new System.Windows.Forms.RichTextBox();
            this.champGender = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.champRegion = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.champQuote = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.champRelease = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.Female = new System.Windows.Forms.CheckBox();
            this.Male = new System.Windows.Forms.CheckBox();
            this.Zaun = new System.Windows.Forms.CheckBox();
            this.Void = new System.Windows.Forms.CheckBox();
            this.Freljord = new System.Windows.Forms.CheckBox();
            this.Targon = new System.Windows.Forms.CheckBox();
            this.Shurima = new System.Windows.Forms.CheckBox();
            this.ShadowIsles = new System.Windows.Forms.CheckBox();
            this.Noxus = new System.Windows.Forms.CheckBox();
            this.Piltover = new System.Windows.Forms.CheckBox();
            this.Ixtal = new System.Windows.Forms.CheckBox();
            this.Ionia = new System.Windows.Forms.CheckBox();
            this.Demacia = new System.Windows.Forms.CheckBox();
            this.Bilgewater = new System.Windows.Forms.CheckBox();
            this.BandleCity = new System.Windows.Forms.CheckBox();
            this.QDesc = new System.Windows.Forms.RichTextBox();
            this.WDesc = new System.Windows.Forms.RichTextBox();
            this.EDesc = new System.Windows.Forms.RichTextBox();
            this.RDesc = new System.Windows.Forms.RichTextBox();
            this.PDesc = new System.Windows.Forms.RichTextBox();
            this.QName = new System.Windows.Forms.TextBox();
            this.WName = new System.Windows.Forms.TextBox();
            this.EName = new System.Windows.Forms.TextBox();
            this.RName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.champImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(464, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Champion Info";
            // 
            // comboBoxChampions
            // 
            this.comboBoxChampions.FormattingEnabled = true;
            this.comboBoxChampions.Location = new System.Drawing.Point(527, 52);
            this.comboBoxChampions.Name = "comboBoxChampions";
            this.comboBoxChampions.Size = new System.Drawing.Size(121, 23);
            this.comboBoxChampions.TabIndex = 1;
            // 
            // searchChampName
            // 
            this.searchChampName.Location = new System.Drawing.Point(289, 53);
            this.searchChampName.Name = "searchChampName";
            this.searchChampName.Size = new System.Drawing.Size(100, 23);
            this.searchChampName.TabIndex = 2;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(717, 52);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(95, 23);
            this.runButton.TabIndex = 5;
            this.runButton.Text = "Search";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // champImage
            // 
            this.champImage.Location = new System.Drawing.Point(702, 253);
            this.champImage.Name = "champImage";
            this.champImage.Size = new System.Drawing.Size(513, 305);
            this.champImage.TabIndex = 6;
            this.champImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Or";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // champDescription
            // 
            this.champDescription.Location = new System.Drawing.Point(265, 150);
            this.champDescription.Name = "champDescription";
            this.champDescription.Size = new System.Drawing.Size(180, 31);
            this.champDescription.TabIndex = 9;
            this.champDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // champName
            // 
            this.champName.Location = new System.Drawing.Point(20, 154);
            this.champName.Name = "champName";
            this.champName.Size = new System.Drawing.Size(185, 25);
            this.champName.TabIndex = 11;
            this.champName.Text = "";
            this.champName.TextChanged += new System.EventHandler(this.champName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Species";
            // 
            // champSpecies
            // 
            this.champSpecies.Location = new System.Drawing.Point(503, 148);
            this.champSpecies.Name = "champSpecies";
            this.champSpecies.Size = new System.Drawing.Size(159, 31);
            this.champSpecies.TabIndex = 14;
            this.champSpecies.Text = "";
            // 
            // champGender
            // 
            this.champGender.Location = new System.Drawing.Point(34, 224);
            this.champGender.Name = "champGender";
            this.champGender.Size = new System.Drawing.Size(148, 31);
            this.champGender.TabIndex = 15;
            this.champGender.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gender";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // champRegion
            // 
            this.champRegion.Location = new System.Drawing.Point(289, 225);
            this.champRegion.Name = "champRegion";
            this.champRegion.Size = new System.Drawing.Size(134, 30);
            this.champRegion.TabIndex = 17;
            this.champRegion.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Region";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // champQuote
            // 
            this.champQuote.Location = new System.Drawing.Point(727, 162);
            this.champQuote.Name = "champQuote";
            this.champQuote.Size = new System.Drawing.Size(194, 73);
            this.champQuote.TabIndex = 19;
            this.champQuote.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(805, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Quote";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // champRelease
            // 
            this.champRelease.Location = new System.Drawing.Point(517, 235);
            this.champRelease.Name = "champRelease";
            this.champRelease.Size = new System.Drawing.Size(145, 30);
            this.champRelease.TabIndex = 21;
            this.champRelease.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Release Date";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(855, 51);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 23);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "Reset Fields";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(997, 12);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(64, 19);
            this.Female.TabIndex = 42;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(1119, 12);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(52, 19);
            this.Male.TabIndex = 43;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Zaun
            // 
            this.Zaun.AutoSize = true;
            this.Zaun.Location = new System.Drawing.Point(1119, 87);
            this.Zaun.Name = "Zaun";
            this.Zaun.Size = new System.Drawing.Size(53, 19);
            this.Zaun.TabIndex = 44;
            this.Zaun.Text = "Zaun";
            this.Zaun.UseVisualStyleBackColor = true;
            this.Zaun.CheckedChanged += new System.EventHandler(this.Zaun_CheckedChanged);
            // 
            // Void
            // 
            this.Void.AutoSize = true;
            this.Void.Location = new System.Drawing.Point(997, 187);
            this.Void.Name = "Void";
            this.Void.Size = new System.Drawing.Size(49, 19);
            this.Void.TabIndex = 45;
            this.Void.Text = "Void";
            this.Void.UseVisualStyleBackColor = true;
            this.Void.CheckedChanged += new System.EventHandler(this.Void_CheckedChanged);
            // 
            // Freljord
            // 
            this.Freljord.AutoSize = true;
            this.Freljord.Location = new System.Drawing.Point(1119, 162);
            this.Freljord.Name = "Freljord";
            this.Freljord.Size = new System.Drawing.Size(66, 19);
            this.Freljord.TabIndex = 46;
            this.Freljord.Text = "Freljord";
            this.Freljord.UseVisualStyleBackColor = true;
            this.Freljord.CheckedChanged += new System.EventHandler(this.Freljord_CheckedChanged);
            // 
            // Targon
            // 
            this.Targon.AutoSize = true;
            this.Targon.Location = new System.Drawing.Point(1119, 137);
            this.Targon.Name = "Targon";
            this.Targon.Size = new System.Drawing.Size(62, 19);
            this.Targon.TabIndex = 47;
            this.Targon.Text = "Targon";
            this.Targon.UseVisualStyleBackColor = true;
            this.Targon.CheckedChanged += new System.EventHandler(this.Targon_CheckedChanged);
            // 
            // Shurima
            // 
            this.Shurima.AutoSize = true;
            this.Shurima.Location = new System.Drawing.Point(997, 137);
            this.Shurima.Name = "Shurima";
            this.Shurima.Size = new System.Drawing.Size(70, 19);
            this.Shurima.TabIndex = 48;
            this.Shurima.Text = "Shurima";
            this.Shurima.UseVisualStyleBackColor = true;
            this.Shurima.CheckedChanged += new System.EventHandler(this.Shurima_CheckedChanged);
            // 
            // ShadowIsles
            // 
            this.ShadowIsles.AutoSize = true;
            this.ShadowIsles.Location = new System.Drawing.Point(1119, 112);
            this.ShadowIsles.Name = "ShadowIsles";
            this.ShadowIsles.Size = new System.Drawing.Size(90, 19);
            this.ShadowIsles.TabIndex = 49;
            this.ShadowIsles.Text = "ShadowIsles";
            this.ShadowIsles.UseVisualStyleBackColor = true;
            this.ShadowIsles.CheckedChanged += new System.EventHandler(this.ShadowIsles_CheckedChanged);
            // 
            // Noxus
            // 
            this.Noxus.AutoSize = true;
            this.Noxus.Location = new System.Drawing.Point(997, 62);
            this.Noxus.Name = "Noxus";
            this.Noxus.Size = new System.Drawing.Size(60, 19);
            this.Noxus.TabIndex = 50;
            this.Noxus.Text = "Noxus";
            this.Noxus.UseVisualStyleBackColor = true;
            this.Noxus.CheckedChanged += new System.EventHandler(this.Noxus_CheckedChanged);
            // 
            // Piltover
            // 
            this.Piltover.AutoSize = true;
            this.Piltover.Location = new System.Drawing.Point(997, 162);
            this.Piltover.Name = "Piltover";
            this.Piltover.Size = new System.Drawing.Size(66, 19);
            this.Piltover.TabIndex = 51;
            this.Piltover.Text = "Piltover";
            this.Piltover.UseVisualStyleBackColor = true;
            this.Piltover.CheckedChanged += new System.EventHandler(this.Piltover_CheckedChanged);
            // 
            // Ixtal
            // 
            this.Ixtal.AutoSize = true;
            this.Ixtal.Location = new System.Drawing.Point(997, 112);
            this.Ixtal.Name = "Ixtal";
            this.Ixtal.Size = new System.Drawing.Size(48, 19);
            this.Ixtal.TabIndex = 52;
            this.Ixtal.Text = "Ixtal";
            this.Ixtal.UseVisualStyleBackColor = true;
            this.Ixtal.CheckedChanged += new System.EventHandler(this.Ixtal_CheckedChanged);
            // 
            // Ionia
            // 
            this.Ionia.AutoSize = true;
            this.Ionia.Location = new System.Drawing.Point(997, 87);
            this.Ionia.Name = "Ionia";
            this.Ionia.Size = new System.Drawing.Size(52, 19);
            this.Ionia.TabIndex = 53;
            this.Ionia.Text = "Ionia";
            this.Ionia.UseVisualStyleBackColor = true;
            this.Ionia.CheckedChanged += new System.EventHandler(this.Ionia_CheckedChanged);
            // 
            // Demacia
            // 
            this.Demacia.AutoSize = true;
            this.Demacia.Location = new System.Drawing.Point(1119, 62);
            this.Demacia.Name = "Demacia";
            this.Demacia.Size = new System.Drawing.Size(72, 19);
            this.Demacia.TabIndex = 54;
            this.Demacia.Text = "Demacia";
            this.Demacia.UseVisualStyleBackColor = true;
            this.Demacia.CheckedChanged += new System.EventHandler(this.Demacia_CheckedChanged);
            // 
            // Bilgewater
            // 
            this.Bilgewater.AutoSize = true;
            this.Bilgewater.Location = new System.Drawing.Point(1119, 37);
            this.Bilgewater.Name = "Bilgewater";
            this.Bilgewater.Size = new System.Drawing.Size(81, 19);
            this.Bilgewater.TabIndex = 55;
            this.Bilgewater.Text = "Bilgewater";
            this.Bilgewater.UseVisualStyleBackColor = true;
            this.Bilgewater.CheckedChanged += new System.EventHandler(this.Bilgewater_CheckedChanged);
            // 
            // BandleCity
            // 
            this.BandleCity.AutoSize = true;
            this.BandleCity.Location = new System.Drawing.Point(997, 37);
            this.BandleCity.Name = "BandleCity";
            this.BandleCity.Size = new System.Drawing.Size(83, 19);
            this.BandleCity.TabIndex = 56;
            this.BandleCity.Text = "BandleCity";
            this.BandleCity.UseVisualStyleBackColor = true;
            this.BandleCity.CheckedChanged += new System.EventHandler(this.BandleCity_CheckedChanged);
            // 
            // QDesc
            // 
            this.QDesc.Location = new System.Drawing.Point(20, 348);
            this.QDesc.Name = "QDesc";
            this.QDesc.Size = new System.Drawing.Size(139, 84);
            this.QDesc.TabIndex = 57;
            this.QDesc.Text = "";
            // 
            // WDesc
            // 
            this.WDesc.Location = new System.Drawing.Point(194, 348);
            this.WDesc.Name = "WDesc";
            this.WDesc.Size = new System.Drawing.Size(139, 84);
            this.WDesc.TabIndex = 58;
            this.WDesc.Text = "";
            // 
            // EDesc
            // 
            this.EDesc.Location = new System.Drawing.Point(368, 348);
            this.EDesc.Name = "EDesc";
            this.EDesc.Size = new System.Drawing.Size(139, 84);
            this.EDesc.TabIndex = 59;
            this.EDesc.Text = "";
            // 
            // RDesc
            // 
            this.RDesc.Location = new System.Drawing.Point(540, 348);
            this.RDesc.Name = "RDesc";
            this.RDesc.Size = new System.Drawing.Size(139, 84);
            this.RDesc.TabIndex = 60;
            this.RDesc.Text = "";
            // 
            // PDesc
            // 
            this.PDesc.Location = new System.Drawing.Point(252, 491);
            this.PDesc.Name = "PDesc";
            this.PDesc.Size = new System.Drawing.Size(224, 96);
            this.PDesc.TabIndex = 61;
            this.PDesc.Text = "";
            // 
            // QName
            // 
            this.QName.Location = new System.Drawing.Point(37, 319);
            this.QName.Name = "QName";
            this.QName.Size = new System.Drawing.Size(100, 23);
            this.QName.TabIndex = 62;
            // 
            // WName
            // 
            this.WName.Location = new System.Drawing.Point(217, 319);
            this.WName.Name = "WName";
            this.WName.Size = new System.Drawing.Size(100, 23);
            this.WName.TabIndex = 63;
            // 
            // EName
            // 
            this.EName.Location = new System.Drawing.Point(392, 319);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(100, 23);
            this.EName.TabIndex = 64;
            // 
            // RName
            // 
            this.RName.Location = new System.Drawing.Point(562, 319);
            this.RName.Name = "RName";
            this.RName.Size = new System.Drawing.Size(100, 23);
            this.RName.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(334, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 66;
            this.label11.Text = "Abilities";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 15);
            this.label12.TabIndex = 67;
            this.label12.Text = "Q";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(607, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 68;
            this.label13.Text = "R";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(351, 444);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 69;
            this.label14.Text = "Passive";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(432, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 70;
            this.label15.Text = "E";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(252, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 15);
            this.label16.TabIndex = 71;
            this.label16.Text = "W";
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(323, 462);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(100, 23);
            this.PName.TabIndex = 72;
            // 
            // Champions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 599);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RName);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.WName);
            this.Controls.Add(this.QName);
            this.Controls.Add(this.PDesc);
            this.Controls.Add(this.RDesc);
            this.Controls.Add(this.EDesc);
            this.Controls.Add(this.WDesc);
            this.Controls.Add(this.QDesc);
            this.Controls.Add(this.BandleCity);
            this.Controls.Add(this.Bilgewater);
            this.Controls.Add(this.Demacia);
            this.Controls.Add(this.Ionia);
            this.Controls.Add(this.Ixtal);
            this.Controls.Add(this.Piltover);
            this.Controls.Add(this.Noxus);
            this.Controls.Add(this.ShadowIsles);
            this.Controls.Add(this.Shurima);
            this.Controls.Add(this.Targon);
            this.Controls.Add(this.Freljord);
            this.Controls.Add(this.Void);
            this.Controls.Add(this.Zaun);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.champRelease);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.champQuote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.champRegion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.champGender);
            this.Controls.Add(this.champSpecies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.champName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.champDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.champImage);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.searchChampName);
            this.Controls.Add(this.comboBoxChampions);
            this.Controls.Add(this.label1);
            this.Name = "Champions";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.champImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxChampions;
        private TextBox searchChampName;
        private Button runButton;
        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox champImage;
        private Label label2;
        private Label label3;
        private RichTextBox champDescription;
        private Label label4;
        private Label label6;
        private Label label5;
        private RichTextBox champName;
        private RichTextBox champGender;
        private RichTextBox champSpecies;
        private Label label7;
        private Label label8;
        private RichTextBox champRegion;
        private Label label9;
        private RichTextBox champQuote;
        private Label label10;
        private RichTextBox champRelease;
        private Button resetButton;
        private CheckBox Male;
        private CheckBox Female;
        private CheckBox BandleCity;
        private CheckBox Bilgewater;
        private CheckBox Demacia;
        private CheckBox Ionia;
        private CheckBox Ixtal;
        private CheckBox Piltover;
        private CheckBox Noxus;
        private CheckBox ShadowIsles;
        private CheckBox Shurima;
        private CheckBox Targon;
        private CheckBox Freljord;
        private CheckBox Void;
        private CheckBox Zaun;
        private RichTextBox EDesc;
        private RichTextBox WDesc;
        private RichTextBox QDesc;
        private RichTextBox RDesc;
        private RichTextBox PDesc;
        private TextBox QName;
        private Label label11;
        private TextBox RName;
        private TextBox EName;
        private TextBox WName;
        private TextBox PName;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}