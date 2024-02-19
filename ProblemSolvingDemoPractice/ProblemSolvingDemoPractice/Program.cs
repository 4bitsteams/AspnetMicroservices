using System;

namespace ProblemSolvingDemoPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArraysDemo();
            Console.WriteLine("Hello World!");
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
    }
}
