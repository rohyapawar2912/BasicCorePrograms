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
            Console.WriteLine("Enter the number of times to flip the coin:");
            int numFlips = int.Parse(Console.ReadLine());

            if (numFlips <= 0)
            {
                Console.WriteLine("Invalid input. Number of flips must be a positive integer.");
                return;
            }

            CoinFlip coinFlip = new CoinFlip(numFlips);
            coinFlip.FlipCoin();
        }
    }
}
