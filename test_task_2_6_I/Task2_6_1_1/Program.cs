using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methods;

namespace Task2_6_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            double x = Class1.ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = Class1.ReadDouble(Console.ReadLine());
            Console.WriteLine(Class1.FindMin_2(x, y));
        }       
    }
}

