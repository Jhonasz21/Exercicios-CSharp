using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double a, b;
           
            Console.WriteLine("Valor de a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nValor de b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Eis as sua opções:\n 1-ADIÇÃO  \n 2-SUBTRAÇÃO \n 3-MULTIPLICAÇÃO \n 4-DIVISÃO  \n 5-SAIR");

            Console.WriteLine("\n Informe o número da opção escolhida: ");
            int  Opcao = Int32.Parse(Console.ReadLine());

            switch(Opcao)
            {
                case 1:
                    Console.WriteLine("A operação escolhida foi ADIÇÃO");
                    Console.WriteLine("O resultado de a+b é: {0}", a+b);
                    break;
                case 2:
                    Console.Write("\n A operação escolhida foi SUBTRAÇÃO");
                    Console.Write("\n O resultado de a-b é: {0}", a - b);
                    break;
                case 3:
                    Console.Write("\n A operação escolhida foi MULTIPLICAÇÃO");
                    Console.Write("\n O resultado de a*b é: {0}", a * b);
                    break;
                case 4:
                    Console.WriteLine("\n A operação escolhida DIVISÃO");
                    if (b == 0)
                    {
                        Console.WriteLine("\n O valor de b é nulo. Por favor, escolha outro número");
                    }
                    else
                    {
                        Console.WriteLine("\n O resultado de a/b é: {0}", (a / b).ToString("F"));
                    }
                    break;
                    case 5:
                        Console.Write("\n Você escolheu a opção SAIR");
                    break;
                default:
                    Console.Write("\n Não há opção para este número. \nPor favor, tente novamente.\n");
                    break;

            }
            Console.ReadKey();

        }
    }
}
