using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        private int limit;

        public PowerOfTwo(int limit)
        {
            this.limit = limit;
        }

        public void GenerateTable()
        {
            int power = 1;
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine("2 ^ " + i + " = " + power);
                power *= 2;
            }
        }
    }
}
