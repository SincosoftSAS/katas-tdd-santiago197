namespace Kata4
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            if (input == "")
                return 0;
            return int.Parse(input);
        }
    }
}