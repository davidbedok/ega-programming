using System;

namespace Qwaevisz
{
    public class SimpleMenu
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("(a): alma");
            Console.WriteLine("(b): körte");
            Console.WriteLine("(c): barack");
            Console.Write("Válasszon a fenti menüpontok közül (pl. b): ");
            char selection = Convert.ToChar(Console.Read());
            if ( selection == 'a' || selection == 'b')
            {
                Console.WriteLine("Választott gyümölcs: alma vagy körte");
            } else if ( selection == 'c')
            {
                Console.WriteLine("Választott gyümölcs: barack");
            } else
            {
                Console.WriteLine("Ismeretlen gyümölcsöt választott!");
            }
        }
    }
}
