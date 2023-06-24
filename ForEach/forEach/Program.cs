using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> List = new List<string>();
            {
                List.Add("Maria");
                List.Add("Alex");
                List.Add("Bob");
                List.Add("Anna");
            {
            foreach (string s in List)
                    {
                        Console.WriteLine(s);
                    }

                }
            }

        }
    }
}
