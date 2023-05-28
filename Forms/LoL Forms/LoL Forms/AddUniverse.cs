﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace LoL_Forms
{
    public partial class AddUniverse : Form
    {
        public AddUniverse()
        {
            InitializeComponent();
        }

        private void AddUniverse_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(Name.Text!=null && SkinLine.Text!=null && YearCreated.Text!=null && ArtLink.Text!=null) {
                string result = null;
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("dbo.AddUniverse", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@name", Name.Text);
                        command.Parameters.AddWithValue("@skinLine", SkinLine.Text);
                        command.Parameters.AddWithValue("@art", ArtLink.Text);
                        command.Parameters.AddWithValue("@yearCreated", YearCreated.Text);
                        

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = reader.GetString(0); // Retrieve the result from the first column
                                if (result == "Universe added successfully")
                                {
                                    MessageBox.Show("Universe added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    AddUniverse manageChampios_page = new AddUniverse();
                                    manageChampios_page.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            reader.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Name.Text = null;
            SkinLine.Text = null;
            YearCreated.Text = null;
            ArtLink.Text = null;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin admin_page = new Admin();
            admin_page.Show();
            this.Hide();
        }
    }
}
