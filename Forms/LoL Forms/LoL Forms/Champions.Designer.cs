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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.champImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
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
            this.comboBoxChampions.SelectedIndexChanged += new System.EventHandler(this.comboBoxChampions_SelectedIndexChanged);
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
            this.champImage.Location = new System.Drawing.Point(717, 113);
            this.champImage.Name = "champImage";
            this.champImage.Size = new System.Drawing.Size(360, 378);
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
            this.champDescription.Location = new System.Drawing.Point(42, 271);
            this.champDescription.Name = "champDescription";
            this.champDescription.Size = new System.Drawing.Size(180, 31);
            this.champDescription.TabIndex = 9;
            this.champDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // champName
            // 
            this.champName.Location = new System.Drawing.Point(289, 154);
            this.champName.Name = "champName";
            this.champName.Size = new System.Drawing.Size(185, 25);
            this.champName.TabIndex = 11;
            this.champName.Text = "";
            this.champName.TextChanged += new System.EventHandler(this.champName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Species";
            // 
            // champSpecies
            // 
            this.champSpecies.Location = new System.Drawing.Point(289, 271);
            this.champSpecies.Name = "champSpecies";
            this.champSpecies.Size = new System.Drawing.Size(159, 31);
            this.champSpecies.TabIndex = 14;
            this.champSpecies.Text = "";
            // 
            // champGender
            // 
            this.champGender.Location = new System.Drawing.Point(524, 271);
            this.champGender.Name = "champGender";
            this.champGender.Size = new System.Drawing.Size(148, 31);
            this.champGender.TabIndex = 15;
            this.champGender.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gender";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // champRegion
            // 
            this.champRegion.Location = new System.Drawing.Point(72, 368);
            this.champRegion.Name = "champRegion";
            this.champRegion.Size = new System.Drawing.Size(110, 30);
            this.champRegion.TabIndex = 17;
            this.champRegion.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Region";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // champQuote
            // 
            this.champQuote.Location = new System.Drawing.Point(265, 368);
            this.champQuote.Name = "champQuote";
            this.champQuote.Size = new System.Drawing.Size(194, 73);
            this.champQuote.TabIndex = 19;
            this.champQuote.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Quote";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // champRelease
            // 
            this.champRelease.Location = new System.Drawing.Point(527, 368);
            this.champRelease.Name = "champRelease";
            this.champRelease.Size = new System.Drawing.Size(145, 30);
            this.champRelease.TabIndex = 21;
            this.champRelease.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Release Date";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(855, 53);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 23);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "Reset Fields";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 503);
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
            this.Name = "Form1";
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
    }
}