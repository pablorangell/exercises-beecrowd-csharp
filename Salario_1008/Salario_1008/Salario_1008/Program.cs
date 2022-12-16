using System;
using System.Globalization;

namespace Salario_1008
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int id, horas;
            double valorHora, salario;

            id = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));

            salario = horas * valorHora;

            Console.WriteLine("NUMBER = " + id);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"), CultureInfo.CreateSpecificCulture("en-US"));
            Console.Read();
        }
    }
}