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

namespace Cambio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 8:
             * Escreva um programa que leia um valor em Reais (R$), leia também a cotação do Dólar e do Euro, 
             * realize o cálculo das respectivas conversões de moedas (de Reais para Dólares e de Reais para Euros) 
             * e exiba os resultados na tela. 
             */

            //Declaração de variáveis.
            double real, dolar, euro, resultado1, resultado2;

            //Recolhimento de dados.
            Console.Write("Insira um valor em R$: ");
            real = double.Parse(Console.ReadLine());
            Console.Write("Insira a cotação do dólar: ");
            dolar = double.Parse(Console.ReadLine());
            Console.Write("Insira a cotação do euro: ");
            euro = double.Parse(Console.ReadLine());

            //Realizando conversão de moedas.
            resultado1 = real / dolar;
            resultado2 = real / euro;

            //Exibição de dados.
            Console.WriteLine($"{real.ToString("N2")} R$ equivale a {resultado1.ToString("N2")} dólares e {euro.ToString("N2")} euros.");

            Console.ReadKey();
        }
    }
}
