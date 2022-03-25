using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.model
{
    internal class Sortie
    {
        public int tSortiesPK { get; set; }
        public int tArticlesFK { get; set; }
        public int SortieQuantite { get; set; }
        public int SortieImputation { get; set; }
        public int CMUP { get; set; }
        public DateTime SortieDate { get; set; }
    }
}
