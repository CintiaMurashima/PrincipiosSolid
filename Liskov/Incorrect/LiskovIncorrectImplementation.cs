using PrincipiosSolid.OpenClose.Correct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.Liskov.Incorrect
{
    public class LiskovIncorrectImplementation
    {

        CocheLiskovIncorrect[] arrayCochesLiskov = new CocheLiskovIncorrect[]
        {
            new RenaultLiskovIncorrect(),
            new AudiLiskovIncorrect(),
            new MercedesLiskovIncorrect(),
         
        };
        public static void ImprimirNumAsientos(CocheLiskovIncorrect[] arrayCochesLiskov)
        {
            foreach (CocheLiskovIncorrect coche in arrayCochesLiskov)
            {
                if (coche is Renault)
                {
                    Console.WriteLine(RenaultLiskovIncorrect.NumAsientosRenault(coche));
                }
                else if (coche is Audi)
                {
                    Console.WriteLine(AudiLiskovIncorrect.NumAsientosAudi(coche));
                }
                else if (coche is Mercedes)
                {
                    Console.WriteLine(MercedesLiskovIncorrect.NumAsientosMercedes(coche));
                }
            }
        }

       
    }
}
