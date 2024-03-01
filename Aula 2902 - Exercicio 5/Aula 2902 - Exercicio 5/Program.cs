using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2902___Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 x, b, h, j;
            Single r;

            Console.Write("Digite o valor para (b): ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor para (h): ");
            h = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor para (j): ");
            j = Convert.ToInt32(Console.ReadLine());

            x = Convert.ToInt32(Math.Pow(b, 3) * h);
            r = x / j;

            Console.WriteLine($"O valor de R é: {r}");

            Console.ReadKey();


        
        }
    }
}
