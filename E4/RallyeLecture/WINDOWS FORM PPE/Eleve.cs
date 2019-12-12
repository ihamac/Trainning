using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace WINDOWS_FORM_PPE
{
    class Eleve
    {
        private string nom;
        private string login;
        private string prenom;
        private string passWord;
        static Random random = new Random();

        public Eleve(string nom, string prenom, string login, PassWordType Type)
        {
            this.nom = nom;
            this.login = login;
            this.prenom = prenom;
            this.passWord = GetNewPassword(Type);
        }

        private string GetNewPassword(PassWordType type)
        {
            throw new NotImplementedException();
        }

        public new string ToString => string.Format("nom : {0} prenom : {1} login : {2} mdp : {3}", this.nom, this.prenom, this.login, this.passWord);
        public string PassWord { get { return passWord; } }
        public string Login { get { return login; } }
        public string Prenom { get { return prenom; } }
        public string Nom { get { return nom; } }
        private static string GetPasswordAleatoire()
        {
            int i = 0;
            string min = "abcdefghijklmnopqrstuvwxyz";
            string maj = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string chiffre = "123456789";
            string special = "@^*$&ù/*×øß";
            string Aleatoire = "";

            int posSpecial;
            int posMaj;
            int posChiffre;
            posSpecial = random.Next(0, 8); // 7
            posMaj = posSpecial; // 7
            posChiffre = posSpecial; // 7

            while (posMaj == posSpecial)
            {
                posMaj = random.Next(0, 8);

            }

            while (posChiffre == posSpecial)
            {
                posChiffre = random.Next(0, 8);
            }

            while (i<9) 
            {
                if (i == posChiffre || i == posMaj || i == posSpecial)
                {
                    if (i == posSpecial || i == posChiffre)
                    {
                        if (i == posChiffre)
                        {
                            Aleatoire += chiffre[random.Next(0, chiffre.Count())];
                        }
                        else
                        {
                            Aleatoire += special[random.Next(0, special.Count())];

                        }
                    }


                    else
                    {
                        Aleatoire += maj[random.Next(0, maj.Count())];

                    }
                }


                else
                {
                    Aleatoire += min[random.Next(0, min.Count())];
                }
                i += 1;
                
                }
            return Aleatoire;
            }
        private string GetPasswordConstruit()
        {
            int compteur = 0;
            string ligne;
            Char virgule = ';';
            System.IO.StreamReader fichier = new System.IO.StreamReader(@"listeEleve.txt");

            while ((ligne = fichier.ReadLine()) != null)
            {
                String[] substrings = ligne.Split(virgule);
                Console.Write(string.Format("{0}{1}\n", substrings[0][0], substrings[1]));
                compteur++;
            }

            fichier.Close();
       

            return string.Format("Nombre de ligne(s) : {0}.", compteur);
        }

      


    }

        

       
    }

