using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordemInversa
{
    /* Escreva um programa em C# para ler 5 números inteiros em um vetor. O programa deve exibi-lo primeiramente de 
     * acordo com a ordem fornecida na entrada e depois exibi-lo na ordem inversa.*/
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[5];
                                                      
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um número inteiro: ");
                vetor[i] = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("Ordem do números: ");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("Ordem do números inversa: ");
            for(int i = 4; i >= 0; i--)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.ReadKey();      
            }


        }
    }

