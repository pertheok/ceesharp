using System;

namespace Ends
{
    class Kata
    {
        public static bool Solution(string str, string ending)
        {
            if (str.Contains(ending))
            {
                string sub = str.Substring(str.Length - ending.Length);
                if (sub == ending)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            // alternatively return str.EndsWith(ending);
        }
    }
}