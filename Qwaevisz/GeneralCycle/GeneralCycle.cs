using System;

namespace Qwaevisz
{
    public class GeneralCycle
    {
        private static void Main(string[] args)
        {
            Console.Write("Adjon meg egy egész számot 10 és 20 között: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while ( number < 10 || number > 20 )
            {
                Console.WriteLine("A megadott szám helytelen!");
                Console.Write("Adjon meg egy egész számot 10 és 20 között: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Hurrá! A megadott szám 10 és 20 közötti egész szám!");
        }
    }
}
