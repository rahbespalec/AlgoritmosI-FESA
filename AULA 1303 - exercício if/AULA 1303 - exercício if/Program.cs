using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_1303___exercício_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número entre 1-50");
            Int32 numero = Int32.Parse(Console.ReadLine());

           if (numero >= 0 && numero <=15 )
            {
                Console.WriteLine("Você está na faixa 1.");
            }
            else if (numero >= 0 && numero <= 25){
                Console.WriteLine("Você está na faixa 2.");
            }
            else if (numero >= 0 && numero <= 50)
            {
                Console.WriteLine("Você está na faixa 3.");
            }
            else
            {
                Console.WriteLine("Você não está em nenhuma faixa");
            }


            Console.ReadKey();
        }
    }
}
