using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta clase no cumple con el principio de Single Responsability ya que mezcla la funcionalidad del modelo de clase
//con la funcionalidad de guardar un coche en la base de datos 
namespace PrincipiosSolid.SingleResponsability.Incorrect
{
    public class Coche
    {
        String marca; 
        Coche(string marca) { this.marca = marca; }

        String getMarcaCoche() { return marca; }
        
    }
}

