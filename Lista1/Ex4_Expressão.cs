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

namespace Expressao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 4:
             * Escreva um programa que calcule e exiba o resultado da seguinte expressão matemática:
             * (Dica: O usuário deverá informar os valores para as variáveis A, B e C)
             * A² * 5 – C / (B – A % 4)
             */

            //Declaração de variáveis.
            double A, B, C, resultado;

            //Recolhimento de dados.
            Console.Write("Insira um valor para a variável A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Insira um valor para a variável B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Insira um valor para a variável C: ");
            C = int.Parse(Console.ReadLine());

            //Calculando a expressão matemática.
            resultado = ((Math.Pow(A, 2) * 5) - C) / (B - ((A / 100) * 4));

            //Limpando o console.
            Console.Clear();

            //Exibição de dados.
            Console.WriteLine($"{A}² x 5 - {C} / ({B} - {A} % 4) = {resultado}");

            Console.ReadKey();
        }
    }
}
