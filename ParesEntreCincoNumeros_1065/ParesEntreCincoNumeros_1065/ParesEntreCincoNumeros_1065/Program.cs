using System;

namespace ParesEntreCincoNumeros_1065
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());
            double num5 = double.Parse(Console.ReadLine());

            double[] valores = { num1, num2, num3, num4, num5, };
            int count = 0;

            foreach (var numeros in valores)
            {
                if ((numeros % 2) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} valores pares");
        }
    }
}