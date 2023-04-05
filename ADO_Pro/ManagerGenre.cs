using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Pro
{
    public class ManagerGenre
    {
        public static Genre DonneGenreDuReader(MySqlDataReader monReader)
        {
            Genre unGenre = new Genre();
            unGenre.Num = Convert.ToInt16(monReader["num"]);
            unGenre.Libelle = monReader["libelle"] == DBNull.Value ? "" : monReader["libelle"] as string;
            return unGenre;
        }

        public static List<Genre> DonneGenres()
        {
            List<Genre> lesGenres = new List<Genre>();
            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "select * from genre order by num";
            monReader = maRequete.ExecuteReader();
            while (monReader.Read())
            {
                Genre unGenre = ManagerGenre.DonneGenreDuReader(monReader);
                lesGenres.Add(unGenre);
            }
            monReader.Close();
            Connection.MaConnection.Close();
            return lesGenres;
        }

        public static Genre DonneGenreParId(int id)
        {
            Genre unGenre = new Genre();
            return unGenre;
        }

        public static bool ModifierGenre(Genre a)
        {
            bool resultat = true;
            return resultat;
        }

        public static bool AjouterGenre(Genre a)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "insert into genre set " +
                "libelle=@paramLibelle";
            maRequete.Parameters.Clear(); //annule tous les anciens paramètres
            //ajoute les paramètres de la requête de modification
            maRequete.Parameters.AddWithValue("@paramLibelle", a.Libelle);
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
                    throw new Exception("Une erreur s'est produite, le Genre n'a pas été mis a jour.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public static bool SupprimerGenre(Genre a)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from genre where num=@paramNum";
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
                    throw new Exception("Une erreur s'est produite, le Genre n'a pas été supprimer.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
