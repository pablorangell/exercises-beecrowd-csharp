﻿using System;

namespace Animal_1049
{
    class URI
    {
        static void Main(string[] args)
        {
            string a, b, c;

            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();

            if (a == "vertebrado")
            {
                if (b == "ave")
                {
                    if (c == "carnivoro")
                        Console.WriteLine("aguia");

                    if (c == "onivoro")
                        Console.WriteLine("pomba");
                }

                if (b == "mamifero")
                {
                    if (c == "onivoro")
                        Console.WriteLine("homem");

                    if (c == "herbivoro")
                        Console.WriteLine("vaca");
                }
            }

            if (a == "invertebrado")
            {
                if (b == "inseto")
                {
                    if (c == "hematofago")
                        Console.WriteLine("pulga");

                    if (c == "herbivoro")
                        Console.WriteLine("lagarta");
                }

                if (b == "anelideo")
                {
                    if (c == "hematofago")
                        Console.WriteLine("sanguessuga");

                    if (c == "onivoro")
                        Console.WriteLine("minhoca");
                }
            }
        }
    }
}