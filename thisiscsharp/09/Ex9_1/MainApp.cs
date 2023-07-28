using System;

namespace Ex9_1
{
    class NameCard
    {

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();

            MyCard.Name = "상현";
            MyCard.Age = 24;

            Console.WriteLine("나이 : {0}", MyCard.Name);
            Console.WriteLine("이름 : {0}", MyCard.Age);
        }
    }
}