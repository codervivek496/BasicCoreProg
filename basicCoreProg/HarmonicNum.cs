using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCoreProg
{
    public class HarmonicNum
    {
        public void harmonic()
        {
            Console.Write("Enter the value of N to calculate Nth Harmonic Value : ");
            int N = Convert.ToInt32(Console.ReadLine());
            double harmonicNumber = 0;
            if (N > 0)
            {
                //Harmonic Number logic
                for (double i = 1; i <= N; i++)
                {
                    harmonicNumber += 1 / i;
                }
                Console.WriteLine("{0}th Harmonic Number is : {1}", N, harmonicNumber);
            }
            else
            {
                Console.WriteLine("Entered number is negative");
            }

        }
    }
}
