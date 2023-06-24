using System;
using System.Collections.Generic;


namespace list
{
    /* Escrever um programa C# para criar uma lista de inteiros e apresente uma nova lista com os seus quadrados.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Numeros = new List<int>() { 1, 3, 5, 7, 8 };

                Console.WriteLine("Lista de Numeros");

                foreach (int Numero in Numeros)

                {
                    Console.WriteLine("{0}", Numero);

                }
           
            
                Console.WriteLine("\nNúmeros em uma lista de quadardos");

                foreach (int Numero in Numeros)

                {

                    Console.WriteLine(" {0}", Numero * Numero);

                }
                
                Console.ReadKey();
            }   
              catch(Exception ex)
            {
                Console.WriteLine("Ocorreu erro ao executar o codigo: ");
            }  

                
        }
    }
}