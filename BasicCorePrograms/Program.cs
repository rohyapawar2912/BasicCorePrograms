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
            Console.WriteLine("Enter the power value (0 to 30):");
            int power = int.Parse(Console.ReadLine());

            if (power < 0 || power > 30)
            {
                Console.WriteLine("Invalid input. Power value must be between 0 and 30.");
                return;
            }

            PowerOfTwo powerOf2 = new PowerOfTwo(power);
            powerOf2.GenerateTable();
        }
    }
}
