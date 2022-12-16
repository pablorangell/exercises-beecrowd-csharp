using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace SequenciaDeNumerosESoma_1101
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int[] valores = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));
                Array.Sort(valores);

                if (valores[0] <= 0 || valores[1] <= 0)
                {
                    break;
                }
                else
                {
                    int total = 0;

                    for (int i = valores[0]; i <= valores[1]; i++)
                    {
                        Console.Write($"{i} ");
                        total += i;
                    }

                    Console.Write($"Sum={total}");
                    Console.WriteLine();
                }
            } while (true);
        }
    }
}