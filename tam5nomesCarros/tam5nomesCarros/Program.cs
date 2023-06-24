using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tam5nomesCarros
{
    internal class Program
    {
        /* Criar um vetor de tamanho 5 contendo nomes de carros, adicione-o numa lista e mostre-a na tela os elementos e suas posições iniciais. 
          Depois insira um outro nome de carro na posição 3 e mostre a lista resultante na tela.
         */
        static void Main(string[] args)
        {
            string[] carros = new string[5]; carros[0] = "Toyota"; carros[1] = "Honda"; carros[2] = "Mazerati"; carros[3] = "Mazda"; carros[4] = "Ferrari";

            List<string> Veiculo = new List<string>(carros);
            Console.WriteLine("Lista de carros:\n ");

            for(int i = 0; i < Veiculo.Count; i++) 
              Console.WriteLine("Posições dos carros{0} é: {1}", i, Veiculo[i]);
            
            
            Veiculo.Insert(3, "Fiat");
            Console.WriteLine("Nomes dos carros é:");

            for (int i = 0; i < Veiculo.Count; i++)
                Console.WriteLine("Carro na posição {0} é: {1}", i, Veiculo[i]);
            Console.ReadKey();


        }
    }
}
