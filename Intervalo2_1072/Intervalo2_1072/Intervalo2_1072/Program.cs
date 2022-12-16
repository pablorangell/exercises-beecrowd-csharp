using System;
using System.Collections.Generic;

namespace Intervalo2_1072
{
    public class Program
    {
        static void Main(string[] args)
        {
            int qunatidade = int.Parse(Console.ReadLine());
            List<int> valores = new List<int>();
            int dentroDoIntervalo = 0;
            int foraDoIntervalo = 0;

            for (int i = 0; i < qunatidade; i++)
            {
                valores.Add(int.Parse(Console.ReadLine()));
            }

            foreach( var n in valores) 
            { 
                if(n >= 10 && n <= 20)
                {
                    dentroDoIntervalo++;
                }
                else
                {
                    foraDoIntervalo++;
                }
            }
            Console.WriteLine($"{dentroDoIntervalo} in");
            Console.WriteLine($"{foraDoIntervalo} out");
        }
    }
}