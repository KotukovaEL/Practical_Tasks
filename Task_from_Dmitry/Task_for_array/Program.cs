using MethodsArray;
using System;

namespace Task_for_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = Logics.GenerateArray(10, -10, 10);
            var array2 = Logics.GenerateArray(10, -10, 10);
            Logics.SortArray(array1);
            Logics.SortArray(array2);
            Logics.PrintArray(array1);
            Console.WriteLine();
            Logics.PrintArray(array2);
            var resultArray = Logics.MergeArray(array1, array2);
            Console.WriteLine();
            Logics.PrintArray(resultArray);
        }
    }
}
