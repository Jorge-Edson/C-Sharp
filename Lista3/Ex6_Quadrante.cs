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

namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 3, Exercício 6:
             * Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) 
             * através de um método chamado verificaQuadrante, 
             * que deverá receber um valor para x e um valor para y (coordenadas).
             */

            int x, y, quadrante;

            Console.Write("Digite um valor para X: ");  x = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor para Y: ");  y = int.Parse(Console.ReadLine());
            quadrante = verificaQuadrante(x, y);

            Console.WriteLine("As coordenadas {0},{1} correspondem ao {2}º quadrante.");
            Console.ReadKey();
        }

        static int verificaQuadrante(int x, int y)
        {
            if ((x > 0) && (y > 0))
                return 1;
            else if ((x < 0) && (y > 0))
                return 2;
            else if ((x < 0) && (y < 0))
                return 3;
            else if ((x > 0) && (y < 0))
                return 4;
            else
                return 0;
        }
    }
}
