using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicePOO
{
    class Enseignants : Contact
    {
        private String matiere;
        public Enseignants(string nom, string prenom, string tel, string mail, string matiere) : base(nom, prenom, tel, mail)
        {
            this.matiere = matiere;
        }
        public String Matiere
        {
            get
            {
                return this.matiere;
            }
            set
            {
                this.matiere = value;
            }
        }
    }
}
