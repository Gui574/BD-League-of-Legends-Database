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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Champions_Click(object sender, EventArgs e)
        {
            Champions champ_page = new Champions();
            champ_page.Show();
            this.Hide();
        }

        private void Regions_Click(object sender, EventArgs e)
        {
            Regions region_page = new Regions();
            region_page.Show();
            this.Hide();
        }
    }
}
