using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma2Numeros
{
    internal class Program
    {
        //Dados dois números inteiros, escreva um algoritmo que retorne sua multiplicação se
        //ambos forem divisíveis por 2 ou 3, caso contrário, retorne sua soma.
        static void Main(string[] args)
        {

            Console.WriteLine("Informe um número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe um número: ");
            double num2 = double.Parse(Console.ReadLine());

            double mult = (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 3 == 0 && num2 % 3 == 0)? num1*num2 : num1+num2;

            Console.WriteLine("O resultado é: " + mult);
             Console.ReadKey();
            

        }
    }
}
