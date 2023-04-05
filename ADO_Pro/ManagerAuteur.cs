using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADO_Pro
{
    public class ManagerAuteur
    {
        public static Auteur DonneAuteurDuReader(MySqlDataReader monReader)
        {
            Auteur unAuteur = new Auteur();
            unAuteur.Num = Convert.ToInt16(monReader["num"]);
            unAuteur.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string;
            unAuteur.Prenom = monReader["prenom"] == DBNull.Value ? "" : monReader["prenom"] as string;
            unAuteur.Nationalite = monReader["nationalite"] == DBNull.Value ? "" : monReader["nationalite"] as string;
            return unAuteur;
        }

        public static List<Auteur> DonneAuteurs()
        {
            List<Auteur> lesAuteurs = new List<Auteur>();
            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "select * from auteur order by nom";
            monReader = maRequete.ExecuteReader();
            while (monReader.Read())
            {
                Auteur unAuteur = ManagerAuteur.DonneAuteurDuReader(monReader);
                lesAuteurs.Add(unAuteur);
            }
            monReader.Close();
            Connection.MaConnection.Close();
            return lesAuteurs;
        }

        public static Auteur DonneAuteurParId(int id)
        {
            Auteur unAuteur = new Auteur();
            return unAuteur;
        }

        public static bool ModifierAuteur(Auteur a)
        {
            bool resultat=true;
            return resultat;
        }

        public static bool AjouterAuteur(Auteur a)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "insert into auteur set " +
                "nom=@paramNom, prenom=@paramPrenom, nationalite=@paramNation ";
            maRequete.Parameters.Clear(); //annule tous les anciens paramètres
            //ajoute les paramètres de la requête de modification
            maRequete.Parameters.AddWithValue("@paramNom", a.Nom);
            maRequete.Parameters.AddWithValue("@paramPrenom", a.Prenom);
            maRequete.Parameters.AddWithValue("@paramNation", a.Nationalite);
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
                    throw new Exception("Une erreur s'est produite, l'auteur n'a pas été mis a jour.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public static bool SupprimerAuteur(Auteur a)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;
            maRequete.CommandText = "delete from auteur where num=@paramNum";
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
                    throw new Exception("Une erreur s'est produite, l'auteur n'a pas été supprimé.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
