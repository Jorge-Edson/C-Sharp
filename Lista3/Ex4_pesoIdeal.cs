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

namespace pesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 3, Exercício 4:
             * Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule o peso ideal, 
             * utilizando as seguintes fórmulas: 
             * (h = altura) 
             * - Para homens: (72.7*h) - 58 
             * - Para mulheres: (62.1 *h) - 44.7 
             * Um método chamado calcularPesoIdeal deverá ser implementado para a realização do cálculo, 
             * sendo que deverá receber por parâmetro o sexo e a altura da pessoa.
             */

            double h;
            string sexo;

            Console.Write("Insira sua altura: ");   h = double.Parse(Console.ReadLine());
            Console.Write("Insira seu sexo: ");     sexo = Console.ReadLine().ToLower();
            calcularPesoIdeal(h, sexo);

            Console.ReadKey();
        }

        static void calcularPesoIdeal(double h, string sexo)
        {
            double pesoIdeal = 0;

            if (sexo == "masculino" || sexo == "m")
            {
                pesoIdeal = (72.7 * h) - 58;
            }
            else if (sexo == "feminino" || sexo == "f")
            {
                pesoIdeal = (62.1 * h) - 44.7;
            }

            Console.WriteLine($"\nO seu peso ideal é {pesoIdeal} KG.");
        }
    }
}
