using System;

namespace QuadradoDePares_1073
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valores = int.Parse(Console.ReadLine());

            for(int i = 1; i <= valores; i++)
            {
                if(i % 2 == 0) 
                {
                    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
                }
            }
        }
    }
}