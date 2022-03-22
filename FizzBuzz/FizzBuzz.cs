using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string ConvertNumber(int num)
        {
            string result = num switch {
                int n when n % 15 == 0 => "FizzBuzz",
                int n when n % 3 == 0 => "Fizz",
                int n when n % 5 == 0 => "Buzz",
                _ => Convert.ToString(num)
            };

            return result;
        }
    }
}