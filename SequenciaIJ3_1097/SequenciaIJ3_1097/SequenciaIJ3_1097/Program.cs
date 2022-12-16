using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace SequenciaIJ3_1097
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 7;

            while (i <= 9)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
                Console.WriteLine($"I={i} J={j}");
                j--;
                Console.WriteLine($"I={i} J={j}");

                i += 2;
                j += 4;
            }
        }
    }
}