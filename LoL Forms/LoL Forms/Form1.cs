using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoL_Forms
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Establish the database connection
            string connectionString = "Server=bdadmin.database.windows.net;Database=LoLDatabase;User Id=bdadmin;Password=Password2023;";

            connection = new SqlConnection(connectionString);
            connection.Open();

            // Fetch data from the database and bind it to form controls
            LoadChampions();
        }

        private void LoadChampions()
        {
            // Query the database to retrieve the champion data
            string query = "SELECT Name FROM Champion";
            SqlCommand command = new SqlCommand(query, connection);
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
            // Retrieve the selected champion from the dropdown
            string selectedChampion = comboBoxChampions.SelectedItem.ToString();

            // Query the database to fetch additional information about the selected champion
            string query = $"SELECT Gender, Species FROM Champion WHERE Name = '{selectedChampion}'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Update the form controls with the fetched champion information
                textBoxGender.Text = reader["Gender"].ToString();
                textBoxSpecies.Text = reader["Species"].ToString();
            }

            reader.Close();
        }
    }
}
