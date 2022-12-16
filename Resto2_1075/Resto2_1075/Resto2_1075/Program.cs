using System;

namespace Resto2_1075
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valores = int.Parse(Console.ReadLine());

            for(int i = 0; i < 10001; i++)
            {
                if(i % valores == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}