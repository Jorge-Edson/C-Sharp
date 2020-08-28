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

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 2, Exercício 8:
             * Escreva um programa que calcule o fatorial de um número informado pelo usuário. 
             * Dica: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N 
             */

            int x, fat;

            Console.Write("Insira um número para obter o seu fatorial: ");
            x = int.Parse(Console.ReadLine());

            for (fat = 1; x > 1; x--)
            {
                fat = fat * x;
            }

            Console.WriteLine("O fatorial do número inserido é {0}.", fat);

            Console.ReadKey();
        }
    }
}
