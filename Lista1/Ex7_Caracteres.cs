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

namespace Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 7:
             * Escreva um programa que leia o nome de duas pessoas e ao final exiba: 
             * • O nome das duas pessoas com todos os caracteres maiúsculos 
             * • A quantidade de caracteres de cada nome 
             * • Apenas os três primeiros caracteres de cada nome
             */

            //Declaração de variáveis.
            string nome1, nome2;

            //Recolhimento de dados.
            Console.Write("Digite o primeiro nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Digite o segundo nome: ");
            nome2 = Console.ReadLine();

            //Limpando o console.
            Console.Clear();

            //Exibição de dados.
            Console.WriteLine($"{nome1} tem {nome1.Length} letras; os três primeiros caracteres são: {nome1.Substring(0, 3).ToUpper()}.");
            Console.WriteLine($"{nome2} tem {nome2.Length} letras; os três primeiros caracteres são: {nome2.Substring(0, 3).ToUpper()}.");

            Console.ReadKey();
        }
    }
}
