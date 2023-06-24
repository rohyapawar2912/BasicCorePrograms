using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class CoinFlip
    {
        private int numFlips;
        private Random random;

        public CoinFlip(int numFlips)
        {
            this.numFlips = numFlips;
            random = new Random();
        }

        public void FlipCoin()
        {
            int headsCount = 0;
            int tailsCount = 0;

            for (int i = 0; i < numFlips; i++)
            {
                // Generate a random value between 0 and 1
                double randomValue = random.NextDouble();

                if (randomValue < 0.5)
                {
                    tailsCount++;
                    Console.WriteLine("Tails");
                }
                else
                {
                    headsCount++;
                    Console.WriteLine("Heads");
                }
            }

            // Calculate the percentage of heads and tails
            double headsPercentage = (double)headsCount / numFlips * 100;
            double tailsPercentage = (double)tailsCount / numFlips * 100;

            Console.WriteLine("Percentage of Heads: " + headsPercentage.ToString("0.00") + "%");
            Console.WriteLine("Percentage of Tails: " + tailsPercentage.ToString("0.00") + "%");
        }
    }
}
