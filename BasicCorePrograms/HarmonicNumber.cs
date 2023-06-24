using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        private int value;

        public HarmonicNumber(int value)
        {
            this.value = value;
        }

        public double CalculateHarmonicNumber()
        {
            double sum = 0;
            for (int i = 1; i <= value; i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }
    }
}
