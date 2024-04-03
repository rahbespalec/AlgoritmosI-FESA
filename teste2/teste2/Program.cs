using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double nota1, nota2, nota3, nota4, media, media_total;
            String nome;

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a sua primeira nota?");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a sua segunda nota?");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a sua terceira nota?");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a sua quarta nota?");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = ((nota1 * 1) + (nota2 * 2) + (nota3 * 3) + (nota4 * 4))/10;
           

            if (media >= 7)
            {
                Console.WriteLine($"Parabéns, {nome}! Suas notas foram {nota1}, {nota2}, {nota3} e {nota4}. A sua média foi {media} e você foi aprovado.");
                
            }
            else { 
                Console.WriteLine($"Olá {nome}! Suas notas foram {nota1}, {nota2}, {nota3} e {nota4}. A sua média foi {media} e você foi reprovado.");
            }

            Console.ReadKey();
        }
    }
}
