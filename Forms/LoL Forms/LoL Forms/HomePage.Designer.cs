namespace LoL_Forms
{
    partial class HomePage
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
            this.Champions = new System.Windows.Forms.Button();
            this.Regions = new System.Windows.Forms.Button();
            this.Stories = new System.Windows.Forms.Button();
            this.AdminLogin = new System.Windows.Forms.Button();
            this.Universes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Champions
            // 
            this.Champions.Location = new System.Drawing.Point(534, 94);
            this.Champions.Name = "Champions";
            this.Champions.Size = new System.Drawing.Size(92, 30);
            this.Champions.TabIndex = 0;
            this.Champions.Text = "Champions";
            this.Champions.UseVisualStyleBackColor = true;
            this.Champions.Click += new System.EventHandler(this.Champions_Click);
            // 
            // Regions
            // 
            this.Regions.Location = new System.Drawing.Point(534, 157);
            this.Regions.Name = "Regions";
            this.Regions.Size = new System.Drawing.Size(92, 30);
            this.Regions.TabIndex = 1;
            this.Regions.Text = "Regions";
            this.Regions.UseVisualStyleBackColor = true;
            this.Regions.Click += new System.EventHandler(this.Regions_Click);
            // 
            // Stories
            // 
            this.Stories.Location = new System.Drawing.Point(534, 220);
            this.Stories.Name = "Stories";
            this.Stories.Size = new System.Drawing.Size(92, 29);
            this.Stories.TabIndex = 2;
            this.Stories.Text = "Stories";
            this.Stories.UseVisualStyleBackColor = true;
            this.Stories.Click += new System.EventHandler(this.Stories_Click);
            // 
            // AdminLogin
            // 
            this.AdminLogin.Location = new System.Drawing.Point(534, 343);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(92, 29);
            this.AdminLogin.TabIndex = 3;
            this.AdminLogin.Text = "Admin Login";
            this.AdminLogin.UseVisualStyleBackColor = true;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // Universes
            // 
            this.Universes.Location = new System.Drawing.Point(534, 274);
            this.Universes.Name = "Universes";
            this.Universes.Size = new System.Drawing.Size(152, 29);
            this.Universes.TabIndex = 4;
            this.Universes.Text = "Alternate Universes";
            this.Universes.UseVisualStyleBackColor = true;
            this.Universes.Click += new System.EventHandler(this.Universes_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Universes);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.Stories);
            this.Controls.Add(this.Regions);
            this.Controls.Add(this.Champions);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Champions;
        private Button Regions;
        private Button Stories;
        private Button AdminLogin;
        private Button Universes;
    }
}