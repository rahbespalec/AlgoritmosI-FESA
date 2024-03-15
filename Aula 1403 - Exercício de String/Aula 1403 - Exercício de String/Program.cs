using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1403___Exercício_de_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o seu nome:");
            String nome = Console.ReadLine();

            string[] nameParts = nome.Split(' ');

            // Assuming the first part is the first name
            string PrimeiroNome = nameParts[0];
            string Sobrenome = nameParts[nameParts.Length - 1];

            Console.WriteLine("Olá, " + PrimeiroNome + "!");

            if (nome.Length > 14)
            {
                Console.WriteLine("O seu nome possui mais do que 15 letras! Que grande, hein?");
            }
            else
            {
                Console.WriteLine("O seu nome é bem curtinho, né? Não tem nem 15 letras");
            }
            if (Sobrenome.Equals("Silva", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Olha, você tem o sobrenome mais famoso dessa nação!");
            }
            else
            {
                Console.WriteLine("Ahh, se fosse brasileiro tinha Siva no nome!");
            }
            Console.ReadKey();
        }
        

            
        }
    }
}
