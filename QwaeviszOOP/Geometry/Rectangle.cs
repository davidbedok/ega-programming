using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Rectangle : Shape
    {

        private readonly double a;
        private readonly double b;

        public Rectangle(int topLeftX, int topLeftY, ConsoleColor lineColor, ConsoleColor backgroundColor, double a, double b) : base(topLeftX, topLeftY, lineColor, backgroundColor)
        {
            this.a = a;
            this.b = b;
        }
 
        public override double GetPerimiter()
        {
            return 2 * (a + b);
        }

        public override double GetArea()
        {
            return a * b;
        }

        public void Hello()
        {
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Rectangle (a: " + a + ", b: " + b + ")";
        }

        public override void Draw()
        {
            int x2 = Convert.ToInt32(this.x + a);
            int y2 = Convert.ToInt32(this.y + b);

            for (int i = this.x; i < x2; i++)
            {
                for (int j = this.y; j < y2; j++)
                {
                    if ( i == this.x || i == (x2 - 1) || j == this.y || j == (y2 - 1 ) )
                    {
                        Console.ForegroundColor = this.lineColor;
                        Console.SetCursorPosition(i, j);
                        Console.Write('█');
                    } else if (i > this.x && i < (x2 - 1) && j > this.y && j < (y2 - 1))
                    {
                        Console.ForegroundColor = this.backgroundColor;
                        Console.SetCursorPosition(i, j);
                        Console.Write('█');
                    }
                }
            }
        }

    }
}
