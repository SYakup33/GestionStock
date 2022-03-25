using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.model;

namespace GestionStock.contrôleur
{
    internal class AnneeExerciceControleur
    {

        public List<AnneeExercice> show()
        {
            return new AnneeExercice().showAll(); 
        }
        public AnneeExercice showById(int id) 
        {
            return new AnneeExercice().showById(id);
        }
        public AnneeExercice add(AnneeExercice anneeExercice)
        {
            return anneeExercice.insertAnneeExercice(anneeExercice);
        }
        public AnneeExercice search(string condition)
        {
            return new AnneeExercice();
        }
        public AnneeExercice edit(AnneeExercice anneeexercice)
        {
            return new AnneeExercice();
        }
    }
}
