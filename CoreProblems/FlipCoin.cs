using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    internal class FlipCoin
    {
        int Head = 0;
        int Tail = 0;
        public void Flip()
        {
            int headCount = 0, tailCount = 0;
            Double PercentageOfHead, PercentageOfTail;

            Console.WriteLine("Enter a number of times you want to flip a coin");
            int num =Convert.ToInt32(Console.ReadLine());
            int i=0;
            while (num!= i)
            {
                Random random = new Random();
                int tossCheck = random.Next(0, 2);
                if (tossCheck == Head)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
                i++;

                Console.WriteLine("Total number of Tail occour: " + tailCount);
                Console.WriteLine("Total number of Head occour: " + headCount);

                PercentageOfHead = (double)headCount / num * 100;
                PercentageOfTail = (double)tailCount / num * 100;

                Console.WriteLine("Percentage of Tail : " + PercentageOfTail);
                Console.WriteLine("Percentage of Head : " + PercentageOfHead);

            }
        }

    }
}