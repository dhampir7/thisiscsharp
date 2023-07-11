using System;
using static System.Console;

namespace Hello
{
    class Exercise
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("여러분, 안녕하세요?");
                Console.WriteLine("반갑습니다!");
                return;
            }

            WriteLine("Hello, {0}!", args[0]);
        }
    }
}