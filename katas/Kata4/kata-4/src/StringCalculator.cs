namespace Kata4
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            input = CleanNewLines(input);
            var values = ExtractValues(input);
            if (IsEmptyString(input))
                return 0;
            var sum = values.Length == 1 ? int.Parse(input) : 0;

            if (values.Length > 1) sum += values.Sum(int.Parse);

            return sum;
        }

        private static string[] ExtractValues(string input) => input.Split(',');

        private static string CleanNewLines(string input)
        {
            input = input.Replace("\n", ",");
            return input;
        }

        private static bool IsEmptyString(string input) => input == "";
    }
}