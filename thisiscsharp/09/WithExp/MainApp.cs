using System;

namespace WithExp
{
    record RTransaction
    {
        public string From  { get; init; }
        public string To    { get; init; }
        public int Amount   { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            CTransaction trA = new CTransaction { from = "Alice", To = "Bob", Amount = 100 };
            CTransaction trB = new CTransaction { from = "Alice", To = "Bob", Amount = 100 };

            Console.WriteLine(trA);
            Console.WriteLine(trB);
            Console.WriteLine($"trA equals to trB : {trA.Equals(trB)});

            RTransaction tr1 = new RTransaction { From="Alice", To="Bob", Amount=100};
            RTransaction tr2 = tr1 with { To = "Charlie"};

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine($"tr1 equals to tr2 : {tr1.Equals(tr2)});

            
        }
    }
}