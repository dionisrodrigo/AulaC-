using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveiseConstante.Executar},
                {"Inferencia - fundamentos",Inferencia.Executar},
                {"Interpolacao - fundamentos",Interpolacao.Executar},
                {"Entrada de dados - fundamentos",EntradaDados.Executar},
                {"Formatando numeros - fundamentos",FormatandoNumeros.Executar},


            });;

            central.SelecionarEExecutar();
        }
    }
}