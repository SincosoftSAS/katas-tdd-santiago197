namespace FizzBuzz
{
    public static class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var result = new List<string>();
            for (var number = 1; number <= count; number++)
            {
                var text = "";
                if (IsMultipleOf(number, 3)) text += "Fizz";
                if (IsMultipleOf(number, 5)) text += "Buzz";

                result.Add(BuildText(text, number));
            }

            return result;
        }

        private static string BuildText(string text, int number) => text == "" ? number.ToString() : text;

        private static bool IsMultipleOf(int number, int multiple) => number % multiple == 0;
    }
}