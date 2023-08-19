using MethodsList;
using System;

namespace Task_for_list
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var list1 = Logics.GenerateList(10, -10, 10);
            var list2 = Logics.GenerateList(10, -10, 10);
            Logics.SortList(list1);
            Logics.SortList(list2);
            Logics.PrintList(list1);
            Console.WriteLine();
            Logics.PrintList(list2);
            var resultArray = Logics.MergeListWithWhile(list1, list2);
            Console.WriteLine();
            Logics.PrintList(resultArray);
        }
    }
}
