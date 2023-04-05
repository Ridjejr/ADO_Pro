using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADO_Pro
{
    public partial class FicheAuteur : Form
    {
        private int numAuteur;

        Auteur AuteurCourant = new Auteur();
        public FicheAuteur(bool modification, Auteur monAuteur=null)
        {
            InitializeComponent();
            try
            {
                if(monAuteur!=null)
                {
                    AuteurCourant=monAuteur;    
                }
                bs.DataSource = AuteurCourant;

                if(modification==false)
                {
                    textBox3.Enabled = false;
                    textBox2.Enabled = false;
                    textBox1.Enabled = false;
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
                    if (AuteurCourant.Num == 0) //cas d'un ajout
                    {
                        AuteurCourant = bs.Current as Auteur;
                        bool reponse = ManagerAuteur.AjouterAuteur(AuteurCourant);
                    }
                    else // cas d'un modif
                    {
                        AuteurCourant = bs.Current as Auteur;
                        bool reponse = ManagerAuteur.ModifierAuteur(AuteurCourant);
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
            if (textBox3.Text == "")
            {
                MessageBox.Show("Vous devez saisir un nom");
                controle = false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prénom");
                controle = false;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vous devez saisir une nationalité");
                controle = false;
            }
            return controle;
        }

    }
}
