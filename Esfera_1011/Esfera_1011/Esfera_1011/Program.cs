using System;
using System.Globalization;

namespace Esfera_11
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int R = int.Parse(Console.ReadLine());
            double pi = 3.14159;
            double raioCubo = Math.Pow(R, 3);
            double volume = (4.0 / 3) * pi * raioCubo;

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.CreateSpecificCulture("en-US")));
            Console.Read();
        }
    }
}