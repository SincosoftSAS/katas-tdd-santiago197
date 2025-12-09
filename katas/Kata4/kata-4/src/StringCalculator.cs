namespace Kata4
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            var values = input.Split(',');
            if (IsEmptyString(input))
                return 0;
            var sum = values.Length == 1 ? int.Parse(input) : 0;

            if (values.Length > 1) sum += values.Sum(int.Parse);

            return sum;
        }

        private static bool IsEmptyString(string input) => input == "";
    }
}