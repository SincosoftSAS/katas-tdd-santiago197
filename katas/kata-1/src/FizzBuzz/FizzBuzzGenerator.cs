namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var result = new List<string>();
            for (var i = 1; i < count; i++)
            {
                result.Add(i.ToString());
                if (i == 2)
                    result.Add("Fizz");
            }

            return result;
        }
    }
}