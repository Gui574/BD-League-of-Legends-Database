namespace LoL_Forms
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewAdmin = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.AddChamp = new System.Windows.Forms.Button();
            this.DeleteChamp = new System.Windows.Forms.Button();
            this.DeleteRegion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(322, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Page";
            // 
            // NewAdmin
            // 
            this.NewAdmin.Location = new System.Drawing.Point(136, 96);
            this.NewAdmin.Name = "NewAdmin";
            this.NewAdmin.Size = new System.Drawing.Size(153, 35);
            this.NewAdmin.TabIndex = 1;
            this.NewAdmin.Text = "Create new Admin";
            this.NewAdmin.UseVisualStyleBackColor = true;
            this.NewAdmin.Click += new System.EventHandler(this.NewAdmin_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddChamp
            // 
            this.AddChamp.Location = new System.Drawing.Point(136, 173);
            this.AddChamp.Name = "AddChamp";
            this.AddChamp.Size = new System.Drawing.Size(153, 35);
            this.AddChamp.TabIndex = 3;
            this.AddChamp.Text = "Add new Champion";
            this.AddChamp.UseVisualStyleBackColor = true;
            this.AddChamp.Click += new System.EventHandler(this.AddChamp_Click);
            // 
            // DeleteChamp
            // 
            this.DeleteChamp.Location = new System.Drawing.Point(136, 251);
            this.DeleteChamp.Name = "DeleteChamp";
            this.DeleteChamp.Size = new System.Drawing.Size(153, 35);
            this.DeleteChamp.TabIndex = 4;
            this.DeleteChamp.Text = "Manage Champions";
            this.DeleteChamp.UseVisualStyleBackColor = true;
            this.DeleteChamp.Click += new System.EventHandler(this.DeleteChamp_Click);
            // 
            // DeleteRegion
            // 
            this.DeleteRegion.Location = new System.Drawing.Point(466, 96);
            this.DeleteRegion.Name = "DeleteRegion";
            this.DeleteRegion.Size = new System.Drawing.Size(153, 35);
            this.DeleteRegion.TabIndex = 5;
            this.DeleteRegion.Text = "Manage Region";
            this.DeleteRegion.UseVisualStyleBackColor = true;
            this.DeleteRegion.Click += new System.EventHandler(this.DeleteRegion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Manage Story";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete Universes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteRegion);
            this.Controls.Add(this.DeleteChamp);
            this.Controls.Add(this.AddChamp);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.NewAdmin);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button NewAdmin;
        private Button Back;
        private Button AddChamp;
        private Button DeleteChamp;
        private Button DeleteRegion;
        private Button button1;
        private Button button2;
    }
}