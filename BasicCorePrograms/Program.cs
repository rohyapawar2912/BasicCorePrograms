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
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine("Invalid input. Number must be greater than 1.");
                return;
            }

            Factor factors = new Factor(number);
            factors.ComputePrimeFactors();
        }
    }
}
