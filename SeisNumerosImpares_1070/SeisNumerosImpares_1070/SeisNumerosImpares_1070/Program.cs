using System;

namespace SeisNumerosImpares_1070
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            for (int x = 0; x < 12; x++)
            {
                if ((valor % 2) != 0)
                {
                    Console.WriteLine(valor);
                    valor++;
                }
                else
                {
                    valor++;
                }
            }
        }
    }
}