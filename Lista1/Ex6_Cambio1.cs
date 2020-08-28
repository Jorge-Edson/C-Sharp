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

namespace CambioI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 6:
             * Escreva um programa que leia um valor em Reais (R$), leia também a cotação do Dólar, 
             * realize o cálculo da conversão de moeda (de Reais para Dólares) e exiba na tela o resultado.
             */

            //Declaração de variáveis.
            double real, dolar, resultado;

            //Recolhimento de dados.
            Console.Write("Insira um valor em R$: ");
            real = double.Parse(Console.ReadLine());
            Console.Write("Insira a cotação do dólar: ");
            dolar = double.Parse(Console.ReadLine());

            //Realizando cálculo de conversão de moeda.
            resultado = real / dolar;

            //Limpando o console.
            Console.Clear();

            //Exibição de dados.
            Console.WriteLine($"{real.ToString("N2")} equivale a {resultado.ToString("N2")}.");

            Console.ReadKey();
        }
    }
}
