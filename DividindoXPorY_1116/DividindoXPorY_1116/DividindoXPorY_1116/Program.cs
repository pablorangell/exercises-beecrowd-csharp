using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace DividindoXPorY_1116
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                double[] valor = Array.ConvertAll(Console.ReadLine().Split(), S => double.Parse(S));
                if (valor[1] == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisionResult = valor[0] / valor[1];
                    Console.WriteLine(divisionResult.ToString("0.0#", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}