namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            var isLeapYear = false;
            isLeapYear = year % 400 == 0 || year % 4 == 0;
            return isLeapYear;
        }
    }
}