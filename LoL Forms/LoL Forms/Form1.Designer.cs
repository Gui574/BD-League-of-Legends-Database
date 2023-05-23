namespace LoL_Forms
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxSpecies = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Champion";
            // 
            // comboBoxChampions
            // 
            this.comboBoxChampions.FormattingEnabled = true;
            this.comboBoxChampions.Location = new System.Drawing.Point(217, 47);
            this.comboBoxChampions.Name = "comboBoxChampions";
            this.comboBoxChampions.Size = new System.Drawing.Size(121, 23);
            this.comboBoxChampions.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBoxGender.Location = new System.Drawing.Point(58, 170);
            this.textBoxGender.Name = "textBox2";
            this.textBoxGender.Size = new System.Drawing.Size(100, 23);
            this.textBoxGender.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBoxSpecies.Location = new System.Drawing.Point(259, 170);
            this.textBoxSpecies.Name = "textBox3";
            this.textBoxSpecies.Size = new System.Drawing.Size(100, 23);
            this.textBoxSpecies.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSpecies);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxChampions);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxChampions;
        private TextBox textBox1;
        private TextBox textBoxGender;
        private TextBox textBoxSpecies;
    }
}