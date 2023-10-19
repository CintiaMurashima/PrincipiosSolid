using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClose.Correct
{
    public class AudiLiskov : CocheLiskovCorrect
    {
        public override int NumAsientos()
        {
            return 4;
        }

        public override int PrecioMedioCoche()
        {
            return 25000;
        }
    }
}
