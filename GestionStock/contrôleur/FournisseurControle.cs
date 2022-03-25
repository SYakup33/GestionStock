using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.model;

namespace GestionStock.contrôleur
{
    internal class FournisseurControle
    {
        public List<Fournisseur> show()
        {
            return new Fournisseur().showAll();
        }
        public Fournisseur showById(int id)
        {
            return new Fournisseur().showbyId(id);
        }

        public Fournisseur search(string condition)
        {
            return new Fournisseur();
        }
        public Fournisseur add(Fournisseur fournisseur)
        {
            // On demande au modèle de persister (d'enregistrer en base de données) le fournisseur envoyé depuis le formulaire
            return fournisseur.insert(fournisseur);
        }
        public Fournisseur edit(Fournisseur fournisseur) 
        { 
            return new Fournisseur().modify(fournisseur); 
        }
        public bool delete(Fournisseur fournisseur)
        {
            return new Fournisseur().delete(fournisseur.RefFournisseur) == 1;
        }

    }
}
