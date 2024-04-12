using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1104___Laço_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char tipoPagamento;

            do
            {
                Console.WriteLine("Digite o tipo de pagamento ( a vista o parcelado) V/P: ");
                tipoPagamento = Console.ReadLine().ToUpper()[0];

                if (tipoPagamento != 'V' && tipoPagamento != 'P')
                {
                    Console.WriteLine("Valor errado, tente outro...");
                }

            }

            while(tipoPagamento != 'V' && tipoPagamento != 'P');

            Console.ReadKey();

        }
    }
}
