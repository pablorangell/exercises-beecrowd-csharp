using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace PositivosEMedia_1064
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("th-TH", false);

            List<double> valores = new List<double>(); 
            int positivos = 0;
            double media = 0;
            double soma = 0;

            for(int i = 0; i < 6; i++)
            {
                valores.Add(double.Parse(Console.ReadLine()));
            }

            foreach (var numeros in valores)
            {
                if (numeros > 0)
                {
                    positivos++;
                    soma += numeros;
                }
            }

            media = soma / positivos;


            Console.WriteLine($"{positivos} valores positivos");
            Console.WriteLine($"{(media).ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}