using System;

namespace Narcissistic
{
    class Program
    {
        static void Main(string[] args)
        {
            // should return true
            Console.WriteLine(Kata.Narcissistic(1));
            // should return false
            Console.WriteLine(Kata.Narcissistic(1652));
            // should return true
            Console.WriteLine(Kata.Narcissistic(371));
        }
    }
}