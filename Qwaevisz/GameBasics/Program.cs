using System;
using System.IO;

namespace Qwaevisz
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int left = 10;
            int top = 5;

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(left, top);
                Console.Write("X");
                
                switch ( keyInfo.Key )
                {
                    case ConsoleKey.RightArrow:
                        left++;
                        break;
                    case ConsoleKey.LeftArrow:
                        left--;
                        break;
                    case ConsoleKey.UpArrow:
                        top--;
                        break;
                    case ConsoleKey.DownArrow:
                        top++;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(left, top);
                Console.Write("X");
            } while (keyInfo.Key != ConsoleKey.Escape);

            Console.ResetColor();

        }

        private static void colors()
        {
            Console.Title = "Hello";

            loadFile2(@"input\lorem.txt");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zöld felirat");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Fekete felirat sárga háttérrel");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(8, 8);
            Console.Write(" 1 ");
            Console.SetCursorPosition(6, 6);
            Console.Write(" 2 ");
            Console.SetCursorPosition(4, 4);
            Console.Write(" 3 ");

            Console.CursorVisible = false;
            Console.ReadLine();

            Console.SetCursorPosition(0, 10);
            // Set to default..
            Console.ResetColor();
        }

        private static void loadFile( String path)
        {
            // string fullPath = AppDomain.CurrentDomain.BaseDirectory + path;
            string fullPath = path;
            if (System.IO.File.Exists(fullPath))
            {
                StreamReader reader = System.IO.File.OpenText(fullPath);

                string line = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                reader.Close();

            } else
            {
                Console.WriteLine("A file nem letezik ("+ fullPath + ")");
            }


        }

        private static void loadFile2(String path)
        {
            string fullPath = path;
            if (System.IO.File.Exists(fullPath))
            {
                StreamReader reader = File.OpenText(path);
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("A file nem letezik (" + fullPath + ")");
            }
        }

        private static void loadFile3(String path)
        {
            string fullPath = path;
            if (System.IO.File.Exists(fullPath))
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("A file nem letezik (" + fullPath + ")");
            }
        }

    }
}
