using System;

namespace VSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            var j = new Justin();
            j.WriteNumbers();

            Console.WriteLine("\n This is Liz's branch.");
            Console.ReadKey();
        }
    }
}
