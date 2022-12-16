using System;
using System.Globalization;

namespace Experiencias_1094
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            double coelhos = 0;
            double ratos = 0;
            double sapos = 0;

            for (int i = 0; i < valor; i++)
            {
                string[] animais = Console.ReadLine().Split();

                if (animais[1] == "C")
                {
                    coelhos += double.Parse(animais[0]);
                }
                else if (animais[1] == "R")
                {
                    ratos += double.Parse(animais[0]);
                }
                else if (animais[1] == "S")
                {
                    sapos += double.Parse(animais[0]);
                }
            }
            Console.WriteLine($"Total: {coelhos + ratos + sapos} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {((coelhos * 100) / (coelhos + ratos + sapos)).ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {((ratos * 100) / (coelhos + ratos + sapos)).ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {((sapos * 100) / (coelhos + ratos + sapos)).ToString("F2", CultureInfo.InvariantCulture)} %");
        }
    }
}