using Methods;
using System;

namespace Task2_6_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Logic.ReplacesOddNumberWith0(x));
        }


    }
}

