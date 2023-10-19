using PrincipiosSolid.OpenClose.Correct;
using PrincipiosSolid.SingleResponsability.Correct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////////////// Forma incorrecta PRINCIPIO OPEN-CLOSE ///////////////////////
            ///Para cada nuevo coche habría que añadir nueva lógica al método precioMedioCoche()
            Coche[] arrayCoches = {
                new Coche("Renault"),
                new Coche("Audi")
            };

            ImprimirPrecioMedioCoche(arrayCoches);

            ////////////// Forma correcta PRINCIPIO OPEN-CLOSE ///////////////////////
            CocheOPCorrect[] arrayCochesCorrect = {
                new Renault(),
                new Audi(),
                new Mercedes()
             };

            ImprimirPrecioMedioCocheCorrecto(arrayCochesCorrect);
        }

        public static void ImprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                if (coche.marca.Equals("Renault")) Console.WriteLine(18000);
                if (coche.marca.Equals("Audi")) Console.WriteLine(25000);
            }
        }

        public static void ImprimirPrecioMedioCocheCorrecto(CocheOPCorrect[] arrayCochesCorrect)
        {
            foreach (CocheOPCorrect coche in arrayCochesCorrect)
            {
                Console.WriteLine(coche.PrecioMedioCoche());
            }
        }
    }
}
