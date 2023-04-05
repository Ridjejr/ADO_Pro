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
    public partial class FicheAdherent : Form
    {
        private int numAdherent;

        Adherent AdherentCourant = new Adherent();
        public FicheAdherent(bool modification, Adherent monAdherent = null)
        {
            InitializeComponent();
            try
            {
                if (monAdherent != null)
                {
                    AdherentCourant = monAdherent;
                }
                bsAdherent.DataSource = AdherentCourant;

                if (modification == false)
                {
                    text_Nom.Enabled = false;
                    text_Prenom.Enabled = false;
                    text_Rue.Enabled = false;
                    text_Cp.Enabled = false;
                    text_Ville.Enabled = false;
                    text_Tel.Enabled = false;
                    text_Mail.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btn_Anuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControleSaisies() == true)
                {
                    if (AdherentCourant.Num == 0) //cas d'un ajout
                    {
                        AdherentCourant = bsAdherent.Current as Adherent;
                        bool reponse = ManagerAdherent.AjouterAdherent(AdherentCourant);
                    }
                    else // cas d'un modif
                    {
                        AdherentCourant = bsAdherent.Current as Adherent;
                        bool reponse = ManagerAdherent.ModifierAdherent(AdherentCourant);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ControleSaisies()
        {
            bool controle = true;
            if (text_Nom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un nom");
                controle = false;
            }
            if (text_Prenom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prenom");
                controle = false;
            }
            if (text_Rue.Text == "")
            {
                MessageBox.Show("Vous devez saisir une rue");
                controle = false;
            }
            if (text_Cp.Text == "")
            {
                MessageBox.Show("Vous devez saisir un code postale");
                controle = false;
            }
            if (text_Ville.Text == "")
            {
                MessageBox.Show("Vous devez saisir une ville");
                controle = false;
            }
            if (text_Tel.Text == "")
            {
                MessageBox.Show("Vous devez saisir un téléphone");
                controle = false;
            }
            if (text_Mail.Text == "")
            {
                MessageBox.Show("Vous devez saisir un mail");
                controle = false;
            }
            return controle;
        }

    }
}
