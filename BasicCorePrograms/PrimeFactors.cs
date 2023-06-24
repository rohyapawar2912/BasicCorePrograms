using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Factor
    {
        private int number;

        public Factor(int number)
        {
            this.number = number;
        }

        public void ComputePrimeFactors()
        {
            Console.WriteLine("Prime factors of " + number + ":");
            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }

            if (number > 1)
            {
                Console.WriteLine(number);
            }
        }
    }
}
