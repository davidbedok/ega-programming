using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Circle : Shape
    {

        private readonly double radius;

        private int CenterX
        {
            get { return this.x; }
        }

        private int CenterY
        {
            get { return this.y; }
        }

        public Circle(int centerX, int centerY, ConsoleColor lineColor, ConsoleColor backgroundColor, double radius) : base(centerX, centerY, lineColor, backgroundColor)
        {
            this.radius = radius;
        }

        public override double GetPerimiter()
        {
            return 2 * radius * Math.PI;
        }

        public override double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public override string ToString()
        {
            return "Circle (r: " + radius + ")";
        }

        public override void Draw()
        {

            int x1 = Convert.ToInt32(this.CenterX - radius) - 1;
            int y1 = Convert.ToInt32(this.CenterY - radius) - 1;
            int x2 = Convert.ToInt32(this.CenterX + radius) + 1;
            int y2 = Convert.ToInt32(this.CenterY + radius) + 1;

            double epsilon = 0.5;

            for (int i = x1; i < x2; i++)
            {
                for (int j = y1; j < y2; j++)
                {
                    int a = Math.Abs(Convert.ToInt32(this.CenterX - i));
                    int b = Math.Abs(Convert.ToInt32(this.CenterY - j));
                    double c = Math.Sqrt(a * a + b * b);

                    if ( this.radius > (c  - epsilon) && this.radius < ( c + epsilon) )
                    {
                        Console.ForegroundColor = this.lineColor;
                        Console.SetCursorPosition(i, j);
                        Console.Write('█');
                    } else if (this.radius > (c - epsilon))
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
