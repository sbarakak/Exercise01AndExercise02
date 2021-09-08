using System;
using Exercise01;
using System.Numerics;

namespace Exercise02
{
    public static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter a number: ");
                string input = Console.ReadLine();
                BigInteger inputValue;
                string output = string.Empty;
                bool success = BigInteger.TryParse(input, out inputValue);
                while (!success)
                {
                    Console.WriteLine("Invalid Input. Try again...");
                    Console.WriteLine("Please enter a valid number: ");
                    input = Console.ReadLine();
                    success = BigInteger.TryParse(input, out inputValue);
                }

                try
                {
                    BigInteger bi = new BigInteger();
                    BigInteger n = BigInteger.Parse(input);
                     output = ConvertNumberToWords(bi, n);
                    Console.WriteLine("Answer is..." + output);
                    Console.WriteLine("Press [enter] to continue...");
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Error Occurred while processing your Request!");
                }
                // var key = Console.ReadKey();
            }
        }

        public static string ConvertNumberToWords(BigInteger bi, BigInteger num)
        {
            try
            {
                string output = num.ToWards(num);
                return output;
            }
            catch
            {
                throw new Exception("Error occurred");

            }
        }
    }
}
