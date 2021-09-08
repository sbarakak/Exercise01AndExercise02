using System;
using System.Numerics;

namespace Exercise01
{
    public static class ExtensionMethod
    {
        //define string arrays to hold words

        //the approach is to convert biginteger to words recurssively using a a helperfunction defined below
        private static string[] LessThan20 = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static string[] Tens = new string[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        private static string[] Thousands = new string[] { "", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion", "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion", "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septdecillion", "Octodecillion", "Novemdecillion", "Vigintillion" };

        //create the BigInteger Extension method here that will accept a numeric input
        public static string ToWards(this BigInteger bi, BigInteger number)
        {
            try
            {
                if (number == 0)
                    return "Zero";
                int i = 0;
                string res = "";
                while (number > 0)
                {
                    if (number % 1000 != 0)
                    {
                        res = HelperFunction(number % 1000) + Thousands[i] + " " + res;
                    }

                    number /= 1000;
                    i++;
                }

                return res.Trim();
            }
            catch
            {
                return "Error Occurred while Converting your number";
            }
        }

        private static string HelperFunction(BigInteger num)
        {
            //base case to end recurssion
            if (num == 0)
                return "";
            else if (num < 20)
                return LessThan20[(int)num] + " ";
            else if (num < 100)
                return Tens[(int)num / 10] + " " + HelperFunction(num % 10);
            else
                return LessThan20[(int)num / 100] + " Hundred " + HelperFunction(num % 100);            
        }


    }
}
