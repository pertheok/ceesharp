using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetUnique(new [] {1, 2, 2, 2}));
            Console.WriteLine(Kata.GetUnique(new [] {-2, 2, 2, 2}));
            Console.WriteLine(Kata.GetUnique(new [] {11, 11, 14, 11, 11}));
        }
    }
}