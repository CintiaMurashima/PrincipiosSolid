using PrincipiosSolid.Liskov.Incorrect;
using PrincipiosSolid.OpenClose.Correct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.Liskov.Correct
{
    public class LiskovCorrectImplementation
    {
        CocheLiskovCorrect[] arrayCochesLiskov = new CocheLiskovCorrect[]
        {
            new RenaultLiskov(),
            new AudiLiskov(),
            new MercedesLiskov(),

        };
        public static void ImprimirNumAsientos(CocheLiskovCorrect[] arrayCochesCorrect)
        {
            foreach (CocheLiskovCorrect coche in arrayCochesCorrect)
            {
               Console.WriteLine(coche.NumAsientos());
            }
           
        }

       


    }
}
