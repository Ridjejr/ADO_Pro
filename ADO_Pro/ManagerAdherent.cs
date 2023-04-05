using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Pro
{
    public class ManagerAdherent
    {
        public static Adherent DonneAdherentDuReader(MySqlDataReader monReader)
        {
            Adherent unAdherent = new Adherent();
            unAdherent.Num = Convert.ToInt16(monReader["num"]);
            unAdherent.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string;
            unAdherent.Prenom = monReader["prenom"] == DBNull.Value ? "" : monReader["prenom"] as string;
            unAdherent.Rue = monReader["adrRue"] == DBNull.Value ? "" : monReader["adrRue"] as string;
            unAdherent.Cp = monReader["adrCP"] == DBNull.Value ? "" : monReader["adrCP"].ToString();
            unAdherent.Ville = monReader["adrVille"] == DBNull.Value ? "" : monReader["adrVille"] as string;
            unAdherent.Tel = monReader["tel"] == DBNull.Value ? "" : monReader["tel"] as string;
            unAdherent.Mail = monReader["mel"] == DBNull.Value ? "" : monReader["mel"] as string;
            return unAdherent;
        }

        public static List<Adherent> DonneAdherents()
        {
            List<Adherent> lesAdherents = new List<Adherent>();
            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "select * from adherent order by num";
            monReader = maRequete.ExecuteReader();
            while (monReader.Read())
            {
                Adherent unAdherent = ManagerAdherent.DonneAdherentDuReader(monReader);
                lesAdherents.Add(unAdherent);
            }
            monReader.Close();
            Connection.MaConnection.Close();
            return lesAdherents;
        }

        public static Adherent DonneAdherentParId(int id)
        {
            Adherent unAdherent = new Adherent();
            return unAdherent;
        }

        public static bool ModifierAdherent(Adherent a)
        {
            bool resultat = true;
            return resultat;
        }

        public static bool AjouterAdherent(Adherent a)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "insert into adherent set " +
                "nom=@paramNom, prenom=@paramPrenom, adrRue=@paramAdrRue, adrCp=@paramAdrCP, " +
                "adrVille=@paramAdrVille, tel=@paramTel, mel=@paramMel";
            maRequete.Parameters.Clear(); //annule tous les anciens paramètres
            //ajoute les paramètres de la requête de modification
            maRequete.Parameters.AddWithValue("@paramNom", a.Nom);
            maRequete.Parameters.AddWithValue("@paramPrenom", a.Prenom);
            maRequete.Parameters.AddWithValue("@paramAdrRue", a.Rue);
            maRequete.Parameters.AddWithValue("@paramAdrCP", a.Cp);
            maRequete.Parameters.AddWithValue("@paramAdrVille", a.Ville);
            maRequete.Parameters.AddWithValue("@paramTel", a.Tel);
            maRequete.Parameters.AddWithValue("@paramMel", a.Mail);
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
                    throw new Exception("Une erreur s'est produite, l'adherent n'a pas été mis a jour.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public static bool SupprimerAdherent(Adherent a)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from adherent where num=@paramNum";
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
                    throw new Exception("Une erreur s'est produite, l'adherent n'a pas été supprimer.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
