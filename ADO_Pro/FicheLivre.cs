using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADO_Pro
{
    public partial class FicheLivre : Form
    {
        private int numLivre;

        Livre LivreCourant = new Livre();
        public FicheLivre(bool modification, Livre monLivre = null)
        {
            InitializeComponent();
            try
            {
                if (monLivre != null)
                {
                    LivreCourant = monLivre;
                }
                bsLivre.DataSource = LivreCourant;

                if (modification == false)
                {
                    text_langue.Enabled = false;
                    text_annee.Enabled = false;
                    text_editeur.Enabled = false;
                    text_prix.Enabled = false;
                    text_titre.Enabled = false;
                    text_isbn.Enabled = false;
                    text_num.Enabled = false;
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
                    if (LivreCourant.Num == 0) //cas d'un ajout
                    {
                        LivreCourant = bsLivre.Current as Livre;
                        bool reponse = ManagerLivre.AjouterLivre(LivreCourant);
                    }
                    else // cas d'un modif
                    {
                        LivreCourant = bsLivre.Current as Livre;
                        bool reponse = ManagerLivre.ModifierLivre(LivreCourant);
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
            if (text_isbn.Text == "")
            {
                MessageBox.Show("Vous devez saisir une isbn");
                controle = false;
            }
            if (text_titre.Text == "")
            {
                MessageBox.Show("Vous devez saisir un titre");
                controle = false;
            }
            if (text_prix.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prix");
                controle = false;
            }
            if (text_editeur.Text == "")
            {
                MessageBox.Show("Vous devez saisir un editeur");
                controle = false;
            }
            if (text_annee.Text == "")
            {
                MessageBox.Show("Vous devez saisir une année");
                controle = false;
            }
            if (text_langue.Text == "")
            {
                MessageBox.Show("Vous devez saisir un langue");
                controle = false;
            }
            return controle;
        }

    }
}
