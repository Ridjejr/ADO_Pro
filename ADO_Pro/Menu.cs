using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADO_Pro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void auteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_listeAuteur frm = new Form_listeAuteur();
            frm.Show();
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeGenres frm = new ListeGenres();
            frm.Show();
        }

        private void adherentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listeAdherents frm = new listeAdherents();
            frm.Show();
        }

        private void livresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeLivres frm = new ListeLivres();
            frm.Show();
        }
    }
}
