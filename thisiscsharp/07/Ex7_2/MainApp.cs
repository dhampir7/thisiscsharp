using System;

namespace EX7_2
{
    struct ACSetting
    {
        public double currentInCelsius; // 현재 온도( ℃)
        public double target;   // 희망 온도

        public double GetFahrenheit()
        {
            return currentInCelsius * 1.8 + 32;   // 화씨( °F) 계산 결과를 target에 저장
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");

        }
    }

}