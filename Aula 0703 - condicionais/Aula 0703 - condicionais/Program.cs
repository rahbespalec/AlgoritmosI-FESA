using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0703___condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Int32 qtdEstoque, diferenca;

            Console.Write("Quantos ovos existem no estoque?");
            qtdEstoque = Convert.ToInt32(Console.ReadLine());

            if(qtdEstoque > 12 && qtdEstoque < 36)
                {
                Console.WriteLine("Vou comprar mais ovos...");
                qtdEstoque = qtdEstoque + 24;

                }
            else
            {
                if(qtdEstoque <12 )
                {
                    Console.WriteLine("Vou comprar mais que 24 ovos...");
                    diferenca = 36 - qtdEstoque;
                    qtdEstoque = qtdEstoque + diferenca;
                }
            }

            Console.WriteLine($"Seu estoque está com {qtdEstoque} ovos");

            Console.ReadKey();
        }
    }
}
