using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Pro
{
    public class Livre
    {
        private int num;
        private string isbn ="";
        private string titre = "";
        private string prix = "";
        private string editeur = "";
        private string annee = "";
        private string langue = "";

        public int Num { get => num; set => num = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Prix { get => prix; set => prix = value; }
        public string Editeur { get => editeur; set => editeur = value; }
        public string Annee { get => annee; set => annee = value; }
        public string Langue { get => langue; set => langue = value; }
    }
}
