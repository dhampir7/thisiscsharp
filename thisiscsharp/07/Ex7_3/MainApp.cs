using System;

namespace EX7_3
{
    private static double GetDiscountRate(object client)
    {
        return client switch
        {
            ("학생", int n) when n < 18 => 0.2,   // 학생 & 18세 미만
            ("학생", _) => 0.1,   // 학생 & 18세 이상
            ("일반", int n) when n < 18 => 0.1,   // 일반 & 18세 미만
            ("일반", _) => 0.05,  // 일반 & 18세 이상
            _ => 0,
        };
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            object studentClient = ("학생", 16);
            object generalClient = ("일반", 25);

            double studentDiscount = GetDiscountRate(studentClient);
            double generalDiscount = GetDiscountRate(generalClient);

            Console.WriteLine("학생 할인율: " + studentDiscount);
            Console.WriteLine("일반 할인율: " + generalDiscount);
        }
    }

}