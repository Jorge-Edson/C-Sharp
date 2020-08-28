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

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 2, Exercício 6:
             * Escreva um programa que calcule e exiba a média de 10 notas digitadas pelo usuário. 
             * Considerar notas válidas, somente valores entre 0 (zero) e 10 (dez). 
             * Se o usuário digitar algum valor inválido, deverá ser exibida uma mensagem informando o ocorrido. 
             */

            int nota, n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, n6 = 0, n7 = 0, n8 = 0, n9 = 0, n10 = 0, media;

            for (int x = 1; x <= 10; x++)
            {
                Console.Write("Insira uma nota: ");
                nota = int.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.Write("Uma nota inválida foi inserida, digite apenas números entre 0 e 10.");
                    break;
                }

                if (x == 1)
                    n1 = nota;
                if (x == 2)
                    n2 = nota;
                if (x == 3)
                    n3 = nota;
                if (x == 4)
                    n4 = nota;
                if (x == 5)
                    n5 = nota;
                if (x == 6)
                    n6 = nota;
                if (x == 7)
                    n7 = nota;
                if (x == 8)
                    n8 = nota;
                if (x == 9)
                    n9 = nota;
                if (x == 10)
                    n10 = nota;
            }

            media = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) / 10;
            Console.WriteLine("A média é: {0}", media);
            
            Console.ReadKey();
        }
    }
}
