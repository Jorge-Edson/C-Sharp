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

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 2, Exercício 9:
             * Escreva um programa que leia vários números inteiros e ao final informe quantos números pares, 
             * quantos números ímpares, quantos números positivos e quantos números negativos foram digitados pelo usuário. 
             * O programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?". 
             */

            int x = 0, num, pares = 0, impares = 0, positivos = 0, negativos = 0;
            string encerrar;

            do
            {
                while (x < 10)
                {
                    Console.Write("Insira um número inteiro: ");
                    num = int.Parse(Console.ReadLine());

                    if (num % 2 == 0)
                        pares++;
                    else
                        impares++;

                    if (num > 0)
                        positivos++;
                    else
                        negativos++;

                    x++;
                }

                Console.WriteLine("\nNúmeros pares: " + pares);
                Console.WriteLine("Números ímpares: " + impares);
                Console.WriteLine("Números positivos: " + positivos);
                Console.WriteLine("Números negativos: " + negativos);

                Console.Write("\nDeseja encerrar o programa? (S/N): ");
                encerrar = Console.ReadLine().ToUpper();

                if (encerrar == "N")
                {
                    Console.Clear();
                    x = 0;
                }
            } while (encerrar != "S");
        }
    }
}
