using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCoreProg
{
    public class flipCoin
    {
        public void coin()
        {
            int result;
            int heads = 0;
            int tails = 0;

            Random random = new Random();

            //****Taking Inputs*****
            Console.Write("Enter the number of times you want to flip the coin: ");
            int flip = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < flip; i++)
            {
                result = random.Next(0, 2);

                if (result < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }
            Console.WriteLine("Heads flipped {0} times", tails);
            Console.WriteLine("Tails flipped {0} times", heads);

            //*******Calculating percentage of Head and Tails

            double percentHeads = (float)heads / (float)flip * 100;
            double percentTails = (float)tails / (float)flip * 100;
            Console.WriteLine("Percentage of Head vs Tails is:  {0}% : {1}% ", percentHeads, percentTails);
        }
    }
}