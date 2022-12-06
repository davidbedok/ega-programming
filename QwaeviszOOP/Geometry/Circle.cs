using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Circle : Shape
    {

        private readonly double r;

        public Circle(int centerX, int centerY, ConsoleColor lineColor, ConsoleColor backgroundColor, double r) : base(centerX, centerY, lineColor, backgroundColor)
        {
            this.r = r;
        }

        public override double GetPerimiter()
        {
            return 2 * r * Math.PI;
        }

        public override double GetArea()
        {
            return r * r * Math.PI;
        }

        public override string ToString()
        {
            return "Circle (r: " + r + ")";
        }

        public override void Draw()
        {

            int x1 = Convert.ToInt32(this.x - r) - 1;
            int y1 = Convert.ToInt32(this.y - r) - 1;
            int x2 = Convert.ToInt32(this.x + r) + 1;
            int y2 = Convert.ToInt32(this.y + r) + 1;

            double epsilon = 0.5;

            for (int i = x1; i < x2; i++)
            {
                for (int j = y1; j < y2; j++)
                {
                    int a = Math.Abs(Convert.ToInt32(this.x - i));
                    int b = Math.Abs(Convert.ToInt32(this.y - j));
                    double c = Math.Sqrt(a * a + b * b);

                    if ( this.r > (c  - epsilon) && this.r < ( c + epsilon) )
                    {
                        Console.ForegroundColor = this.lineColor;
                        Console.SetCursorPosition(i, j);
                        Console.Write('█');
                    } else if (this.r > (c - epsilon))
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
