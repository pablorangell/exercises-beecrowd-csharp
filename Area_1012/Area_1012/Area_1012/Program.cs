using System;
using System.Globalization;

namespace Area_1012
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] dimensoes = Console.ReadLine().Split(' ');

            double A = double.Parse(dimensoes[0], CultureInfo.CreateSpecificCulture("en-US"));
            double B = double.Parse(dimensoes[1], CultureInfo.CreateSpecificCulture("en-US"));
            double C = double.Parse(dimensoes[2], CultureInfo.CreateSpecificCulture("en-US"));

            double pi = 3.14159;
            double triangulo = (A * C) / 2;
            double circulo = Math.Pow(C, 2) * pi;
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"), CultureInfo.CreateSpecificCulture("en-US"));
            Console.Read();

            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"), CultureInfo.CreateSpecificCulture("en-US"));
            Console.Read();

            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"), CultureInfo.CreateSpecificCulture("en-US"));
            Console.Read();

            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"), CultureInfo.CreateSpecificCulture("en-US"));
            Console.Read();

            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"), CultureInfo.CreateSpecificCulture("en-US"));
            Console.Read();
        }
    }
}