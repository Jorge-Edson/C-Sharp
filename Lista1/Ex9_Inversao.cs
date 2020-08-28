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

namespace Inversao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 9:
             * Escreva um programa que leia dois números inteiros, sendo armazenados respectivamente nas variáveis A e B. 
             * O programa deverá inverter os valores entre as variáveis, 
             * de modo que o valor da variável A seja atribuído na variável B e vice-versa. 
             * Ao final exibir os valores de cada variável. 
             */

            //Declaração de variáveis.
            int A, B, troca;

            //Recolhimento de dados.
            Console.Write("Insira um valor para A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Insira um valor para B: ");
            B = int.Parse(Console.ReadLine());

            //Realizando inversão de valores.
            troca = A;
            A = B;
            B = troca;

            //Limpando o console.
            Console.Clear();

            //Exibição de dados.
            Console.WriteLine($"Inversão realizada com sucesso! A = {A}, B = {B}.");

            Console.ReadKey();
        }
    }
}
