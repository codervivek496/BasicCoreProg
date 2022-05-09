using System;

namespace basicCoreProg
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the choice");
            Console.WriteLine(" 1. Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine(" 2. Leap Year");
            Console.WriteLine(" 3. Power of 2");
            Console.WriteLine(" 4. Harmonic Number");
            Console.WriteLine(" 5. Factors");
            Console.WriteLine(" 6. Quotient and Remainder");
            Console.WriteLine(" 7. Swap Two Numbers");
            Console.WriteLine(" 8. Even or Odd");
            Console.WriteLine(" 9. Alphabet is Vowel or Consonant");
            Console.WriteLine("10. Largest Among Three Numbers");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    flipCoin basicCore = new flipCoin();
                    basicCore.coin();
                    break;
                case 2:
                    leapYear leapYear = new leapYear();
                    leapYear.year();
                    break;
                case 3:
                    powerOf2 powerof2 = new powerOf2();
                    powerof2.power();
                    break;
                case 4:
                    HarmonicNum harmonicNum = new HarmonicNum();
                    harmonicNum.harmonic();
                    break;
                case 5:
                    Factors factors = new Factors();
                    factors.primeFactors();
                    break;
                case 6:
                    QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                    quotientAndRemainder.quotientRemainder();
                    break;
                case 7:
                    SwapTwoNum swapTwoNum = new SwapTwoNum();
                    swapTwoNum.swap();
                    break;
                case 8:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.EvenOdd();
                    break;
                case 9:
                    VowelOrConstant vowelOrConstant = new VowelOrConstant();
                    vowelOrConstant.VowelConstant();
                    break;
                case 10:
                    LargestAmong3num largestAmong3num = new LargestAmong3num();
                    largestAmong3num.Largest();
                    break;
                    default:
                    Console.WriteLine("Please enter the correct choice");
                    break;
            }
        }
    }
}
    