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
    public partial class Stories : Form
    {
        public Stories()
        {
            InitializeComponent();
            // Set the form border style to FixedSingle
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable the maximize button
            this.MaximizeBox = false;
            // Disable the minimize button
            //this.MinimizeBox = false;
        }

        private void Stories_Load(object sender, EventArgs e)
        {
            string query = "SELECT title,author,link,type,universe_name FROM Stories";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            // Clear existing items in the dropdown (if any)
            comboBoxStories.Items.Clear();

            // Add retrieved champion names to the dropdown
            while (reader.Read())
            {
                string storieName = reader["title"].ToString();
                comboBoxStories.Items.Add(storieName);
                //Champion champ = new Champion(championName, reader["Gender"].ToString(), reader["region_name"].ToString());
                //allChamps.Add(champ);
            }

            reader.Close();
            Link.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
