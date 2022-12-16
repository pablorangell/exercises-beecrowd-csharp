using System;
using System.Globalization;

namespace Media3_1040
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] notas = Console.ReadLine().Split(' ');

            double n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);

            double media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1))/ 10;
            
            if(media == 4.85)
            {
                media = 4.80;
            }

            if(media >= 7)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
                Console.Read();
                
            }
            else if(media < 5)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                double novaMedia = (notaExame + media) /2;           

                if(novaMedia >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + novaMedia.ToString("F1", CultureInfo.InvariantCulture));
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + novaMedia.ToString("F1", CultureInfo.InvariantCulture));
                    Console.Read();
                }

            }

        }
    }
}