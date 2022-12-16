using System;
using System.Globalization;

namespace Lanche_1038
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] lanche = Console.ReadLine().Split(' ');

            int cod = int.Parse(lanche[0]);
            int quantidade = int.Parse(lanche[1]);
            double total;

            if(cod == 1)
            {
                total = quantidade * 4.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(cod == 2)
            {
                total = quantidade * 4.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(cod == 3)
            {
                total = quantidade * 5.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(cod == 4)
            {
                total = quantidade * 2.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                total = quantidade * 1.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
