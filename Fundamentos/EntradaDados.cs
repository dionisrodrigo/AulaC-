using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class EntradaDados
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());


            Console.WriteLine($" o meu nome é {nome} e tenho {idade} de idade ");
        }
    }
}
