using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year (4 digits):");
            int year = int.Parse(Console.ReadLine());

            if (year < 1000 || year > 9999)
            {
                Console.WriteLine("Invalid input. Year must be a 4-digit number.");
                return;
            }

            LeapYear leapYear = new LeapYear(year);

            if (leapYear.IsLeapYear())
                Console.WriteLine(year + " is a Leap Year.");
            else
                Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}
