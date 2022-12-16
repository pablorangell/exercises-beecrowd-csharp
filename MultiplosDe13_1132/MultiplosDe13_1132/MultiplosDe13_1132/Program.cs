using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace MultiplosDe13_1132
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            int total = 0;

            valores.Add(int.Parse(Console.ReadLine()));
            valores.Add(int.Parse(Console.ReadLine()));
            valores.Sort();

            for (int i = valores[0]; i <= valores[1]; i++)
            {
                if (i % 13 != 0)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }
}