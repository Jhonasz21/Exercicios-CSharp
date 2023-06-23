using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    //Escreva um programa para calcular a área de um triângulo retângulo, retângulo,
    //círculo.Pegue a entrada necessária do usuário e calcule as áreas.

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor do triângulo: ");
            double hipote = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor do triângulo: ");
            double catAdjacente = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor do triângulo: ");
            double catOposto = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe a base do retângulo: ");
            double baRetang = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe altura do retângulo: ");
            double altRetang = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe a circuferência do círculo: ");
            double circulo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Triângulo retângulo: " + (hipote * catAdjacente * catOposto) / 2);
            Console.WriteLine("Retângulo: " + baRetang * altRetang);
            Console.WriteLine("Círculo: " +  circulo*circulo*3.14);
            Console.ReadKey();

        }
    }
}
