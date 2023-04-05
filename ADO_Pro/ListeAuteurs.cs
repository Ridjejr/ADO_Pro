using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADO_Pro
{
    public partial class Form_listeAuteur : Form
    {
        List<Auteur> lesAuteurs = new List<Auteur>();
        public Form_listeAuteur()
        {
            InitializeComponent();
            RemplirListe();
        }

        private void RemplirListe()
        {
            try
            {
                lesAuteurs = ManagerAuteur.DonneAuteurs();
                bs.DataSource=lesAuteurs; 


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
            Auteur AuteurSelectionne = new Auteur();
            DataGridViewRow ligne = dgv_ListeAuteurs.SelectedRows[0];
            AuteurSelectionne=ligne.DataBoundItem as Auteur;
            if(AuteurSelectionne!=null)
            {
                FicheAuteur frm = new FicheAuteur(false, AuteurSelectionne);
                frm.ShowDialog();
            }
            
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Auteur AuteurSelectionne = new Auteur();
            DataGridViewRow ligne = dgv_ListeAuteurs.SelectedRows[0];
            AuteurSelectionne = ligne.DataBoundItem as Auteur;
            if (AuteurSelectionne != null)
            {
                FicheAuteur frm = new FicheAuteur(true, AuteurSelectionne);
                frm.ShowDialog();
            }
            /*     int element = Convert.ToInt16(dgv_ListeAuteurs.SelectedRows[0].Cells[0].Value.ToString());
                   FicheAuteur frm = new FicheAuteur(true, element);
                   frm.Show();
                   RemplirListe();
                   dgv_ListeAuteurs.Refresh();     */ 
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Auteur AuteurSelectionne = new Auteur();
            DataGridViewRow ligne = dgv_ListeAuteurs.SelectedRows[0];
            AuteurSelectionne = ligne.DataBoundItem as Auteur;

            bool resultat=ManagerAuteur.SupprimerAuteur(AuteurSelectionne);

        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
                FicheAuteur frm = new FicheAuteur(true);
                frm.ShowDialog();

        }
    }
}
