using System;

namespace Mes_1052
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            string[] meses = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            Console.WriteLine(meses[valor]);
        }
    }
}