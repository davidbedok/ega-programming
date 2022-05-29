using System;

namespace Qwaevisz
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Test();
            CompareSearchPerformanceSingleElement();
            CompareSearchPerformanceMultipleElement();
        }

        private static void Test()
        {
            int[] numbers = Utility.GenerateNumbers(10);
            Utility.PrintNumbers("A létrehozott tömb elemei", numbers);

            Console.Write("Melyik elemet keressük? ");
            int element = Convert.ToInt32(Console.ReadLine());

            int searchResult = Search.LinearSearch(numbers, element);
            if (searchResult >= 0)
            {
                Console.WriteLine("A keresett elem indexe: " + searchResult);
                Console.WriteLine("A keresett elem: " + numbers[searchResult]);
            }
            else
            {
                Console.WriteLine("A keresett elem nem található meg a sorozatban.");
            }

            // Sort.BubbleSort(numbers);
            Sort.MinimumSelectionSort(numbers);
            Utility.PrintNumbers("A létrehozott tömb rendezett elemei", numbers);

            searchResult = Search.BinarySearch(numbers, element);
            if (searchResult >= 0)
            {
                Console.WriteLine("A keresett elem indexe: " + searchResult);
                Console.WriteLine("A keresett elem: " + numbers[searchResult]);
            }
            else
            {
                Console.WriteLine("A keresett elem nem található meg a sorozatban.");
            }

        }

        private static void CompareSearchPerformanceSingleElement()
        {
            Random generator = new Random();
            int numberOfElements = 10000;
            int min = -5000000;
            int max = 5000000;
            int[] numbers = Utility.GenerateNumbers(numberOfElements, min, max);

            int element = generator.Next(min, max);
            long startMillis = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Search.LinearSearch(numbers, element);
            long endMillis = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Console.WriteLine("Linearis keresés futási ideje: " + ( endMillis - startMillis ) + " ms");

            startMillis = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            // Sort.BubbleSort(numbers);
            Sort.MinimumSelectionSort(numbers);
            Search.BinarySearch(numbers, element);
            endMillis = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Console.WriteLine("Binaris keresés futási ideje: " + (endMillis - startMillis) + " ms");
        }

        private static void CompareSearchPerformanceMultipleElement()
        {
            Random generator = new Random();
            int numberOfElements = 50000;
            int min = -5000000;
            int max = 5000000;
            int[] numbers = Utility.GenerateNumbers(numberOfElements, min, max);


            int numberOfSearchedElements = 1000;
            int[] elements = Utility.GenerateNumbers(numberOfSearchedElements, min, max);

            long startMillis = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            for (int i = 0; i < elements.Length; i++)
            {
                Search.LinearSearch(numbers, elements[i]);
            }
            long endMillis = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Console.WriteLine("Linearis keresés futási ideje ("+ numberOfSearchedElements + " elem): " + (endMillis - startMillis) + " ms");

            startMillis = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            // Sort.BubbleSort(numbers);
            Sort.MinimumSelectionSort(numbers);
            long startMillisAfterSort = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            for (int i = 0; i < elements.Length; i++)
            {
                Search.BinarySearch(numbers, elements[i]);
            }
            endMillis = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Console.WriteLine("Binaris keresés futási ideje rendezéssel együtt (" + numberOfSearchedElements + " elem): " + (endMillis - startMillis) + " ms");
            Console.WriteLine("Binaris keresés futási ideje rendezés ideje nélkül (" + numberOfSearchedElements + " elem): " + (endMillis - startMillisAfterSort) + " ms");
        }

    }
}
