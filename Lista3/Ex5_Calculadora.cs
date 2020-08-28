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

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 3, Exercício 5:
             * Escreva um programa que exiba o seguinte menu e crie um método para realizar os cálculos de cada item deste menu: 
             * 1 – Soma 
             * 2 – Subtração 
             * 3 – Divisão 
             * 4 – Multiplicação 
             * 5 – Resto da Divisão 
             * 6 – Dobro 
             * 7 – Quadrado 
             * 8 – Cubo 
             * 9 – Raiz Quadrada 
             * 0 – Sair
             */

            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=");
                Console.WriteLine("=                               MENU                               =");
                Console.WriteLine("_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=");
                Console.WriteLine("= 1. Soma                                                          =");
                Console.WriteLine("= 2. Subtração                                                     =");
                Console.WriteLine("= 3. Divisão                                                       =");
                Console.WriteLine("= 4. Multiplicação                                                 =");
                Console.WriteLine("= 5. Resto da Divisão                                              =");
                Console.WriteLine("= 6. Dobro                                                         =");
                Console.WriteLine("= 7. Quadrado                                                      =");
                Console.WriteLine("= 8. Cubo                                                          =");
                Console.WriteLine("= 9. Raíz Quadrada                                                 =");
                Console.WriteLine("= 0. Sair                                                          =");
                Console.WriteLine("_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=_=");

                Console.Write("\nInsira o número da opção desejada: "); opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1: soma(); break;
                    case 2: subtracao(); break;
                    case 3: divisao(); break;
                    case 4: multiplicacao(); break;
                    case 5: restoDivisao(); break;
                    case 6: dobro(); break;
                    case 7: quadrado(); break;
                    case 8: cubo(); break;
                    case 9: raiz(); break;
                    case 0: break;
                }
            } while (opcao != 0);
        }

        static double digite()
        {
            double x;
            Console.Write("\nInsira um número: ");
            x = double.Parse(Console.ReadLine());
            Console.Clear();
            return x;
        }

        static void soma()
        {
            double x, y, z;

            x = digite();
            y = digite();
            z = x + y;

            Console.WriteLine("{0} + {1} = {2}", x, y, z);
            Console.ReadKey();
        }

        static void subtracao()
        {
            double x, y, z;

            x = digite();
            y = digite();
            z = x - y;

            Console.WriteLine("{0} - {1} = {2}", x, y, z);
            Console.ReadKey();
        }

        static void divisao()
        {
            double x, y, z;

            x = digite();
            y = digite();
            z = x / y;

            Console.WriteLine("{0} / {1} = {2}", x, y, z);
            Console.ReadKey();
        }

        static void multiplicacao()
        {
            double x, y, z;

            x = digite();
            y = digite();
            z = x * y;

            Console.WriteLine("{0} x {1} = {2}", x, y, z);
            Console.ReadKey();
        }

        static void restoDivisao()
        {
            double x, y, z;

            x = digite();
            y = digite();
            z = x % y;

            Console.WriteLine("O resto da divisão {0} / {1} é {2}", x, y, z);
            Console.ReadKey();
        }

        static void dobro()
        {
            double x, z;

            x = digite();
            z = x * 2;

            Console.WriteLine("O dobro de {0} é {1}", x, z);
            Console.ReadKey();
        }

        static void quadrado()
        {
            double x, z;

            x = digite();
            z = Math.Pow(x, 2);

            Console.WriteLine("O quadrado de {0} é {1}", x, z);
            Console.ReadKey();
        }

        static void cubo()
        {
            double x, z;

            x = digite();
            z = Math.Pow(x, 3);

            Console.WriteLine("O cubo de {0} é {1}", x, z);
            Console.ReadKey();
        }

        static void raiz()
        {
            double x, z;

            x = digite();
            z = Math.Sqrt(x);

            Console.WriteLine("A raíz quadrada de {0} é {1}", x, z);
            Console.ReadKey();
        }
    }
}
