using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCoreProg
{
    public class QuotientAndRemainder
    {
        public void quotientRemainder()
        {
            Console.Write("Enter the dividend number to calculate the Quotiend and Remainder : ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            //Quotient logic
            int quotient = dividend / divisor;

            //Remainder logic
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient is : {0}", quotient);
            Console.WriteLine("Remainder is : {0}", remainder);
        }
    }
}
