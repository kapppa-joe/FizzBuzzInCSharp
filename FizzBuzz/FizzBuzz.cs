using System;

namespace FizzBuzz
{

    public static class ExtensionMethod
    {
        public static bool isMultipleOf(
            this int num,
            int multiplier
        ) => num % multiplier == 0;
    }
    public class FizzBuzz
    {

        public string ConvertNumber(int num) {
            string result = num switch {
                int n when n.isMultipleOf(15) => "FizzBuzz",
                int n when n.isMultipleOf(3) => "Fizz",
                int n when n.isMultipleOf(5) => "Buzz",
                _ => Convert.ToString(num)
            };

            return result;
        }

        public string[] CountTo(int num) {
            var range = Enumerable.Range(1, num);       
            return range.Select(ConvertNumber).ToArray();
        }
    }
}