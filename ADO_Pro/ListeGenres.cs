using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Pro
{
    public partial class ListeGenres : Form
    {
        List<Genre> lesGenres = new List<Genre>();
        public ListeGenres()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                lesGenres = ManagerGenre.DonneGenres();
                bsGenre.DataSource = lesGenres;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur :" + ex.Message);
            }
            finally
            {

            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            Genre GenreSelectionne = new Genre();
            DataGridViewRow ligne = dgv_ListeGenres.SelectedRows[0];
            GenreSelectionne = ligne.DataBoundItem as Genre;
            if (GenreSelectionne != null)
            {
                FicheGenre frm = new FicheGenre(false, GenreSelectionne);
                frm.ShowDialog();
            }

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Genre GenreSelectionne = new Genre();
            DataGridViewRow ligne = dgv_ListeGenres.SelectedRows[0];
            GenreSelectionne = ligne.DataBoundItem as Genre;
            if (GenreSelectionne != null)
            {
                FicheGenre frm = new FicheGenre(true, GenreSelectionne);
                frm.ShowDialog();
            }
            /*     int element = Convert.ToInt16(dgv_ListeGenres.SelectedRows[0].Cells[0].Value.ToString());
                   FicheGenre frm = new FicheGenre(true, element);
                   frm.Show();
                   RemplirListe();
                   dgv_ListeGenres.Refresh();     */
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Genre GenreSelectionne = new Genre();
            DataGridViewRow ligne = dgv_ListeGenres.SelectedRows[0];
            GenreSelectionne = ligne.DataBoundItem as Genre;

            bool resultat = ManagerGenre.SupprimerGenre(GenreSelectionne);

        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            FicheGenre frm = new FicheGenre(true);
            frm.ShowDialog();

        }
    }
}

