    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MySql.Data.MySqlClient;


    namespace WINDOWS_FORM_PPE
{
        class ConnexionMySql
        {
            static private MySqlConnection cnx;
            static public void Connexion(string user, string passWord, string database, string server)
            {
                string scmd = "user=" + user + ";password=" + passWord + ";host=" + server + ";database=" + database;
                ConnexionMySql.cnx = new MySqlConnection(scmd);
            }
            static public MySqlConnection GetConnexion { get { return ConnexionMySql.cnx; } }
        }
    }
