using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoL_Forms
{
    

    public partial class Champions : Form
    {
        private List<Champion> allChamps = new List<Champion>();
        private Dictionary<CheckBox, string> filterValues = new Dictionary<CheckBox, string>();
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

            //this.BackgroundImage = Image.FromFile("C:/Users/guiml/Downloads/league.jpg");

            // Set the background image layout
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // Establish the database connection

            filterValues.Add(Male, "Male");
            filterValues.Add(Female, "Female");
            filterValues.Add(Noxus, "Noxus");
            filterValues.Add(Ionia, "Ionia");
            filterValues.Add(Ixtal, "Ixtal");
            filterValues.Add(Shurima, "Shurima");
            filterValues.Add(Piltover, "Piltover");
            filterValues.Add(Void, "The Void");
            filterValues.Add(Bilgewater, "Bilgewater");
            filterValues.Add(Demacia, "Demacia");
            filterValues.Add(Zaun, "Zaun");
            filterValues.Add(ShadowIsles, "Shadow Isles");
            filterValues.Add(Targon, "Targon");
            filterValues.Add(Freljord, "The Frejlord");
            filterValues.Add(BandleCity, "Bandle City");

            // Attach the CheckedChanged event handler to each checkbox
            foreach (var checkbox in filterValues)
            {
                checkbox.Key.Click += ExclusiveCheckbox_Click;
                
            }
            // Fetch data from the database and bind it to form controls
            LoadChampions();
        }

        private void LoadChampions()
        {
            
            // Query the database to retrieve the champion data
            string query = "SELECT Name,Gender,region_name FROM Champion";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            // Clear existing items in the dropdown (if any)
            comboBoxChampions.Items.Clear();

            // Add retrieved champion names to the dropdown
            while (reader.Read())
            {
                string championName = reader["Name"].ToString();
                comboBoxChampions.Items.Add(championName);
                Champion champ = new Champion(championName, reader["Gender"].ToString(), reader["region_name"].ToString());
                allChamps.Add(champ);
            }

            reader.Close();
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
            string query = "SELECT releaseDate, quote, splashArt, region_name, description, Gender, Species FROM Champion WHERE Name = @ChampionName";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            command.Parameters.AddWithValue("@ChampionName", selectedChampion);
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

            
            query = $"SELECT P_name,P_description,Q_name,Q_description,W_name,W_description,E_name,E_description,R_name,R_description FROM Abilities WHERE champion_name = @ChampionName";
            command = new SqlCommand(query, DatabaseConnection.GetConnection());
            command.Parameters.AddWithValue("@ChampionName", selectedChampion);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                QDesc.Text = reader["Q_description"].ToString();
                WDesc.Text = reader["W_description"].ToString();
                EDesc.Text = reader["E_description"].ToString();
                RDesc.Text = reader["R_description"].ToString();
                PDesc.Text = reader["P_description"].ToString();
                QName.Text = reader["Q_name"].ToString();
                WName.Text = reader["W_name"].ToString();
                EName.Text = reader["E_name"].ToString();
                RName.Text = reader["R_name"].ToString();
                PName.Text = reader["P_name"].ToString();
            }
            reader.Close();
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
            comboBoxChampions.SelectedItem = null;
            QDesc.Text = string.Empty; 
            QName.Text = string.Empty;
            WDesc.Text = string.Empty;
            WName.Text = string.Empty;
            WDesc.Text = string.Empty;
            EDesc.Text = string.Empty;
            EName.Text = string.Empty;
            RName.Text = string.Empty;
            RDesc.Text = string.Empty;
            PName.Text = string.Empty;
            PDesc.Text = string.Empty;

        }

        private void ApplyFilters()
        {
            List<Champion> filteredChampions = allChamps;

            foreach (var kvp in filterValues)
            {
                CheckBox checkBox = kvp.Key;
                string filterValue = kvp.Value;

                if (checkBox.Checked)
                {
                    if (filterValue == "Male" || filterValue == "Female")
                    {
                        filteredChampions = filteredChampions.Where(c => c.gender == filterValue).ToList();
                    }
                    else
                    {
                        filteredChampions = filteredChampions.Where(c => c.region == filterValue).ToList();
                    }
                }
            }
            comboBoxChampions.Items.Clear();
            foreach (Champion c in filteredChampions)
            {
                comboBoxChampions.Items.Add(c.name);
            }

           
        }
        private void ExclusiveCheckbox_Click(object sender, EventArgs e)
        {
            // Get the checkbox that triggered the event
            CheckBox clickedCheckbox = (CheckBox)sender;

            // Uncheck all other exclusive checkboxes except the clicked one
            foreach (var checkbox in filterValues)
            {
                if (checkbox.Key == clickedCheckbox)
                {
                    checkbox.Key.Checked = true;
                }
                else if(((checkbox.Key == Male || checkbox.Key == Female) && (clickedCheckbox == Male|| clickedCheckbox == Female ) ) || ((checkbox.Key != Male && checkbox.Key != Female) && (clickedCheckbox != Male && clickedCheckbox != Female)))
                {
                    checkbox.Key.Checked = false;
                }
            }
        }


        private void Female_CheckedChanged(object sender, EventArgs e)
        {
           // filterComboBox();
           ApplyFilters();
           
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            //filterComboBox();
            ApplyFilters();
        }

        private void Bilgewater_CheckedChanged(object sender, EventArgs e)
        {
            //filterComboBox();
            ApplyFilters();
        }

        private void Noxus_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Demacia_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Ionia_CheckedChanged(object sender, EventArgs e)
        {
            //filterComboBox();
            ApplyFilters();
        }

        private void Zaun_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Ixtal_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ShadowIsles_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Shurima_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Targon_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Piltover_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Freljord_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void Void_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void BandleCity_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

     
    }




    class Champion
{
    public string name, gender, region;
    public Champion(string n, string g, string r)
    {
        this.name = n;
        this.gender = g;
        this.region = r;
    }
}

}
