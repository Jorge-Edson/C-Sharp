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

namespace Impares1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 2, Exercício 2:
             * Escreva um programa que exiba na tela em ordem decrescente, 
             * apenas os números ímpares existentes entre dois números digitados pelo usuário (inclusive eles).
             */

            //Declaração de variáveis;
            int x, y, z;

            Console.Write("Insira o primeiro número: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Agora, insira um número menor: ");
            y = int.Parse(Console.ReadLine());

            for (z = x; z >= y; z--)
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
