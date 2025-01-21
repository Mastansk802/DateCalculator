using System;

namespace DateCalculator
{
    public class CaclculateDate
    {
        static int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                return true;
            return false;
        }

        public void AddDaysToDate(ref int day, ref int month, ref int year, int numberOfDays)
        {
            // Handling leap year (february)
            if (IsLeapYear(year))
                daysInMonth[1] = 29;
            else
                daysInMonth[1] = 28;

            // Add the days
            day += numberOfDays;

            // Handle month and year overflow
            while (day > daysInMonth[month - 1])
            {
                day -= daysInMonth[month - 1];
                month++;

                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
        }
    }
}
