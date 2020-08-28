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

namespace Ficha
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lista 1, Exercício 1:
             * Escreva um programa que armazene em variáveis o seu nome, idade e cidade onde reside.
             * Na sequência, exiba o conteúdo destas variáveis na tela.
             */

            //Declaração de variáveis.
            int idade;
            string nome, cidade;

            //Recolhimento de dados.
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Insira a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da cidade onde reside: ");
            cidade = Console.ReadLine();

            Console.Clear();

            //Exibição de dados.
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Cidade: " + cidade);

            Console.ReadKey();
        }
    }
}
