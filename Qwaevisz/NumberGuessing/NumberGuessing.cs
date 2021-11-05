using System;

namespace Qwaevisz
{
    public class NumberGuessing
    {
        private static void Main(string[] args)
        {
            Random generator = new Random();
            bool endOfGame = false;
            int numberOfAttempts = 5;
            while (!endOfGame)
            {
                Console.WriteLine();
                Console.WriteLine("Válasszon az alábbi menüpontok közül:");
                Console.WriteLine("(n) Új játék");
                Console.WriteLine("(x) Kilépés");
                char selection = Console.ReadKey(true).KeyChar;
                if (selection == 'n' || selection == 'x')
                {
                    if ( selection == 'n' )
                    {
                        int tip = -1;
                        int number = generator.Next(100) + 1;
                        Console.WriteLine();
                        Console.WriteLine("Kitaláltam egy egész számot 1 és 100 között. Találd ki legfeljebb " + numberOfAttempts  + " lépésből!");
                        int index = 0;
                        while ( tip != number && index < numberOfAttempts)
                        {
                            Console.Write((index + 1) + ". tipp: ");
                            tip = Convert.ToInt32(Console.ReadLine());
                            if ( tip > number )
                            {
                                Console.WriteLine("Nem talált! Kisebb számra gondoltam.");
                            } else if ( tip < number )
                            {
                                Console.WriteLine("Nem talált! Nagyobb számra gondoltam.");
                            }
                            index++;
                        }
                        if ( tip != number && index == numberOfAttempts)
                        {
                            Console.WriteLine("Sajnos nem találtad ki :( A megoldás a " + number + " szám lett volna!");
                        } else
                        {
                            Console.WriteLine("Gratulálok, kitaláltad :) Pontosan erre a számra gondoltam!");
                        }
                    } else
                    {
                        endOfGame = true;
                    }
                }
            }
        }
    }
}
