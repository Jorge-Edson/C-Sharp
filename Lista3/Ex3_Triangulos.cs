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

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 3, Exercício 3:
             * Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). 
             * Verificar se cada lado é menor que a soma dos outros dois lados. 
             * Se sim, saber de A==B e se B==C, sendo verdade o triângulo é equilátero; 
             * Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; 
             * e caso contrário, o triângulo será escaleno. 
             * Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência. 
             * Deverá ser implementado um método para verificar a validade de cada tipo de triângulo. 
             * Estes métodos deverão retornar um valor lógico (true ou false).
             */

            double A, B, C;
            bool triangulo = false, equilatero = false, isosceles = false, escaleno = false;

            do
            {
                Console.Write("Defina um valor para o lado A do triângulo: "); A = double.Parse(Console.ReadLine());
                Console.Write("Defina um valor para o lado B do triângulo: "); B = double.Parse(Console.ReadLine());
                Console.Write("Defina um valor para o lado C do triângulo: "); C = double.Parse(Console.ReadLine());
                triangulo = verificarTriangulo(A, B, C);
            } while (triangulo == false);
            
            equilatero = verificarEquilatero(A, B, C);
            isosceles = verificarIsosceles(A, B, C);
            escaleno = verificarEscaleno(A, B, C);

            if (equilatero == true)
                Console.WriteLine("\nOs valores inseridos correspondem a um triângulo equilátero.");
            else if (isosceles == true && equilatero == false)
                Console.WriteLine("\nOs valores inseridos correspondem a um triângulo isósceles.");
            else if (escaleno == true)
                Console.WriteLine("\nOs valores inseridos correspondem a um triângulo escaleno.");

            Console.ReadKey();
        }

        static bool verificarTriangulo(double A, double B, double C)
        {
            if ((A < (B + C)) && (B < (A + C)) && (C < (A + B)))
            {
                return true;
            }
            else
            {
                Console.WriteLine("\nOs valores inseridos não correspondem aos lados de um triângulo. Tente novamente.");
                Console.ReadKey();
                Console.Clear();
                return false;
            }
        }

        static bool verificarEquilatero(double A, double B, double C)
        {
            if (A == B && B == C)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool verificarIsosceles(double A, double B, double C)
        {
            if ((A == B) || (A == C) || (B == C))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        static bool verificarEscaleno(double A, double B, double C)
        {
            if ((A != B) && (A != C) && (B != C))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
