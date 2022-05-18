using System;

namespace BenfordsLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int[] result = new int[10];

            int max = 100000;

            for (int i = 0; i < max; i++)
            {
                // int number = generator.Next(1, 1000000);
                int number = i;
                // double value = Math.Sqrt(number);
                // double value = Math.Pow(2, number);
                double value = Math.Pow(number, 2);

                char[] digits = ("" + value).ToCharArray();
                
                int firstDigit = Int32.Parse("" + digits[0]);
                Console.WriteLine(number + " --> " + value + " --> " + firstDigit);
                result[firstDigit]++;
            }

            for ( int i = 1; i < result.Length; i++ )
            {
                double avg = (double)result[i] / max * 100;
                Console.WriteLine( i + " --> " + result[i] + " ("+avg+" %)");
            }

        }
    }
}
