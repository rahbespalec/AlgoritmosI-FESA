using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0905___Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /** 
             * Calcular e exibir os seguintes valores:
             *  
             * 1 - Total de alunos da escola
             * 2 - Total de alunos da faixa de 21-23
             * 3 - Total de alunos por turma
             * 4 - Turma com menos alunos         
             */

            Int16 linha, coluna;

            // cria a matriz 3x3
            Int16[,] matriz = new Int16[3, 3];
            String[] turma = { "EC1", "EC2", "EC3" };
            String[] faixa = { "18-20", "21-23", "24-26" };

            // entrada de dados
            for(linha = 0; linha < 3; linha++)
            {
                Console.WriteLine($"Digitação para a turma {turma[linha]}");
                for(coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"Digite a quantidade de alunos na faixa {faixa[coluna]}: ");
                    matriz[linha, coluna] = Int16.Parse(Console.ReadLine());
                }
            }

            // saída de dados
            for (linha = 0; linha < 3; linha++)
            {
                Console.WriteLine("\t");
                for (coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"{matriz[linha, coluna]} \t");
                   
                }

                Console.WriteLine($"{}");
            }



            Console.ReadKey();
        }
    }
}
