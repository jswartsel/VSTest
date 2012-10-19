﻿using System;
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
            Console.WriteLine("4! = " + Fact(4));
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
