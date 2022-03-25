using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStock.model.repoinstance;
using System.Data.Odbc;

namespace GestionStock.model
{
    internal class Fournisseur
    {
        public int RefFournisseur { get; set; }
        public string NomFournisseur { get; set; }
        public string NomContact { get; set; }
        public string TitreContact { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }

        public string CodePostal { get; set; }
        public string DepartementOuRegion { get; set; }
        public string PaysOuRegion { get; set; }
        public string NumeroTel { get; set; }
        public string Fax { get; set; }
        public int ConditionPaiement { get; set; }
        public string Email { get; set; }
        public string Remarques { get; set; }
        public Fournisseur () { }

        public Fournisseur(string NomFournisseur, string NomContact, string TitreContact, string Adresse, string Ville, string CodePostal, string DepartementOuRegion, string PaysOuRegion, string NumeroTel, string Fax, int ConditionPaiement, string Email, string Remarques)
        {
            this.NomFournisseur = NomFournisseur;
            this.NomContact = NomContact;
            this.TitreContact = TitreContact;
            this.Adresse = Adresse;
            this.Ville = Ville;
            this.CodePostal = CodePostal;
            this.DepartementOuRegion = DepartementOuRegion;
            this.PaysOuRegion = PaysOuRegion;
            this.NumeroTel = NumeroTel;
            this.Fax = Fax;
            this.ConditionPaiement = ConditionPaiement;
            this.Email = Email;
            this.Remarques = Remarques;
        }

        // La méthode ExecuteNonQuery de la classe SqlCommande renvoie le nombre d'enregistrement affectés par la requête
        // alors que ExecuteReader renvoie une collection des enregistrements à la condition de la reqêute

        // Pour récupérer le nombre total d'enregistrement
        public int size()
        {
            string query = "SELECT COUNT(*) FROM Fournisseurs";
            //OdbcConnection conn = DatabaseContext.GetInstance();
            //conn.Open();

            //OdbcCommand cmd = new OdbcCommand(query, conn);
            return DatabaseContext.execute(query);
        }

        public Fournisseur insert(Fournisseur fournisseur)
        {
            string requete = "INSERT INTO fournisseurs (NomFournisseur, NomContact, TitreContact, Adresse, Ville, CodePostal, DepartementOuRegion, PaysOuRegion, NumeroTel, Fax, ConditionPaiement, Email, Remarques) " +
                "VALUES('"+fournisseur.NomFournisseur + "', '" + fournisseur.NomContact + "','" + fournisseur.TitreContact + "' , '" + fournisseur.Adresse + "', '" + fournisseur.Ville + "', '" + fournisseur.CodePostal + "', '" + fournisseur.DepartementOuRegion + "', '" + fournisseur.PaysOuRegion + "', '" + fournisseur.NumeroTel + "', '" + fournisseur.Fax + "', '" + fournisseur.ConditionPaiement + "', '" + fournisseur.Email + "', '" + fournisseur.Remarques + "') ";
            
            DatabaseContext.execute(requete);
            return fournisseur;
        }

        public Fournisseur modify(Fournisseur fournisseur)
        {

            string requete = "UPDATE fournisseurs SET NomFournisseur='" + fournisseur.NomFournisseur + "', NomContact = '" + fournisseur.NomContact + "', TitreContact = '" + fournisseur.TitreContact + "', Adresse = '" + fournisseur.Adresse + "', Ville = '" + fournisseur.Ville + "', CodePostal = '" + fournisseur.CodePostal + "', DepartementOuRegion = '" + fournisseur.DepartementOuRegion + "', PaysOuRegion = '" + fournisseur.PaysOuRegion + "', NumeroTel = '" + fournisseur.NumeroTel + "', Fax = '" + fournisseur.Fax + "', ConditionPaiement = '" + fournisseur.ConditionPaiement + "', Email = '" + fournisseur.Email + "', Remarques = '" + fournisseur.Remarques + "'" + "WHERE RefFournisseur='" + fournisseur.RefFournisseur + "'";

            DatabaseContext.execute(requete);
            return fournisseur;
        }

