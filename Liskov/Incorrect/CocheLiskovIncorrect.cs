using PrincipiosSolid.OpenClose.Correct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.Liskov.Incorrect
{
    public abstract class CocheLiskovIncorrect
    {
        public string marca;

        public CocheLiskovIncorrect() { }
        public CocheLiskovIncorrect(string marca) { this.marca = marca; }
    
        public abstract int PrecioMedioCoche();



    }

   
}
