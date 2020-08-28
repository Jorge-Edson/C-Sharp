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

namespace Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 2, Exercício 1:
             * Escreva um programa que exiba na tela em ordem crescente, apenas os números pares existentes de 11 a 250.
             */

            int x;

            for (x = 11; x <= 250; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }

            Console.ReadKey();
        }
    }
}
