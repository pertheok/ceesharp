using System;

namespace Replace
{
    public static class Kata
    {
        public static string AlphabetPosition(string text)
        {
            // Create an empty result string which will be populated later on
            string result = "";
            // change the input text to lower case as otherwise the upper case letters won't be recognised by the Char.IsLetter() method
            text = text.ToLower();
            // create a variable that will represent the individual characters in the string
            char c;
            // initialise the loop going through each character in the input string
            for (int i = 0; i < text.Length; i++)
            {
                // c is assigned to the character the loop is currently focusing on
                c = text[i];
                // if the character is a letter, the switch cases are checked - otherwise the loop moves on
                if (Char.IsLetter(c))
                {
                    // checks what value is the letter character being investigated, then assigns its position in the alphabet to the result string along with a space
                    switch (c)
                    {
                        case 'a':
                            result += "1 ";
                            break;
                        case 'b':
                            result += "2 ";
                            break;
                        case 'c':
                            result += "3 ";
                            break;
                        case 'd':
                            result += "4 ";
                            break;
                        case 'e':
                            result += "5 ";
                            break;
                        case 'f':
                            result += "6 ";
                            break;
                        case 'g':
                            result += "7 ";
                            break;
                        case 'h':
                            result += "8 ";
                            break;
                        case 'i':
                            result += "9 ";
                            break;
                        case 'j':
                            result += "10 ";
                            break;
                        case 'k':
                            result += "11 ";
                            break;
                        case 'l':
                            result += "12 ";
                            break;
                        case 'm':
                            result += "13 ";
                            break;
                        case 'n':
                            result += "14 ";
                            break;
                        case 'o':
                            result += "15 ";
                            break;
                        case 'p':
                            result += "16 ";
                            break;
                        case 'q':
                            result += "17 ";
                            break;
                        case 'r':
                            result += "18 ";
                            break;
                        case 's':
                            result += "19 ";
                            break;
                        case 't':
                            result += "20 ";
                            break;
                        case 'u':
                            result += "21 ";
                            break;
                        case 'v':
                            result += "22 ";
                            break;
                        case 'w':
                            result += "23 ";
                            break;
                        case 'x':
                            result += "24 ";
                            break;
                        case 'y':
                            result += "25 ";
                            break;
                        case 'z':
                            result += "26 ";
                            break;
                        default:
                            break;
                    }
                }
            }
            // trim the trailing whitespace from the result string
            result = result.Trim();
            return result;
        }
    }
}