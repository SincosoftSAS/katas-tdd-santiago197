namespace Kata4
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            if (HasDelimiter(input))
            {
                var endDelimiter = input.IndexOf('\n');
                var extractedNumbers = GetNumbersWithDelimiter(input, endDelimiter);
                var delimiter = GetDelimiter(input, endDelimiter);
                var numbers = ExtractValues(extractedNumbers, delimiter);
                return numbers.Sum(int.Parse);
            }

            input = CleanNewLines(input);

            var values = ExtractValues(input, ",");
            if (IsEmptyString(input))
                return 0;
            var sum = values.Length == 1 ? int.Parse(input) : 0;

            if (values.Length > 1) sum += values.Sum(int.Parse);

            return sum;
        }

        private static string GetNumbersWithDelimiter(string input, int endDelimiter)
        {
            return input.Substring(endDelimiter + 1);
        }

        private static string GetDelimiter(string input, int endDelimiter) => input[2..endDelimiter];

        private static bool HasDelimiter(string input) => input.StartsWith("//");

        private static string[] ExtractValues(string input, string delimiter) => input.Split(delimiter);

        private static string CleanNewLines(string input)
        {
            input = input.Replace("\n", ",");
            return input;
        }

        private static bool IsEmptyString(string input) => input == "";
    }
}