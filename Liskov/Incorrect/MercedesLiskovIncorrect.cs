using PrincipiosSolid.Liskov.Incorrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.Liskov.Incorrect
{
    public class MercedesLiskovIncorrect : CocheLiskovIncorrect
    {
    
        public override int PrecioMedioCoche()
        {
            return 27000;
        }
        public static int NumAsientosMercedes(CocheLiskovIncorrect coche)
        {
            return 4;
        }

       

    }
}
