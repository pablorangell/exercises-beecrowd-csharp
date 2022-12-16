using System;
using System.Globalization;

namespace AumentoDeSalario_1048
{
    class URI
    {
        static void Main(string[] args)
        {
            double novoSalario = 0;
            double percentual = 0;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400)
            {
                percentual = 1.15;
                novoSalario = salario * percentual;
                percentual = 15;
            }

            else if (salario <= 800)
            {
                percentual = 1.12;
                novoSalario = salario * percentual;
                percentual = 12;
            }

            else if (salario <= 1200)
            {
                percentual = 1.10;
                novoSalario = salario * percentual;
                percentual = 10;
            }

            else if (salario <= 2000)
            {
                percentual = 1.07;
                novoSalario = salario * percentual;
                percentual = 7;
            }

            else if (salario > 2000)
            {
                percentual = 1.04;
                novoSalario = salario * percentual;
                percentual = 4;
            }

            double reajuste = novoSalario - salario;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}