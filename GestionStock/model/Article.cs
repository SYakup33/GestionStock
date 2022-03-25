using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.model
{
    internal class Article
    {

        public int tArticlePK { get;}
        public string ArticleNom { get; set; }
        public Fournisseur Fournisseur { get; set; }
        public Categorie Categorie { get; set; }
        public int Seuil_de_reaprovisionnement { get; set; }
        public int PrixUnitaireAchat { get; set; }
        public int PrixUnitaireVente { get; set; }
        public DateTime DateFab { get; set; }
        public DateTime DateExp { get; set; }
    }
}
