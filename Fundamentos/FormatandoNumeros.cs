using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double real = 15.9445;

            Console.WriteLine(real.ToString("f1"));
            Console.WriteLine(real.ToString("#.##"));
        }
    }
}
