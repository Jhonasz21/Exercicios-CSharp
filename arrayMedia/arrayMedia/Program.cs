 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayMedia
{
    internal class Program
    {
        //Escreva um programa para calcular a média de um aluno após ele ter feito 4 provas.
        
        static void Main(string[] args)
        {
            double[] notas = new double[4];
            double media, soma = 0;

            Console.WriteLine("Informe a 1° nota de um aluno: ");
            notas[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a 2° nota de um aluno: ");
            notas[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a 3° nota de um aluno: ");
            notas[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a 4° nota de um aluno: ");
            notas[3] = Convert.ToDouble(Console.ReadLine());

            foreach (double nota in notas)
            {
                soma += nota;  
            }

             media = soma / 4;
            Console.WriteLine("A média das notas é: " + media);

            Console.ReadKey();
        }
    }
}
