using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternario01
{
    internal class Program  {
        // Escreva um programa em C# Sharp, que é um programa orientado por menu para
        // executar cálculos simples.
        // Aqui estão as opções:
        // 1-Adição. 2-Subtração. 3-Multiplicação. 4-Divisão. 5-Saída.
        static void Main(string[] args) {
            int opcao;
            double n1, n2;
            Console.WriteLine("Digite o valor de n1: ");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de n2: ");
            n2 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Escolha uma operação que deseja:  \n1=Adição \n2=Subtração \n3=Multiplicação \n4=Divisão \n5=Sair ");
            opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)     {
                case 1:
                    Console.WriteLine("Adição é: {0}", n1+n2); 
               break;
                case 2:
                    Console.WriteLine("Subtração é: {0}", n1-n2); 
                    break;
                case 3:
                    Console.WriteLine("Multiplicação é: {0}", n1*n2); 
                    break;
                case 4:
                    Console.WriteLine("Divisão é: {0}", n1/n2); 
                    break;
                case 5:
                    Console.WriteLine("Você escolheu a opção Sair"); 
                    break;
                default:
                    Console.WriteLine("Não tem número para essa operação");
                    break;
            }
            Console.ReadKey();
        }
    }
}
