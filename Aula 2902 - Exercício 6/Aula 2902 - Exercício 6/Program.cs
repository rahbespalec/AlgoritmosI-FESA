using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2902___Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, media;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o valor da sua primeira nota:");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da sua segunda nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());

            //calcular a média
            media = Convert.ToDouble ((nota1 *0.4) + (nota2 * 0.6));

            //exibir o resultado
            Console.WriteLine($"Parabéns {nome}! Sua média é: {media}.");

            Console.ReadKey();
        }

    }
    }
}
