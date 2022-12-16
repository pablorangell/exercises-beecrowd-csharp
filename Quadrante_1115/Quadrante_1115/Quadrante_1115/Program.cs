using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Quadrante_1115
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int[] coordenadas = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                if (coordenadas[0] == 0 || coordenadas[1] == 0)
                {
                    break;
                }
                else if (coordenadas[0] > 0 && coordenadas[1] > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (coordenadas[0] > 0 && coordenadas[1] < 0)
                {
                    Console.WriteLine("quarto");
                }
                else if (coordenadas[0] < 0 && coordenadas[1] > 0)
                {
                    Console.WriteLine("segundo");
                }
                else
                {
                    Console.WriteLine("terceiro");
                }
            } while (true);
        }
    }
}