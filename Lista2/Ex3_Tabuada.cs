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

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 2, Exercício 3:
             * Escreva um programa que exiba na tela a tabuada de um número que deverá ser informado pelo usuário 
             * (deverá ser usada qualquer estrutura de repetição). 
             */

            int x, y = 0, z;

            Console.Write("Digite um número para obter a sua tabuada: ");
            x = int.Parse(Console.ReadLine());

            while (y <= 10)
            {
                z = x * y;
                Console.WriteLine("{0} x {1} = {2}", x, y, z);
                y++;
            }

            Console.ReadKey();
        }
    }
}
