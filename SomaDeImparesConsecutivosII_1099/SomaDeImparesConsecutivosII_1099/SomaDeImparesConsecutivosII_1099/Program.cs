using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace SomaDeImparesConsecutivosII_1099
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < valor; i++)
            {
                int[] entrada = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
                Array.Sort(entrada);

                List<int> numerosImpares = new List<int>();

                for (int x = (entrada[0] + 1); x < entrada[1]; x++)
                {
                    if (x % 2 != 0)
                    {
                        numerosImpares.Add(x);
                    }
                }
                Console.WriteLine(numerosImpares.Sum());
            }
        }
    }
}