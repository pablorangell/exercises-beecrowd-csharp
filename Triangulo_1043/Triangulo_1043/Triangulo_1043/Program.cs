using System;
using System.Globalization;

namespace Triangulo_1043
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            double a, b, c;

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if(a + b <= c | a + c <= b | b + c <= a)
            {
                double areaTrapezio = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + areaTrapezio.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double perimetroTriangulo = a + b + c;
                Console.WriteLine("Perimetro = " + perimetroTriangulo.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}