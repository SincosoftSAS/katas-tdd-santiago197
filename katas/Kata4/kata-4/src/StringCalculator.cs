namespace Kata4
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            var values = input.Split(',');
            if (input == "")
                return 0;
            var sum = values.Length == 1 ? int.Parse(input) : 0;

            if (values.Length > 1)
                foreach (var number in values)
                {
                    sum += int.Parse(number);
                }


            return sum;
        }
    }
}