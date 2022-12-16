using System;

namespace NumerosPares_1059
{
    public class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<= 100; i++) 
            { 
                if((i%2) == 0)
                {
                    Console.WriteLine(i);
                }
            
            }
        }
    }
}