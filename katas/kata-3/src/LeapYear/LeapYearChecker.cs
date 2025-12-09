namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            return !NoEsBisiesto(year) && EsBisiesto(year);
        }

        private static bool EsBisiesto(int year) => EsDivisiblePor400(year) || EsDivisiblePor4(year);

        private static bool NoEsBisiesto(int year) => EsDivisiblePor100(year) && !EsDivisiblePor400(year);

        private static bool EsDivisiblePor100(int year) => year % 100 == 0;

        private static bool EsDivisiblePor4(int year) => year % 4 == 0;

        private static bool EsDivisiblePor400(int year) => year % 400 == 0;
    }
}
