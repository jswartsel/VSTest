using System;

namespace VSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("4! = " + Fact(4));
            var j = new Justin();
            j.WriteNumbers();

            Console.WriteLine("\n This is Liz's branch.");
            Console.ReadKey();
        }

        static int Fact(int fact)
        {
            if (fact < 0)
            {
                throw new ArgumentOutOfRangeException("fact");
            }

            switch(fact)
            {
                case 0:
                case 1:
                    return 1;
                default:
                    return fact * Fact(fact - 1);
            }
        }
    }
}
