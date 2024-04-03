using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 taxa_diaria = 300;
            Int32 taxa_hotel;
            String nome;

            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos dias você ficará no hotel?");
            Int32 diaria = Convert.ToInt32(Console.ReadLine());

            if (diaria < 15)
            {
                Int32 total = (taxa_diaria * diaria) + 20;
                Console.WriteLine($"Olá, {nome}, você pagará R${total},00. ");
            }
            if (diaria == 15)
            {
                Int32 total = (taxa_diaria * diaria) + 14;
                Console.WriteLine($"Olá, {nome}, você pagará R${total},00. ");
            }
            if (diaria > 15)
            {
                Int32 total = (taxa_diaria * diaria) + 12;
                Console.WriteLine($"Olá, {nome}, você pagará R${total},00. ");
            }

            Console.ReadKey();




        }
    }
}
