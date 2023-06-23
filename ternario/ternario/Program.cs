using System;

namespace ternario
{
    internal class Program
    {
        // Dados dois números inteiros, escreva um algoritmo que retorne sua multiplicação se
        //ambos forem divisíveis por 2 ou 3, caso contrário, retorne sua soma.
        // 1. Escreva um programa C# Sharp para ler a idade e o nome de um candidato e
        //determinar se ele está apto para votar.
        static void Main(string[] args)
        {

            Console.WriteLine("Informe seu nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            String votar = (idade < 18) ? "Não permite votar pois é menor de idade" : "Autorizado a votar";

            Console.WriteLine( nome + " idade: " + votar);
            Console.ReadKey();

        }
    }
}
