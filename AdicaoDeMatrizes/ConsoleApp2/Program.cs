using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalNotasPorGrupo = 5;
            double mediaGrupo1, mediaGrupo2;
            float[,] pontuacoes = new float[totalNotasPorGrupo, totalNotasPorGrupo];
            float totalGrupo1 = 0.0f, totalGrupo2 = 0.0f;
            
            Console.WriteLine(" Digite as notas dos grupos");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < totalNotasPorGrupo; j++)
                {
                    pontuacoes[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < totalNotasPorGrupo; i++)
            {
                Console.WriteLine(" A nota do grupo 1 na posição [0,{0}] é: {1}", i, pontuacoes[0, i]);
                totalGrupo1 += pontuacoes[0, i];
            }
            
            mediaGrupo1 = totalGrupo1 / totalNotasPorGrupo;
            Console.WriteLine("\n A média das notas do grupo 1 é: {0}\n", mediaGrupo1.ToString("F"));
           
           
            for (int i = 0; i < totalNotasPorGrupo; i++)
            {
                Console.WriteLine(" \nA nota do grupo 2 na posição [1,{0}] é: {1}", i, pontuacoes[1, i]);
                totalGrupo2 += pontuacoes[1, i];
            }
           
            mediaGrupo2 = totalGrupo2 / totalNotasPorGrupo;
            Console.WriteLine(" A média das notas do grupo 2 é: {0}\n", mediaGrupo2.ToString("F"));
          
            if (mediaGrupo1 > mediaGrupo2)
            {
                Console.WriteLine(" \n O grupo 1 se destacou mais com maior média");
            }
            else
            {
                if (mediaGrupo1 < mediaGrupo2)
                {
                    Console.WriteLine("\n O grupo 2 se destacou mais com maior média");
                }
                else
                {
                    Console.WriteLine(" \n Os grupos obtiveram desempenho igual");
                }
            }
            Console.ReadKey();

        }
    }
}
