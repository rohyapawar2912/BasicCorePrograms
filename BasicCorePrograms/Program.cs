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
            Console.WriteLine("Enter the harmonic value (N):");
            int value = int.Parse(Console.ReadLine());

            if (value <= 0)
            {
                Console.WriteLine("Invalid input. Harmonic value (N) must be a positive integer.");
                return;
            }

            HarmonicNumber harmonicNumber = new HarmonicNumber(value);
            double result = harmonicNumber.CalculateHarmonicNumber();

            Console.WriteLine("The Nth Harmonic Value: " + result);
        }
    }
}
