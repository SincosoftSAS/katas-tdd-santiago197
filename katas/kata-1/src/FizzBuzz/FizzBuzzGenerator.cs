namespace FizzBuzz
{
    public static class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
          throw new Exception("FizzBuzzGenerator generation not implemented");
        }

        private static bool IsMultipleOf(int number, int multiple) => number % multiple == 0;
    }
}