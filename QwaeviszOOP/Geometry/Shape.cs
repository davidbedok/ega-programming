using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public abstract class Shape : Object
    {

        protected readonly int x;
        protected readonly int y;
        protected readonly ConsoleColor lineColor;
        protected readonly ConsoleColor backgroundColor;

        public Shape(int x, int y, ConsoleColor lineColor, ConsoleColor backgroundColor)
        {
            this.x = x;
            this.y = y;
            this.lineColor = lineColor;
            this.backgroundColor = backgroundColor;
        }

        public virtual double GetPerimiter()
        {
            return 0;
        }

        public abstract double GetArea();

        public abstract void Draw();
        
    }
}
