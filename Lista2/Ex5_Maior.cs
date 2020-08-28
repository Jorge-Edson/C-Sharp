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

namespace Maior
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 2, Exercício 5:
             * Escreva um programa que leia 15 números inteiros e exiba na tela ao final, 
             * o maior número que foi digitado pelo usuário. 
             */

            int num, maior = 0;

            for (int x = 0; x < 15; x++)
            {
                Console.Write("Insira um número: ");
                num = int.Parse(Console.ReadLine());
                if (num > maior)
                    maior = num;
            }

            Console.WriteLine("O maior número digitado é {0}.", maior);
            Console.ReadKey();
        }
    }
}
