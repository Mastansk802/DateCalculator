using DateCalculator;
using System;

class Program
{
    // Array representing the number of days in each month (non-leap year).
    static int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    static void Main(string[] args)
    {
        // Date as inoput
        Console.Write("Enter a date (dd/mm/yyyy): ");
        string inputDate = Console.ReadLine();

        //days to add for given date
        Console.Write("Enter number of days to add: ");
        int numberOfDays;
        while (!int.TryParse(Console.ReadLine(), out numberOfDays))
        {
            Console.Write("Please enter a valid number for days: ");
        }

        // Parsing the input date (dd/mm/yyyy)
        string[] dateParts = inputDate.Split('/');
        if (dateParts.Length != 3)
        {
            Console.WriteLine("Invalid date format. Please enter a date in dd/mm/yyyy format.");
            return;
        }
        CaclculateDate caclculateDate = new CaclculateDate();
        int day, month, year;
        if (!int.TryParse(dateParts[0], out day) || !int.TryParse(dateParts[1], out month) || !int.TryParse(dateParts[2], out year))
        {
            Console.WriteLine("Invalid date format. Please enter valid numeric values.");
            return;
        }

        // Validate the month and day range
        if (month < 1 || month > 12 || day < 1 || day > daysInMonth[month - 1])
        {
            Console.WriteLine("Invalid date. Please check the day and month.");
            return;
        }

        // Add the specified days to the date
        caclculateDate.AddDaysToDate(ref day, ref month, ref year, numberOfDays);

        // Output the result
        Console.WriteLine($"New date after adding {numberOfDays} days: {day:D2}/{month:D2}/{year}");
    }
}
