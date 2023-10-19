using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClose.Correct
{
    public class MercedesLiskov : CocheLiskovCorrect
    {
        public override int NumAsientos()
        {
            return 5;
        }

        public override int PrecioMedioCoche()
        {
            return 27000;
        }

        
    }
}
