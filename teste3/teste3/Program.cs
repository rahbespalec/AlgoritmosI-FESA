using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            if ( idade <= 12)
            
                Console.WriteLine("Ainda é uma criança.");

            if (idade < 70 && idade > 12)
                Console.WriteLine("Adolescente ou adulto.");

            if (idade >= 70)
                    Console.WriteLine("Trata-se de uma pessoa idosa.");
          
            

            Console.ReadKey();
        }
    }
}
