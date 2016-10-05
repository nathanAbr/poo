using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercicePOO
{
    class Contact
    {
        private String nom;
        private String prenom;
        private String mail;
        private DateTime dateDeNaissance;
        private String tel;

        public Contact(String nom, String prenom, String tel, String mail)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
        }


        public void AjoutContactFile()
        {
            StreamWriter write = new StreamWriter("newfile.txt", true);
            String data;
            data = "nom :" + this.nom;
            write.WriteLine(data);
            data = "prenom :" + this.prenom;
            write.WriteLine(data);
            data = "tel :" + this.tel;
            write.WriteLine(data);
            data = "e-mail :" + this.mail;
            write.WriteLine(data);
            write.WriteLine();
            write.Close();
        }

        public void SePresenter()
        {
            Console.WriteLine("Bonjour " + this.nom + this.prenom);
        }

        public String Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public String Prenom
        {
            get
            {
                return this.prenom;
            }
            set
            {
                this.prenom = value;
            }
        }

        public String Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }

        public String Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                this.tel = value;
            }
        }
    }
    
}
