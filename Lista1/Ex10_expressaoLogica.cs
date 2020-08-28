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

namespace ExpressaoLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 10:
             * Escreva um programa que calcule a expressão lógica, 
             * sendo que o usuário deverá informar os valores (números inteiros) para as variáveis. 
             * ((X >= Y) AND (Z <=X)) OR ((X == W) AND (Y == Z)) OR (NOT(X != W))
             */

            //Declaração de variáveis.
            int W, X, Y, Z;
            bool resultado;

            //Recolhimento de dados.
            Console.Write("Insira um valor para W: ");
            W = int.Parse(Console.ReadLine());
            Console.Write("Insira um valor para X: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Insira um valor para Y: ");
            Y = int.Parse(Console.ReadLine());
            Console.Write("Insira um valor para Z: ");
            Z = int.Parse(Console.ReadLine());

            //Limpando o console.
            Console.Clear();

            //Calculando expressão lógica e exibindo resultados.
            if (((X >= Y) && (Z <= X)) || ((X == W) && (Y == Z)) || (!(X != W)))
            {
                resultado = true;
                Console.WriteLine(resultado);
            }
            else
            {
                resultado = false;
                Console.WriteLine(resultado);
            }

            Console.ReadKey();
        }
    }
}
