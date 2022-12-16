using System;
using System.Globalization;

namespace SalarioComBonus
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));

            double salarioliquido = salario + (vendas * 0.15);
            Console.WriteLine("TOTAL = R$ " + salarioliquido.ToString("F2", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}