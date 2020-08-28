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

namespace calcularFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 3, Exercício 1:
             * Escreva um programa que calcule o fatorial de um número informado pelo usuário. 
             * Um método chamado calcularFatorial deverá retornar o resultado final. 
             * Dica: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N 
             */

            //Declaração de variáveis.
            int x, fat;

            Console.Write("Insira um número para obter seu fatorial: ");
            x = int.Parse(Console.ReadLine());

            fat = calcularFatorial(x);
            Console.WriteLine("O fatorial do número inserido é: {0}", fat);

            Console.ReadKey();
        }

        static int calcularFatorial(int x)
        {
            int fat;

            for (fat = 1; x > 1; x--)
            {
                fat = fat * x;
            }

            return fat;
        }
    }
}
