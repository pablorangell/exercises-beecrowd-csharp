using System;
using System.Globalization;

namespace Intervalo_1037
{
    class URI
    {
        static void Main(string[] args)
        {
            double intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(intervalo > 75.00 && intervalo <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else if(intervalo > 50.00 && intervalo <= 75.00)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if(intervalo > 25.00 && intervalo <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (intervalo >= 0 && intervalo <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
