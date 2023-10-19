using PrincipiosSolid.SingleResponsability.Correct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClose.Incorrect
{
    public class CocheOpenCloseIncorrect
    {
        public String marca;
        
        public CocheOpenCloseIncorrect(String marca) { this.marca = marca; }

        public String getMarcaCoche() { return marca; }
    }
}
