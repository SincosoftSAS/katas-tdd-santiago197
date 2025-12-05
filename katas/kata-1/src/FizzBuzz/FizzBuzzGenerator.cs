namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var result = new List<string>();
            for (var i = 1; i <= count; i++)
            {
                if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i == 5)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }

            return result;
        }
    }
}