namespace Kata4
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            var values = input.Split(',');
            if (input == "")
                return 0;
            if (values.Length > 1)
                return int.Parse(values[0]) + int.Parse(values[1]);
            return int.Parse(input);
        }
    }
}