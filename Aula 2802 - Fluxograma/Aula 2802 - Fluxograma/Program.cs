using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2802___Fluxograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            float valor1, valor2, media;

            //entrada de dados
            Console.WriteLine("Digite o primeiro valor:");

            //lendo do teclado e convertendo
            valor1= float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            // lendo do teclado e convertendo de outra forma
            valor2= Convert.ToSingle(Console.ReadLine());

            //calcular a média
            media = (valor1 + valor2) / 2;

            //exibir o resultado
            Console.WriteLine($"A média dos valores é: {media}");

            Console.ReadKey();
        }
    }
}
