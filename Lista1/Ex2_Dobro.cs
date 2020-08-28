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

namespace Dobro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 2:
             * Escreva um programa que leia um número inteiro, calcule e exiba o resultado do dobro deste número.
             */

            //Declaração de variáveis.
            int numero, resultado;

            //Recolhimento de dados.
            Console.Write("Insira um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            //Calculando o dobro.
            resultado = numero * 2;

            //Limpando o console.
            Console.Clear();

            //Exibição de dados.
            Console.WriteLine("O dobro do número inserido é: " + resultado);

            Console.ReadKey();
        }
    }
}
