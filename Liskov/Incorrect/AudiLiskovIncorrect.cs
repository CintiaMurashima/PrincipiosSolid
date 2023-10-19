using PrincipiosSolid.Liskov.Incorrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.Liskov.Incorrect
{
    public class AudiLiskovIncorrect : CocheLiskovIncorrect
    {
    
        public override int PrecioMedioCoche()
        {
            return 25000;
        }
        public static int NumAsientosAudi(CocheLiskovIncorrect coche)
        {
            return 5;
        }

       
    }
}
