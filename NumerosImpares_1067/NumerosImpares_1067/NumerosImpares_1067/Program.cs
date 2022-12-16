using System;

namespace NumerosImpares_1067
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            for (int x = 1; x <= valor; x++)
            {
                if ((x % 2) != 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}