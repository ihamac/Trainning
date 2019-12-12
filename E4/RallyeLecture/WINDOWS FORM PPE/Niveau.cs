using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WINDOWS_FORM_PPE
{
    class Niveau
    {
        private int id;
        private string niveauScolaire;

        public Niveau(int id, string niveauScolaire)
        {
            this.id = id;
            this.niveauScolaire = niveauScolaire;
        }
        public string NiveauScolaire { get { return niveauScolaire; } }
    }
}
