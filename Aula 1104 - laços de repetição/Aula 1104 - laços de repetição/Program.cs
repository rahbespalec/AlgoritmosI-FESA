using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1104___laços_de_repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Int16 avaliacao;

            Console.WriteLine("Informe uma nota para avaliação");
            avaliacao = Int16.Parse(Console.ReadLine());

            while (avaliacao < 0 || avaliacao > 5) 
            {
                Console.WriteLine("ERRO!!!!! Informe uma nota para avaliação entre 0 e 5:");
                avaliacao= Int16.Parse(Console.ReadLine());
            }

            switch (avaliacao)
            {
                case 0:
                    Console.WriteLine("Péssimo...");
                    break;

                case 1:
                    Console.WriteLine("Ruim...");
                    break;

                case 2:
                    Console.WriteLine("Bom...");
                    break;

                case 3:
                    Console.WriteLine("Muito bom...");
                    break;

                case 4:
                    Console.WriteLine("Ótimo...");
                    break;
            }

            Console.ReadKey();  


        }
    }
}
