namespace LoL_Forms
{
    partial class Selected_Region
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
            this.emblem = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.secret = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emblem)).BeginInit();
            this.SuspendLayout();
            // 
            // emblem
            // 
            this.emblem.Location = new System.Drawing.Point(123, 136);
            this.emblem.Name = "emblem";
            this.emblem.Size = new System.Drawing.Size(125, 120);
            this.emblem.TabIndex = 0;
            this.emblem.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(366, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(67, 30);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            // 
            // secret
            // 
            this.secret.Location = new System.Drawing.Point(481, 159);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(201, 80);
            this.secret.TabIndex = 2;
            this.secret.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secret";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Selected_Region
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secret);
            this.Controls.Add(this.name);
            this.Controls.Add(this.emblem);
            this.Name = "Selected_Region";
            this.Text = "Selected_Region";
            this.Load += new System.EventHandler(this.Selected_Region_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox emblem;
        private Label name;
        private RichTextBox secret;
        private Label label2;
        private Button Back;
    }
}