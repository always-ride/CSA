namespace Codewars
{
    /*
     * Return an array containing the numbers from 1 to N, where N is the parametered value.
     * 
     * Replace certain values however if any of the following conditions are met:
     * 
     * - If the value is a multiple of 3: use the value "Fizz" instead
     * - If the value is a multiple of 5: use the value "Buzz" instead
     * - If the value is a multiple of 3 & 5: use the value "FizzBuzz" instead
     * 
     * N will never be less than 1.
     * 
     * Method calling example:
     * 
     * string[] result = FizzBuzz.GetFizzBuzzArray(3); // => [ "1", "2", "Fizz" ]
     * 
     * Source: https://www.codewars.com/kata/5300901726d12b80e8000498
     */
    public class FizzBuzz
    {
        public static string[] GetFizzBuzzArray(int n)
        {
            return Enumerable
              .Range(1, n)
              .Select(i => Fizzify(i))
              .ToArray();
        }

        public static string Fizzify(int i)
        {
            if (i % 15 == 0) return "FizzBuzz";
            if (i % 5 == 0) return "Buzz";
            if (i % 3 == 0) return "Fizz";
            return $"{i}";
        }
    }
}
