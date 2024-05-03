using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0205___ex_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            Double[] salarios = new Double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite o nome da pessoa {i + 1}");
                nomes[i] = Console.ReadLine();

                Console.WriteLine($"Digite o salário da pessoa {i + 1}");
                salarios[i] = Convert.ToDouble(Console.ReadLine());
                
            }

            Console.WriteLine("\nNomes e salários:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{nomes[i]} - {salarios[i]}");
            }

            Console.ReadKey();

        }
    }
}
