using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicePOO
{
    class Program
    {
        static void Main(string[] args)
        {   
            Contact charles = new Contact("XAVIER", "Charles", "0652389632", "lol@mdr.fuck");
            charles.AjoutContactFile();
        }
    }
}
