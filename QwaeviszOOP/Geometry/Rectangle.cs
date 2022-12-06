using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Rectangle : Shape
    {

        private readonly double width;
        private readonly double height;

        private int TopLeftX
        {
            get { return this.x; }
        }

        private int TopLeftY
        {
            get { return this.y; }
        }

        public Rectangle(int topLeftX, int topLeftY, ConsoleColor lineColor, ConsoleColor backgroundColor, double width, double height) : base(topLeftX, topLeftY, lineColor, backgroundColor)
        {
            this.width = width;
            this.height = height;
        }
 
        public override double GetPerimiter()
        {
            return 2 * (width + height);
        }

        public override double GetArea()
        {
            return width * height;
        }

        public void Hello()
        {
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Rectangle (a: " + width + ", b: " + height + ")";
        }

        public override void Draw()
        {
            int x2 = Convert.ToInt32(this.TopLeftX + width);
            int y2 = Convert.ToInt32(this.TopLeftY + height);

            for (int i = this.TopLeftX; i < x2; i++)
            {
                for (int j = this.TopLeftY; j < y2; j++)
                {
                    if ( i == this.TopLeftX || i == (x2 - 1) || j == this.TopLeftY || j == (y2 - 1 ) )
                    {
                        Console.ForegroundColor = this.lineColor;
                        Console.SetCursorPosition(i, j);
                        Console.Write('█');
                    } else if (i > this.TopLeftX && i < (x2 - 1) && j > this.TopLeftY && j < (y2 - 1))
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
