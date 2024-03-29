﻿using System;

namespace Ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nProduto 1: ");
            string produto1 = Console.ReadLine();
            Console.Write("Preço 1: R$");
            float preço1 = 0f;
            float.TryParse(Console.ReadLine(), out preço1);
            Console.Write("Produto 2: ");
            string produto2 = Console.ReadLine();
            Console.Write("Preço 2: R$");
            float preço2 = 0f;
            float.TryParse(Console.ReadLine(), out preço2);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{"\n\n\n Produto",-20}{"Preço ",16}");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{produto1,-20}{preço1,13:c}");
            Console.WriteLine($"{produto2,-20}{preço2,13:c}");
            Console.ReadKey();
        }
    }
}
