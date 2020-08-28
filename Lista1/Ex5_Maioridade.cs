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

namespace Maioridade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 5:
             * Escreva um programa que leia a idade de uma pessoa e deverá ser exibido na tela, 
             * se esta pessoa é maior ou menor de idade (considerar 18 anos para maior idade).
             */

            //Declaração de variáveis.
            int idade;

            //Recolhimento de dados.
            Console.Write("Insira a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            //Limpando o console.
            Console.Clear();

            //Verificando condição de maioridade e exibindo dados.
            if (idade >= 18)
                Console.WriteLine("Você tem {0} anos, portanto é maior de idade.", idade);
            else
                Console.WriteLine("Você tem {0} anos, portanto é menor de idade.", idade);

            Console.ReadKey();
        }
    }
}
