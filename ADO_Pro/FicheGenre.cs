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
    public partial class FicheGenre : Form
    {
        private int numGenre;

        Genre GenreCourant = new Genre();
        public FicheGenre(bool modification, Genre monGenre = null)
        {
            InitializeComponent();
            try
            {
                if (monGenre != null)
                {
                    GenreCourant = monGenre;
                }
                bsGenre.DataSource = GenreCourant;

                if (modification == false)
                {
                    textBox3.Enabled = false;
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
                    if (GenreCourant.Num == 0) //cas d'un ajout
                    {
                        GenreCourant = bsGenre.Current as Genre;
                        bool reponse = ManagerGenre.AjouterGenre(GenreCourant);
                    }
                    else // cas d'un modif
                    {
                        GenreCourant = bsGenre.Current as Genre;
                        bool reponse = ManagerGenre.ModifierGenre(GenreCourant);
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
                MessageBox.Show("Vous devez saisir un libelle");
                controle = false;
            }
            return controle;
        }

    }
}
