using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WINDOWS_FORM_PPE
{
    class TableNiveau
    {
        private MySqlConnection connection;
        private List<Niveau> niveau = new List<Niveau>();
        public List<Niveau> GetAll()
        {
            this.connection = ConnexionMySql.GetConnexion;
            connection.Open();
            MySqlCommand cmdSql = new MySqlCommand();

            cmdSql.Connection = this.connection;
            cmdSql.CommandText = "niveau";
            cmdSql.CommandType = CommandType.TableDirect;

            MySqlDataReader reader = cmdSql.ExecuteReader();
            while (reader.Read())
            {
                niveau.Add(new Niveau(reader.GetInt32(0), reader.GetString(1)));

            }
            this.connection.Close();
            return niveau;
        }
        public void AfficherNiveau()
        {
            Console.WriteLine("Liste des niveaux");
            foreach(Niveau n in niveau)
            {
                Console.WriteLine("{0}", n);
            }
        }
    }
}
