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

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 2, Exercício 10:
             * Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um operário. 
             * Calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, 
             * calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. 
             * A hora excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente.
             * O programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".
             */

            int C, N;
            double S = 0, E = 0;
            string encerrar;

            do
            {
                //Recolhimento de dados.
                Console.Write("Código do Operário: "); C = int.Parse(Console.ReadLine());
                Console.Write("Horas trabalhadas: "); N = int.Parse(Console.ReadLine());

                for (int x = 1; x <= N; x++)
                {
                    if (x <= 50)
                    {
                        S = S + 10;
                        E = 0;
                    }
                    else if (x > 50)
                    {
                        E = E + 20;
                    }
                }

                Console.WriteLine("\nCódigo do Operário: " + C);
                Console.WriteLine("Horas trabalhadas: " + N);
                Console.WriteLine("Salário total: " +(S + E));
                Console.WriteLine("Salário excedente: " + E);

                Console.Write("\nDeseja encerrar o programa? (S/N): ");
                encerrar = Console.ReadLine().ToUpper();

                if (encerrar == "N")
                {
                    Console.Clear();
                }
            } while (encerrar != "S");
        }
    }
}
