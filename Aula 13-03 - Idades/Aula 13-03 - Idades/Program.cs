using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula_13_03___Idades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos anos você tem?");
            Int32 idade = Convert.ToInt32(Console.ReadLine());

            if (idade == 0)
            {
                Console.Write($"Olá, {nome}! Você tem {idade} anos. Você é um bebê!");
            }
            else if (idade <= 12)
            {
                Console.Write($"Olá, {nome}! Você tem {idade} anos. Você é uma criança!");
            }
            else if (idade <= 17)
            {
                Console.Write($"Olá, {nome}! Você tem {idade} anos. Você é um adolescente!");
            }
            else if (idade <= 60)
            {
                Console.Write($"Olá, {nome}! Você tem {idade} anos. Você é um adulto!");
            }
            else if (idade <= 120)
            {
                Console.Write($"Olá, {nome}! Você tem {idade} anos. Você é um idoso!");
            }
            else
            {
                Console.Write($"Olá, {nome}! Você tem {idade} anos. Você é uma múmia!");
            }

            Console.ReadKey();
        }
    }
}
