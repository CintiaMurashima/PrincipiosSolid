
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.Liskov.Incorrect
{
    public class RenaultLiskovIncorrect : CocheLiskovIncorrect
    {

        public override int PrecioMedioCoche()
        {
            return 18000;
        }

        public static int NumAsientosRenault(CocheLiskovIncorrect coche)
        {
            return 5;
        }
    }
}
