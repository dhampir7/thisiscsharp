using System;

namespace _14_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            foreach (int a in array)
            {
                Action action = (a) => a * a;

                Console.WriteLine($"{a}");
            }
        }
    }
}