using System;
using System.Collections.Generic;
using System.Text;

namespace Qwaevisz
{
    public class Program
    {

        private static void Main( string[] args )
        {
            int[] numbers = Utility.GenerateNumbers(10);
            Utility.PrintNumbers("A létrehozott tömb elemei", numbers);

            Console.WriteLine("== KIVÁLOGATÁS ==");
            Utility.PrintNumbers("Pozitív elemek (for)", Assortment.AssortPositiveNumbers(numbers));
            Utility.PrintNumbers("Pozitív elemek (while)", Assortment.AssortPositiveNumbersMod(numbers));
            Console.WriteLine();

            
            Console.WriteLine("== SZÉTVÁLOGATÁS ==");
            int[][] sortedOutNumbers = SortOut.SortOutNumbersByPositivity(numbers);
            Utility.PrintNumbers("Pozitív elemek", sortedOutNumbers[0]);
            Utility.PrintNumbers("Negatív elemek", sortedOutNumbers[1]);
        }

    }
}
