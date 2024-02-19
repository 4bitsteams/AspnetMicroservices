using System;

namespace ProblemSolvingDemoPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArraysDemo();
            Test1BaseArray();
            Console.ReadKey();
        }

        private static void ArraysDemo()
        {
            int[] a1;
            a1 = new int[5];
            int[] a2 = new int[5];
            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };
            int[] a4 = { 1, 3, 2, 4, 5 };

            for (int i = 0; i < a3.Length; i++)
            {
                Console.Write($"{a3[i]}");
            }

            Console.WriteLine();

            foreach (int item in a4)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();

            Array array=new int[5];
            Array array2=Array.CreateInstance(typeof(int), 5);
            array2.SetValue(10,0);

           Console.ReadKey();
        }

        private static void Test1BaseArray()
        {
            Array array=Array.CreateInstance(typeof(int), new[] { 4 }, new[] {1});
            array.SetValue(2019, 1);
            array.SetValue(2020, 2);
            array.SetValue(2021, 3);
            array.SetValue(2022, 4);

            Console.WriteLine($"Starting Index {array.GetLowerBound(0)}");
            Console.WriteLine($"Ending Index {array.GetUpperBound(0)}");

            //for (int i = array.GetLowerBound(0); i < =array.GetUpperBound(0); i++)
            for (int i = 0;i < array.Length;i++)    
            {
                Console.WriteLine($"{array.GetValue(i)} at index {i}");
            }
        }
    }
}
