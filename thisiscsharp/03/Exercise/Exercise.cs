using System;

namespace RectArea
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            int RectArea = int.Parse(width)*int.Parse(height);
            Console.WriteLine(RectArea);
        }
    }
}