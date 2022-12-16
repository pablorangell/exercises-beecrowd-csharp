using System;

namespace Tabuada_1078
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valores = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {valores} = {i * valores}");
            }
        }
    }
}