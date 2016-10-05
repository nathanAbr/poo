using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicePOO
{
    class Etudiants : Contact
    {
        private String cursus;
        public Etudiants(string nom, string prenom, string tel, string mail, String cursus) : base(nom, prenom, tel, mail)
        {
            this.cursus = cursus;
        }

        public String Cursus
        {
            get
            {
                return this.cursus;
            }
            set
            {
                this.cursus = value;
            }
        }
    }
}
