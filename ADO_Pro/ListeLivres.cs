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
    public partial class ListeLivres : Form
    {
        List<Livre> lesLivres = new List<Livre>();
        public ListeLivres()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                lesLivres = ManagerLivre.DonneLivres();
                bsLivre.DataSource = lesLivres;
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
            Livre LivreSelectionne = new Livre();
            DataGridViewRow ligne = dgv_ListeLivres.SelectedRows[0];
            LivreSelectionne = ligne.DataBoundItem as Livre;
            if (LivreSelectionne != null)
            {
                FicheLivre frm = new FicheLivre(false, LivreSelectionne);
                frm.ShowDialog();
            }

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Livre LivreSelectionne = new Livre();
            DataGridViewRow ligne = dgv_ListeLivres.SelectedRows[0];
            LivreSelectionne = ligne.DataBoundItem as Livre;
            if (LivreSelectionne != null)
            {
                FicheLivre frm = new FicheLivre(true, LivreSelectionne);
                frm.ShowDialog();
            }

        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Livre LivreSelectionne = new Livre();
            DataGridViewRow ligne = dgv_ListeLivres.SelectedRows[0];
            LivreSelectionne = ligne.DataBoundItem as Livre;

            bool resultat = ManagerLivre.SupprimerLivre(LivreSelectionne);

        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            FicheLivre frm = new FicheLivre(true);
            frm.ShowDialog();
        }
    }
}
