using System;

namespace Qwaevisz
{
    public class Lottery
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a felhasználó hármaslottó szelvényének számait!");
            int userNumber1;
            int userNumber2;
            int userNumber3;
            
            do {
                Console.Write("1. szám: ");
                userNumber1 = Convert.ToInt32(Console.ReadLine());
            } while ( userNumber1 < 1 || userNumber1 > 10);
            
            do {
                Console.Write("2. szám: ");
                userNumber2 = Convert.ToInt32(Console.ReadLine());
            } while (userNumber2 < 1 || userNumber2 > 10 || userNumber2 == userNumber1);
            
            do {
                Console.Write("3. szám: ");
                userNumber3 = Convert.ToInt32(Console.ReadLine());
            } while (userNumber3 < 1 || userNumber3 > 10 || userNumber3 == userNumber1 || userNumber3 == userNumber2);
            
            Random lottery = new Random();
            int hits = 0;
            for ( int index = 0; index < 3; index++)
            {
                int drawnNumber = lottery.Next(0, 10) + 1;
                Console.WriteLine("Kihúzott szám: " + drawnNumber);
                if ( drawnNumber == userNumber1 || drawnNumber == userNumber2 || drawnNumber == userNumber3 )
                {
                    hits++;
                }
            }
            Console.WriteLine("A felhasználó által eltalált számok darabszáma: " + hits);
        }
    }
}
