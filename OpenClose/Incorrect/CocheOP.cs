using PrincipiosSolid.SingleResponsability.Correct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClose.Incorrect
{
    public class CocheOP
    {
        String marca;

        CocheOP(String marca) { this.marca = marca; }

        String getMarcaCoche() { return marca; }
    }
}
