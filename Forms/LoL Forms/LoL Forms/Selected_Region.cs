using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Forms
{
    public partial class Selected_Region : Form
    {   
        private string region_name;
        public Selected_Region(String region)
        {
            
            InitializeComponent();
            region_name = region;
            //changeBackground(region_name);
        }

        private void Selected_Region_Load(object sender, EventArgs e)
        {
            string query = $"SELECT emblem FROM Region WHERE NAME = '{region_name}' ";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                name.Text = region_name;
                emblem.ImageLocation = reader["emblem"].ToString();
                emblem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            reader.Close();
            query = $"SELECT description FROM Secrets WHERE region_name = '{region_name}' ";
            command = new SqlCommand(query, DatabaseConnection.GetConnection());
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                secret.Text = reader["description"].ToString();
            }
            reader.Close();

        }

        private void changeBackground(String region)
        {
            if (region_name == "Bandle City")
            {
                string imageUrl = "https://static.wikia.nocookie.net/leagueoflegends/images/2/2c/05BC194-full.png/revision/latest/scale-to-width-down/1000?cb=20210826012709";
                using (var webClient = new System.Net.WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl); // Download the image data from the cloud

                    using (var stream = new System.IO.MemoryStream(imageData))
                    {
                        // Set the background image of the form
                        this.BackgroundImage = Image.FromStream(stream);
                        stream.Close();
                    }
                    webClient.Dispose();
                    imageData = null;
                }
            }

            //else if (region_name == "Bilgewater")
            //{
            //    Bilgewater.ImageLocation = reader["emblem"].ToString();
            //    Bilgewater.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "Demacia")
            //{
            //    Demacia.ImageLocation = reader["emblem"].ToString();
            //    Demacia.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "Ionia")
            //{
            //    Ionia.ImageLocation = reader["emblem"].ToString();
            //    Ionia.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "Ixtal")
            //{
            //    Ixtal.ImageLocation = reader["emblem"].ToString();
            //    Ixtal.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "Plitover")
            //{
            //    Piltover.ImageLocation = reader["emblem"].ToString();
            //    Piltover.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "Noxus")
            //{
            //    Noxus.ImageLocation = reader["emblem"].ToString();
            //    Noxus.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "Shadow Isles")
            //{
            //    ShadowIsles.ImageLocation = reader["emblem"].ToString();
            //    ShadowIsles.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "Shurima")
            //{
            //    Shurima.ImageLocation = reader["emblem"].ToString();
            //    Shurima.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "Targon")
            //{
            //    Targon.ImageLocation = reader["emblem"].ToString();
            //    Targon.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "Freljord")
            //{
            //    Freljord.ImageLocation = reader["emblem"].ToString();
            //    Freljord.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "The Void")
            //{
            //    Void.ImageLocation = reader["emblem"].ToString();
            //    Void.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //else if (region_name == "Zaun")
            //{
            //    Zaun.ImageLocation = reader["emblem"].ToString();
            //    Zaun.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Regions regions_page = new Regions();
            regions_page.Show();
            this.Hide();
        }
    }
}
