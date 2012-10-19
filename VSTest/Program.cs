using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            var j = new Justin();
            j.WriteNumbers();

            Console.ReadKey();
        }
    }
}