        // ---------------------------------Supprimer l'enregistrement avec la référence sélectionné
        public int delete(int reference)
        {
            string requete = "DELETE FROM fournisseurs WHERE RefFournisseur = '"+ reference + "'";

            return DatabaseContext.execute(requete);
        }

        public Fournisseur showbyId(int reference)
        {
            Fournisseur fournisseur = new Fournisseur();

            string requete = "SELECT * FROM fournisseurs WHERE RefFournisseur = '" + reference + "'";

            OdbcDataReader resultat = DatabaseContext.executeWithresult(requete);
            
            if(resultat.HasRows)
            {

                fournisseur.RefFournisseur = (int)resultat["RefFournisseur"];
                fournisseur.NomFournisseur = (string)resultat["NomFournisseur"];
                fournisseur.NomContact = (string)resultat["NomContact"];
                fournisseur.TitreContact = (string)resultat["TitreContact"];
                fournisseur.Adresse = (string)resultat["Adresse"];
                fournisseur.Ville = (string)resultat["Ville"];
                fournisseur.CodePostal = (string)resultat["CodePostal"];
                fournisseur.DepartementOuRegion = (string)resultat["DepartementOuRegion"];
                fournisseur.PaysOuRegion = (string)resultat["PaysOuRegion"];
                fournisseur.NumeroTel = (string)resultat["NumeroTel"];
                fournisseur.Fax = (string)resultat["Fax"];
                fournisseur.ConditionPaiement = (int)resultat["ConditionPaiement"];
                fournisseur.Email = (string)resultat["Email"];
                fournisseur.Remarques = (string)resultat["Remarques"];

                // fournisseur.RefFournisseur = resultat.GetInt32(0);
                // fournisseur.NomFournisseur = resultat.GetString(1);
                // fournisseur.NomContact = resultat.GetString(2);
                // fournisseur.TitreContact = resultat.GetString(3);
                // fournisseur.Adresse = resultat.GetString(4);
                // fournisseur.Ville = resultat.GetString(5);
                // fournisseur.CodePostal = resultat.GetString(6);
                // fournisseur.DepartementOuRegion = resultat.GetString(7);
                // fournisseur.PaysOuRegion = resultat.GetString(8);
                // fournisseur.NumeroTel = resultat.GetString(9);
                // fournisseur.Fax = resultat.GetString(10);
                // fournisseur.ConditionPaiement = resultat.GetString(11);
                // fournisseur.Email = resultat.GetString(12);
                // fournisseur.Remarques = resultat.GetString(13);

            }
            return fournisseur;
        }

        public List<Fournisseur> showAll()
        {
            List<Fournisseur> list = new List<Fournisseur>();
            string requete = "SELECT * FROM fournisseurs ";

            OdbcDataReader resultat = DatabaseContext.executeWithresult(requete);

            if (resultat.HasRows)
            {
                while (resultat.Read())
                {
                    Fournisseur fournisseur = new Fournisseur();
                    fournisseur.RefFournisseur = (int)resultat["RefFournisseur"];
                    fournisseur.NomFournisseur = (string)resultat["NomFournisseur"];
                    fournisseur.NomContact = (string)resultat["NomContact"];
                    fournisseur.TitreContact = (string)resultat["TitreContact"];
                    fournisseur.Adresse = (string)resultat["Adresse"];
                    fournisseur.Ville = (string)resultat["Ville"];
                    fournisseur.CodePostal = (string)resultat["CodePostal"];
                    fournisseur.DepartementOuRegion = (string)resultat["DepartementOuRegion"];
                    fournisseur.PaysOuRegion = (string)resultat["PaysOuRegion"];
                    fournisseur.NumeroTel = (string)resultat["NumeroTel"];
                    fournisseur.Fax = (string)resultat["Fax"];
                    fournisseur.ConditionPaiement = (int)resultat["ConditionPaiement"];
                    fournisseur.Email = (string)resultat["Email"];
                    fournisseur.Remarques = (string)resultat["Remarques"];

                    list.Add(fournisseur);
                }
            }
            DatabaseContext.close();
            return list;
        }
    }
}

