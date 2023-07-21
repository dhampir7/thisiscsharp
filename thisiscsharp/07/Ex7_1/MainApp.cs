using System;

namespace EX7_1
{
    class A
    {
    }

    class B : A
    {
    }

    class C
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            A c = new B();
            B d = new A();
        }
    }
}