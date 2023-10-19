using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.SingleResponsability.Correct
{
    public class Coche
    {
        String marca;
        Coche(string marca) { this.marca = marca; }
        String getMarcaCoche() { return marca; }
    }
}
