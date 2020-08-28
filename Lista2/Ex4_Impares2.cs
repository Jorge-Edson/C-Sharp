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

namespace Impares2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 2, Exercício 4:
             * Escreva um programa que exiba na tela a quantidade de números ímpares existentes entre dois números que o usuário digitar 
             * (testar inclusive os números digitados).
             */

            int x, y, z;

            Console.Write("Insira o primeiro número: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            y = int.Parse(Console.ReadLine());

            for (z = x; z <= y; z++)
            {
                if (z % 2 != 0)
                {
                    Console.WriteLine(z);
                }
            }

            Console.ReadKey();
        }
    }
}
