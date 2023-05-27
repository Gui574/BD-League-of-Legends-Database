using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoL_Forms
{
    public partial class Champions : Form
    {


        public Champions()
        {
            InitializeComponent();
            // Set the form border style to FixedSingle
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable the maximize button
            this.MaximizeBox = false;
            // Disable the minimize button
            //this.MinimizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 14); // Set the font size to 14

            champDescription.ReadOnly = true;

            this.BackgroundImage = Image.FromFile("C:/Users/guiml/Downloads/league.jpg");

            // Set the background image layout
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // Establish the database connection


            // Fetch data from the database and bind it to form controls
            LoadChampions();
        }

        private void LoadChampions()
        {
            
            // Query the database to retrieve the champion data
            string query = "SELECT Name FROM Champion";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            // Clear existing items in the dropdown (if any)
            comboBoxChampions.Items.Clear();

            // Add retrieved champion names to the dropdown
            while (reader.Read())
            {
                string championName = reader["Name"].ToString();
                comboBoxChampions.Items.Add(championName);
            }

            reader.Close();
        }

        private void comboBoxChampions_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if(searchChampName.Text == null && comboBoxChampions.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please choose a champion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(!string.IsNullOrEmpty(searchChampName.Text) && comboBoxChampions.SelectedItem != null)
            {
                MessageBox.Show("Please select only 1 champion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(!string.IsNullOrEmpty(searchChampName.Text))
            {
                fillFields(searchChampName.Text);
            }
            else if(comboBoxChampions.SelectedItem != null)
            {
                fillFields(comboBoxChampions.SelectedItem.ToString());

            }
            // Retrieve the selected champion from the dropdown
            

            
        }

        private void fillFields(String selectedChampion)
        {
            

            // Query the database to fetch additional information about the selected champion
            string query = $"SELECT releaseDate,quote,splashArt,region_name, description, Gender, Species FROM Champion WHERE Name = '{selectedChampion}'";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                string splashArtLink = reader["splashArt"].ToString();
                champImage.SizeMode = PictureBoxSizeMode.StretchImage;
                champImage.ImageLocation = splashArtLink;
                champDescription.Text = reader["description"].ToString();
                champName.Text = selectedChampion;
                champGender.Text = reader["Gender"].ToString();
                champSpecies.Text = reader["Species"].ToString();
                champRegion.Text = reader["region_name"].ToString();
                champQuote.Text = reader["quote"].ToString();
                champRelease.Text = reader["releaseDate"].ToString();

            }
            else
            {
                MessageBox.Show("Champion not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void champName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            champImage.ImageLocation = string.Empty;
            champDescription.Text = string.Empty;
            champGender.Text = string.Empty;
            champName.Text = string.Empty;
            champQuote.Text = string.Empty;
            champRegion.Text = string.Empty;
            champRelease.Text = string.Empty;
            champSpecies.Text = string.Empty;

        }
    }
}
