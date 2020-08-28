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

namespace Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 3, Exercício 2:
             * Escreva um programa que leia dois valores reais e apresente a diferença do maior para o menor. 
             * Um método chamado diferenca deverá ser implementado para realizar o cálculo e exibir o resultado.
             */

            double x, y;

            digite();   x = double.Parse(Console.ReadLine());
            digite();   y = double.Parse(Console.ReadLine());
            diferenca(x, y);

            Console.ReadKey();
        }
        
        static void digite()
        {
            Console.Write("Insira um número real: ");
        }

        static void diferenca(double x, double y)
        {
            double z;

            if (x > y)
            {
                z = x - y;
                Console.WriteLine("{0} - {1} = {2}", x, y, z);
            }
            else
            {
                z = y - x;
                Console.WriteLine("{0} - {1} = {2}", y, x, z);
            }
        }
    }
}
