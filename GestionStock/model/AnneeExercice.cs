using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.model.repoinstance;
using System.Data.Odbc;
using GestionStock.model;
using GestionStock.contrôleur;

namespace GestionStock.model
{
    internal class AnneeExercice
    {
        public int CodeAE { get; set; }
        public String anneeExercice { get; set; }
        public AnneeExercice() { }

        public AnneeExercice(string anneeExercice)
        {
            this.anneeExercice = anneeExercice;
        }

        public AnneeExercice insertAnneeExercice(AnneeExercice anneeExercice)
        {
            string requete = "INSERT INTO anneeexercice(AnneeExercice) VALUES('" +anneeExercice.anneeExercice + "')";
            DatabaseContext.execute(requete);
            return anneeExercice;           
        }

        public AnneeExercice modify()
        {
            string requete = "UPDATE anneeexercice SET AnneeExercice='" +this.anneeExercice +"' where codeAE '"+ this.CodeAE +"'";
            DatabaseContext.execute(requete);
            return this;
        }

        public List<AnneeExercice> showAll()
        {
            List<AnneeExercice> list = new List<AnneeExercice>();
            string requete = "SELECT CodeAE, AnneeExercice FROM anneeexercice";

            OdbcDataReader resultat = DatabaseContext.executeWithresult(requete);
            if (resultat.Read()) {
                while (resultat.Read())
                {
                    AnneeExercice ae = new AnneeExercice();
                    ae.CodeAE = resultat.GetInt32(0);
                    ae.anneeExercice = resultat.GetDateTime(1).ToString();
                    list.Add(ae);
                }
            }
            DatabaseContext.close();
            return list;
        }

        public AnneeExercice showById(int id)
        {
            AnneeExercice ae = new AnneeExercice();
            string requete = "SELECT *  FROM anneeexercice where CodeAE=" + this.CodeAE + "'";
            OdbcDataReader resultat = DatabaseContext.executeWithresult(requete);

            if(resultat.HasRows && resultat.Read())
            {
                ae.CodeAE = resultat.GetInt32(0);
                ae.anneeExercice = resultat.GetDateTime(1).ToString();
            }
            return ae;
        }
        public int delete(int reference)
        {
            string requete = "DELETE FROM anneeexercice WHERE CodeAE=0 '" + reference + "'";
            return DatabaseContext.execute(requete);
        }
    }
}
