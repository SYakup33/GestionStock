using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using System.Data.Odbc;

namespace GestionStock.model.repoinstance
{
    // cette classe nous permet de récupérer une instance de la base de données
    // a chaque fois que l'on aura besoin d'utiliser notre base de données
    // au lieu de faire des new connection à chaque fois
    public class DatabaseContext
    {
        // odbc -> pour connecter la base de données(dbeaver MySQL) à l'app
        // outils connexion à la base de données
        public static string connectionString = "Dsn=gestion_stock";
        private static OdbcConnection _instance;

        // Constructeur privé, empêche d'instancier notre classe en dehors de ce namespace
        // a la place on va utiliser la méthode getinstance qui s'assurera que l'objet n'existe pas
        private DatabaseContext()
        {
            _instance = new OdbcConnection(connectionString);
        }
        public static OdbcConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new OdbcConnection(connectionString);
            }
            return _instance;

        }
        public static int execute(string query)
        {
            OdbcCommand cmd = new OdbcCommand(query, GetInstance());
            _instance.Open();
            int ret = cmd.ExecuteNonQuery();
            _instance.Close();

            return ret;
        }
        public static OdbcDataReader executeWithresult(string query)
        {
            OdbcCommand cmd = new OdbcCommand(query, GetInstance());
            _instance.Open();

            OdbcDataReader ret = cmd.ExecuteReader();
           //_instance.Close();

            return ret;
        }
        public static void close()
        {
            if(_instance != null)
            {
                 _instance.Close();
            }
        }

    }
}
