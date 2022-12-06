using System;

namespace Geometry
{
    public class Program : Object
    {
        private static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            Console.CursorVisible = false;
            Console.ResetColor();
            Console.Clear();
            
            Console.SetCursorPosition(0, 0);

            VectorImage image = new VectorImage();
            image.AddRectangle(5, 2, ConsoleColor.Red, ConsoleColor.Blue, 20, 7);
            image.AddRectangle(30, 1, ConsoleColor.DarkBlue, ConsoleColor.Black, 16, 18);
            image.AddCircle(22, 15, ConsoleColor.Yellow, ConsoleColor.Cyan, 9);
            image.AddCircle(46, 10, ConsoleColor.White, ConsoleColor.DarkGreen, 5);
            
            image.Draw();

            Console.ReadKey();
        }

        private static void TestBasicShapes()
        {
            Rectangle testRect1 = new Rectangle(3, 6, ConsoleColor.Red, ConsoleColor.White, 12, 6);



            Console.WriteLine(testRect1);
            Console.WriteLine("District: " + testRect1.GetPerimiter());
            Console.WriteLine("Area: " + testRect1.GetArea());
            testRect1.Hello();
            testRect1.Draw();
            Console.WriteLine(testRect1);

            Circle testCircle1 = new Circle(3, 6, ConsoleColor.Red, ConsoleColor.White, 1);
            Console.WriteLine(testCircle1);
            Console.WriteLine("District: " + testCircle1.GetPerimiter());
            Console.WriteLine("Area: " + testCircle1.GetArea());


            Shape shape1 = new Rectangle(3, 6, ConsoleColor.Red, ConsoleColor.White, 3, 4);
            Console.WriteLine(shape1);
            Console.WriteLine("District: " + shape1.GetPerimiter());
            Console.WriteLine("Area: " + shape1.GetArea());
            // ((Rectangle)testRect2).Hello();

            /*
            Shape testShape = new Shape();
            Console.WriteLine("District: " + testShape.GetPerimiter());
            Console.WriteLine("Area: " + testShape.GetArea());
            */
        }
    }
}
