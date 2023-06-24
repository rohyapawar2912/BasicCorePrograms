using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        private int year;

        public LeapYear(int year)
        {
            this.year = year;
        }

        public bool IsLeapYear()
        {
            // Check if the year is divisible by 4
            bool divisibleBy4 = year % 4 == 0;

            // Check if the year is divisible by 100
            bool divisibleBy100 = year % 100 == 0;

            // Check if the year is divisible by 400
            bool divisibleBy400 = year % 400 == 0;

            // Determine if it is a leap year based on the above conditions
            return (divisibleBy4 && !divisibleBy100) || divisibleBy400;
        }
    }
}
