using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WINDOWS_FORM_PPE
{
    class Classe
    {
        private int idEnseignant;   
        private string anneeScolaire;
        private int idNiveau;

        public Classe(int idEnseignant, string anneeScolaire, int idNiveau)
        {
            this.idEnseignant = idEnseignant;
            this.anneeScolaire = anneeScolaire;
            this.idNiveau = idNiveau;
        }
        public string AnneeScolaire { get { return anneeScolaire; } }
        public int IdNiveau { get { return idNiveau; } }
        public int IdEnseignant { get { return idEnseignant; } }
    }
}
