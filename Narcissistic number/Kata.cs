using System;
public class Kata
{
  public static bool Narcissistic(int value)
  {
    // convert the int to a string
    string strValue = value.ToString();
    // variable that will be used to store individual digits for checks
    int digit;
    // end result that will be compared to the original value, double as Math.Pow() returns that type
    double check = 0;
    // looping through the strValue string
    for (int i = 0; i < strValue.Length; i++)
    {
        // converts the individual digits from char to string and finally to an int
        digit = Int32.Parse(strValue[i].ToString());
        // add each digit raised to the power of the number of digits in the given value to the variable that will be checked against the provided value
        check += Math.Pow(digit, strValue.Length);
    }
    // returns whether the given number is narcissistic or not
    return check == value;
  }
}