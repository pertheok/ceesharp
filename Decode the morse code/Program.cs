using System;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. ."));
            string s = ".... . -.--   .--- ..- -.. .";
            string[] subs = s.Split();
            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
        }
    }
}