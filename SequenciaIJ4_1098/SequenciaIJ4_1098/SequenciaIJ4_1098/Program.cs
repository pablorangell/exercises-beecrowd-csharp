using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace SequenciaIJ4_1098
{
    public class Program
    {
        static void Main(string[] args)
        {
            double i = 0;
            double j = 1;

            while (i <= 2)
            {
                Console.WriteLine($"I={(i).ToString("0.##", CultureInfo.InvariantCulture)} J={(j.ToString("0.##", CultureInfo.InvariantCulture))}");
                Console.WriteLine($"I={(i).ToString("0.##", CultureInfo.InvariantCulture)} J={(j + 1).ToString("0.##", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"I={(i).ToString("0.##", CultureInfo.InvariantCulture)} J={(j + 2).ToString("0.##", CultureInfo.InvariantCulture)}");

                i += 0.2;
                j += 0.2;
            }
        }
    }
}