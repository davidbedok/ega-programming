using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public abstract class Shape : Object
    {

        protected int x;
        protected int y;
        protected ConsoleColor lineColor;
        protected ConsoleColor backgroundColor;

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
