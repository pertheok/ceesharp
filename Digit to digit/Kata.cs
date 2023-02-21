using System;

namespace Digit
{
    public class Kata
    {
        public static int SquareDigits(int n)
        {
            // variable to hold individual digits from the given number
            int digit;
            // variable to hold the result int that will be returned by the method
            int result;
            // string that will be converted to an int and returned by the method
            string resultStr = "";
            // variable that holds the input converted to a string
            string strInput = n.ToString();
            for (int i = 0; i < strInput.Length; i++)
            {
                // digit gets exctracted by converting individual char to a string and finally to an int
                digit = Int32.Parse(strInput[i].ToString());
                // individual digits are squared and then added to the result string
                resultStr += Math.Pow(digit, 2).ToString();
            }
            // convert the result string to an int and return it
            result = Int32.Parse(resultStr);
            return result;
        }
    }
}

