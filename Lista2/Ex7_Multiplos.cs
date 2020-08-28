/*
 * Autor: Jorge Edson Rocha Adão;
 * Curso: Técnico em Desenvolvimento de Sistemas;
 * Instituição: ETEC de Itanhaém.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 7:
             * Escreva um programa que exiba todos os números de 1 a 100 e a cada número que for múltiplo de 10, 
             * exiba a mensagem “MÚLTIPLO DE 10”.
             */

            for (int x = 1; x <= 100; x++)
            {
                Console.WriteLine(x);
                if (x % 10 == 0)
                    Console.WriteLine("MÚLTIPLO DE 10");
            }

            Console.ReadKey();
        }
    }
}
