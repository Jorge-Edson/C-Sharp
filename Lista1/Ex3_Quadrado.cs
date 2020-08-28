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

namespace Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 3:
             * Escreva um programa que leia um número inteiro, calcule e exiba o resultado do quadrado desse número.
             * (Usar função da classe Math)
             */

            //Declaração de variáveis.
            int numero;
            double resultado;

            //Recolhimento de dados.
            Console.Write("Insira um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            //Calculando o quadrado do número.
            resultado = Math.Pow(numero, 2);

            //Limpando o console.
            Console.Clear();

            //Exibição de dados.
            Console.WriteLine("O quadrado de {0} é: {1}", numero, resultado);

            Console.ReadKey();
        }
    }
}
