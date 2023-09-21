/*
 * Zip Codes
 * Pawelski
 * 9/21/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * This is a very complex program! Given teh month, day,
 * and year of a date, this program reports the day of
 * the week that day occured on. If you are curious
 * on how to perform this calculation, check out this
 * website, https://cs.uwaterloo.ca/~alopez-o/math-faq/node73.html.
 * You might also find this website helpful as you need to
 * be able to determine if a year is a leap year as part
 * of the calculation, https://www.mathsisfun.com/leap-years.html.
 * Otherwise, how are switch statements and if statements used in 
 * this program?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekdays
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year, dayOfWeek, yearLastDigits, yearFirstDigits;

            // Get date information
            Console.Write("Enter the month (1 = January, 2 = February, etc.) >> ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the day >> ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the year >> ");
            year = Convert.ToInt32(Console.ReadLine());

            // Get last two and first two digits of the year
            yearLastDigits = year % 100;
            yearFirstDigits = year / 100;

            // Year code and day code
            dayOfWeek = yearLastDigits + yearLastDigits / 4 + day;

            // Month code
            switch(month)
            {
                case 1:
                    dayOfWeek += 1;
                    break;
                case 2:
                    dayOfWeek += 4;
                    break;
                case 3:
                    dayOfWeek += 4;
                    break;
                case 5:
                    dayOfWeek += 2;
                    break;
                case 6:
                    dayOfWeek += 5;
                    break;
                case 8:
                    dayOfWeek += 3;
                    break;
                case 9:
                    dayOfWeek += 6;
                    break;
                case 10:
                    dayOfWeek += 1;
                    break;
                case 11:
                    dayOfWeek += 4;
                    break;
                case 12:
                    dayOfWeek += 6;
                    break;
            }

            // Adjust for leap years
            if (year % 4 == 0 && (!(year % 100 == 0) || year % 400 == 0))
            {
                dayOfWeek -= 1;
            }

            // Century code
            switch(yearFirstDigits)
            {
                case 17:
                    dayOfWeek += 4;
                    break;
                case 18:
                    dayOfWeek += 2;
                    break;
                case 20:
                    dayOfWeek += 6;
                    break;
            }

            // Convert to actual day
            dayOfWeek %= 7;
            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine("Saturday");
                    break;
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Something went wrong!");
                    break;
            }
        }
    }
}
