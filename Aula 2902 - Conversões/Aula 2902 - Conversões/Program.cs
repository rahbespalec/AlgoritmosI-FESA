using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2902___Conversões
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declara as variáveis
            string a, b, c;
            Int32 d;

            //dá valor para as variáveis
            a = "8";
            b = "1";
            c = a + b;

            //O Convert vai converter a string para int
            // o int32 é só pra falar que é em 32 bits
            d = Convert.ToInt32(a) + Convert.ToInt32(b);

            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
