using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveiseConstante
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double pi = 3.14;

            double Area = pi * raio * raio;

            Console.WriteLine(Area);
            Console.WriteLine("o valor da area eh: " + Area);

            bool estachovendo = false;
            float ValorCamiseta = 19.90f;

        }


    }
}
 