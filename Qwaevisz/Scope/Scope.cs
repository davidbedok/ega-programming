using System;

namespace Qwaevisz
{
    public class Scope
    {
        private static void Main(string[] args)
        {
            string a = "kint";
            {
                string b = "bent";
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
            }
            System.Console.WriteLine(a);
            // System.Console.WriteLine(b);

            int index = 0;
            while (index < 10)
            {
                index++;
                int b = 20;
                System.Console.WriteLine(index);
                System.Console.WriteLine(b);
            }
            System.Console.WriteLine(index);
            // System.Console.WriteLine(b);

            for (int j = 0; j < 10; j++)
            {
                System.Console.WriteLine(j);
            }
            // System.Console.WriteLine(j);

            int i;
            for (i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine(i);
        }
    }
}
