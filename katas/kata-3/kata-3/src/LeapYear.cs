namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            var isLeapYear = false;
            isLeapYear = EsDivisiblePor400(year) || EsDivisiblePor4(year);
            return isLeapYear;
        }

        private static bool EsDivisiblePor4(int year) => year % 4 == 0;

        private static bool EsDivisiblePor400(int year) => year % 400 == 0;
    }
}