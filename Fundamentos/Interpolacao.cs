using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "";
            string marca = "dell";
            double valor = 5400.00;

            Console.WriteLine("o {0} da marca {1} está no valor de {2}", nome, marca, valor);
            Console.WriteLine($"a marca do {nome} é {marca} e seu valor é {valor}");


           
        }
    }
}
