using System;
using System.Globalization;

namespace ImpostoDeRenda_1051
{
    class URI
    {
        static void Main(string[] args)
        {
            double salario, renda = 0;
            double taxa1 = 0.08, taxa2 = 0.18, taxa3 = 0.28;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
                return;
            }

            if (salario > 2000.00 && salario <= 3000.00)
            {
                renda = (salario - 2000) * taxa1;
            }

            if (salario > 3000.00 && salario <= 4500.00)
            {
                renda = 1000 * taxa1;
                renda = renda + ((salario - 3000) * taxa2);
            }

            if (salario > 4500.00)
            {
                renda = 1000 * taxa1;
                renda = renda + (1500 * taxa2);
                renda = renda + ((salario - 4500) * taxa3);
            }

            Console.WriteLine("R$ {0}", renda.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}