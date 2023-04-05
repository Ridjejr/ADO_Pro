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
    public partial class listeAdherents : Form
    {
        List<Adherent> lesAdherents = new List<Adherent>();
        public listeAdherents()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                lesAdherents = ManagerAdherent.DonneAdherents();
                bsAdherent.DataSource = lesAdherents;
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
            Adherent AdherentSelectionne = new Adherent();
            DataGridViewRow ligne = dgv_listeAdherents.SelectedRows[0];
            AdherentSelectionne = ligne.DataBoundItem as Adherent;
            if (AdherentSelectionne != null)
            {
                FicheAdherent frm = new FicheAdherent(false, AdherentSelectionne);
                frm.ShowDialog();
            }

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Adherent AdherentSelectionne = new Adherent();
            DataGridViewRow ligne = dgv_listeAdherents.SelectedRows[0];
            AdherentSelectionne = ligne.DataBoundItem as Adherent;
            if (AdherentSelectionne != null)
            {
                FicheAdherent frm = new FicheAdherent(true, AdherentSelectionne);
                frm.ShowDialog();
            }
            /*     int element = Convert.ToInt16(dgv_ListeAdherents.SelectedRows[0].Cells[0].Value.ToString());
                   FicheAdherent frm = new FicheAdherent(true, element);
                   frm.Show();
                   RemplirListe();
                   dgv_ListeAdherents.Refresh();     */
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Adherent AdherentSelectionne = new Adherent();
            DataGridViewRow ligne = dgv_listeAdherents.SelectedRows[0];
            AdherentSelectionne = ligne.DataBoundItem as Adherent;

            bool resultat = ManagerAdherent.SupprimerAdherent(AdherentSelectionne);

        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            FicheAdherent frm = new FicheAdherent(true);
            frm.ShowDialog();
        }

    }
}
