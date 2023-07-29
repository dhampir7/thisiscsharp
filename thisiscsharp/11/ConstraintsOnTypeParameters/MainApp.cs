using System;

public interface ICreatable
{
    void CreateInstance();
}

public class Base : ICreatable
{
    public void CreateInstance()
    {
        Console.WriteLine("Base instance created!");
    }
}

public class Derived : Base, ICreatable
{
    public new void CreateInstance()
    {
        Console.WriteLine("Derived instance created!");
    }
}

class BaseArray<U> where U : Base, ICreatable
{
    public U[] Array { get; set; }

    public BaseArray(int size)
    {
        Array = new U[size];
    }

    public void CopyArray<T>(T[] Source) where T : U
    {
        Source.CopyTo(Array, 0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseArray<Base> c = new BaseArray<Base>(3);
        c.Array[0] = new Base();
        c.Array[1] = new Derived();
        c.Array[2] = new Derived();

        BaseArray<Derived> d = new BaseArray<Derived>(3);
        d.Array[0] = new Derived();
        d.Array[1] = new Derived();
        d.Array[2] = new Derived();

        BaseArray<Derived> e = new BaseArray<Derived>(3);
        e.CopyArray<Derived>(d.Array);

        // Test CreateInstance method from Derived class
        d.Array[0].CreateInstance();
        d.Array[1].CreateInstance();
        d.Array[2].CreateInstance();
    }
}
