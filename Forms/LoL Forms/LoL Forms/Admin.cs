using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void NewAdmin_Click(object sender, EventArgs e)
        {
            CreateAdmin createAdmin_page = new CreateAdmin();
            createAdmin_page.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomePage home_page = new HomePage();
            home_page.Show();
            this.Hide();
        }

        private void AddChamp_Click(object sender, EventArgs e)
        {
            AddChampion addchamp_page = new AddChampion();
            addchamp_page.Show();
            this.Hide();
        }

        private void DeleteChamp_Click(object sender, EventArgs e)
        {
            ManageChampions deletechamp_page = new ManageChampions();
            deletechamp_page.Show();
            this.Hide();
        }

        private void DeleteRegion_Click(object sender, EventArgs e)
        {
            DeleteRegion deleteregion_page = new DeleteRegion();
            deleteregion_page.Show();
            this.Hide();
        }
    }
}
