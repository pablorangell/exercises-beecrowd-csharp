using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace CrescenteEDecrescente_1113
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool casosDeTeste = true;

            do
            {
                int[] valores = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                if (valores[0] == valores[1])
                {
                    casosDeTeste = false;
                    break;
                }
                else if (valores[0] > valores[1])
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
            } while (casosDeTeste);
        }
    }
}