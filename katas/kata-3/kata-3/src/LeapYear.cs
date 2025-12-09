namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            var isLeapYear = false;
            if (year % 100 == 0 && !EsDivisiblePor400(year))
                isLeapYear = false;
            else
                isLeapYear = EsDivisiblePor400(year) || EsDivisiblePor4(year);
            return isLeapYear;
        }

        private static bool EsDivisiblePor4(int year) => year % 4 == 0;

        private static bool EsDivisiblePor400(int year) => year % 400 == 0;
    }
}