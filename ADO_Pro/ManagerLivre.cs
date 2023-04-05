using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Pro
{
    public class ManagerLivre
    {
        public static Livre DonneLivreDuReader(MySqlDataReader monReader)
        {
            Livre unLivre = new Livre();
            unLivre.Num = Convert.ToInt16(monReader["num"]);
            unLivre.Isbn = monReader["isbn"] == DBNull.Value ? "" : monReader["isbn"] as string;
            unLivre.Titre = monReader["titre"] == DBNull.Value ? "" : monReader["titre"] as string;
            unLivre.Prix = monReader["prix"] == DBNull.Value ? "" : monReader["prix"].ToString();
            unLivre.Editeur = monReader["editeur"] == DBNull.Value ? "" : monReader["editeur"] as string;
            unLivre.Annee = monReader["annee"] == DBNull.Value ? "" : monReader["annee"].ToString();
            unLivre.Langue = monReader["langue"] == DBNull.Value ? "" : monReader["langue"] as string;
            return unLivre;
        }

        public static List<Livre> DonneLivres()
        {
            List<Livre> lesLivres = new List<Livre>();
            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "select * from livre order by num";
            monReader = maRequete.ExecuteReader();
            while (monReader.Read())
            {
                Livre unLivre = ManagerLivre.DonneLivreDuReader(monReader);
                lesLivres.Add(unLivre);
            }
            monReader.Close();
            Connection.MaConnection.Close();
            return lesLivres;
        }

        public static Livre DonneLivreParId(int id)
        {
            Livre unLivre = new Livre();
            return unLivre;
        }

        public static bool ModifierLivre(Livre a)
        {
            bool resultat = true;
            return resultat;
        }

        public static bool AjouterLivre(Livre a)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "insert into livre set " +
                "iSBN=@paramISBN, titre=@paramTitre, prix=@paramPrix, editeur=@paramEditeur, " +
                "annee=@paramAnnee, langue=@paramLangue";
            maRequete.Parameters.Clear(); //annule tous les anciens paramètres
            //ajoute les paramètres de la requête de modification
            maRequete.Parameters.AddWithValue("@paramISBN", a.Isbn);
            maRequete.Parameters.AddWithValue("@paramTitre", a.Titre);
            maRequete.Parameters.AddWithValue("@paramPrix", a.Prix);
            maRequete.Parameters.AddWithValue("@paramEditeur", a.Editeur);
            maRequete.Parameters.AddWithValue("@paramAnnee", a.Annee);
            maRequete.Parameters.AddWithValue("@paramLangue", a.Langue);
            maRequete.Parameters.AddWithValue("@paramNum", a.Num);
            try
            {
                Connection.MaConnection.Open();
                int resultat = maRequete.ExecuteNonQuery();
                Connection.MaConnection.Close();
                if (resultat > 0)
                {
                    reponse = true;
                    return reponse;
                }
                else
                {
                    throw new Exception("Une erreur s'est produite, le livre n'a pas été mis a jour.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public static bool SupprimerLivre(Livre a)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from livre where num=@paramNum";
            maRequete.Parameters.Clear(); //annule tous les anciens paramètres
            //supprime les paramètres de la requête de supprimer
            maRequete.Parameters.AddWithValue("@paramNum", a.Num);
            try
            {
                Connection.MaConnection.Open();
                int resultat = maRequete.ExecuteNonQuery();
                Connection.MaConnection.Close();
                if (resultat > 0)
                {
                    reponse = true;
                    return reponse;
                }
                else
                {
                    throw new Exception("Une erreur s'est produite, le livre n'a pas été supprimer.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
