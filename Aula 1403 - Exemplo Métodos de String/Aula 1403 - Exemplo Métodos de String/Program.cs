using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1403___Exemplo_Métodos_de_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite uma frase: ");
            String frase = Console.ReadLine();

            Console.WriteLine($"Tudo minúsculo: {frase.ToLower()}");
            Console.WriteLine($"Tudo maísculo: {frase.ToUpper()}");

            if(frase.Length < 10)
            {
                Console.WriteLine("Esta frase possui menos que 10 letras");
            }
            else
            {
                Console.WriteLine("Esta frase é bem grande, hein?");
            }
            //Console.WriteLine($"As 4 primeiras letras: {frase.Substring(0, 4)}");

            if (frase.IndexOf('u') == -1);
            {
                Console.WriteLine("A letra [u] não existe na frase");
            }
            Console.ReadKey();
        }
    }
}
