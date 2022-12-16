using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace SequenciaIJ1_1095
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 60;

            while(j >= 0)
            {
                Console.WriteLine($"I={i} J={j}");
                i += 3;
                j -= 5;
            }
        }
    }
}