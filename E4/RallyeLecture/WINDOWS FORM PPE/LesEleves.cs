using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WINDOWS_FORM_PPE
{
    class LesEleves
    {
        private List<Eleve> lesEleves;
        public LesEleves()
        {
            lesEleves = new List<Eleve>();
        }
        public void CreateCsvPasswordFile(string nom)
        {
            StreamWriter file = new StreamWriter(nom + ".csv");
            file.WriteLine("login;password");
            for(int i = 0; i < lesEleves.Count; i++)
            {
                file.WriteLine("{0},{1}", lesEleves[i].Login, lesEleves[i].PassWord);
            }
            file.Close();
        }

        public List <Eleve> LoadCsv(PassWordType Type, string nom) // Load le csv
        {
            StreamReader reader = new StreamReader(nom);
            while(!reader.EndOfStream)
            {
                var ligne = reader.ReadLine();
                var espace = ligne.Split(';');
                string login;
                login = espace[0] + espace[1] + "@sio.jjr.fr";
                Eleve unEleve = new Eleve(espace[0], espace[1], login, Type);
                lesEleves.Add(unEleve);

            }
            return lesEleves;
        }


    }
}
