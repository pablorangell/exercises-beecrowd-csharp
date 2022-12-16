using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace MediasPonderadas_1079
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for(int i = 0; i < numero; i++)
            {
                double[] valores = Array.ConvertAll(Console.ReadLine().Split(), S => double.Parse(S));

                double media = ((valores[0] * 2) + (valores[1] * 3) + (valores[2] * 5)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}