using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.model
{
    internal class Entree
    {
        public int tEntreesPK { get; }
        public Article tArticleFK { get; set; }
        public int EntreeQuantite { get; set; }
        public int EntrePU { get; set; }
        public int CMUP { get; set; }
        public DateTime EntreeDate { get; set; }
    }
}
