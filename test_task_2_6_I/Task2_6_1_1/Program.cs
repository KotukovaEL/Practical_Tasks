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
            double x = Logic.ReadDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = Logic.ReadDouble(Console.ReadLine());
            Console.WriteLine(Logic.FindMin_for_Task2_6_1_1(x, y));
        }       
    }
}

