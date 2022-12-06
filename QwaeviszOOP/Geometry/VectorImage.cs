using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class VectorImage : Object
    {
        private const int MAXIMUM_NUMBER_OF_SHAPES = 10;

        // private readonly Rectangle[] rectangles;
        // private readonly Circle[] circles;
        // private int rectangleIndex;
        // private int circleIndex;

        private readonly Shape[] shapes;
        private int shapeIndex;

        public VectorImage()
        {
            // this.rectangles = new Rectangle[MAXIMUM_NUMBER_OF_SHAPES];
            // this.circles = new Circle[MAXIMUM_NUMBER_OF_SHAPES];
            this.shapes = new Shape[MAXIMUM_NUMBER_OF_SHAPES];
        }
        public void AddRectangle(int topLeftX, int topLeftY, ConsoleColor lineColor, ConsoleColor backgroundColor, int a, int b) 
        {
            // this.rectangles[this.rectangleIndex++] = new Rectangle(a, b);
            this.shapes[this.shapeIndex++] = new Rectangle(topLeftX, topLeftY, lineColor, backgroundColor, a, b);
        }

        public void AddCircle(int centerX, int centerY, ConsoleColor lineColor, ConsoleColor backgroundColor, int r )
        {
            // this.circles[this.circleIndex++] = new Circle(r);
            this.shapes[this.shapeIndex++] = new Circle(centerX, centerY, lineColor, backgroundColor, r);
        }

        public double GetPerimiter()
        {
            double result = 0;
            /*
            for ( int i = 0; i < this.rectangleIndex; i++)
            {
                result += this.rectangles[i].GetDistrict();
            }
            for (int i = 0; i < this.circleIndex; i++)
            {
                result += this.circles[i].GetDistrict();
            }
            */
            for (int i = 0; i < this.shapeIndex; i++)
            {
                result += this.shapes[i].GetPerimiter();
            }
            return result;
        }

        public double GetArea()
        {
            double result = 0;
            /*
            for (int i = 0; i < this.rectangleIndex; i++)
            {
                result += this.rectangles[i].GetArea();
            }
            for (int i = 0; i < this.circleIndex; i++)
            {
                result += this.circles[i].GetArea();
            }
            */
            for (int i = 0; i < this.shapeIndex; i++)
            {
                result += this.shapes[i].GetArea();
            }
            return result;
        }


        public void Draw()
        {
            for (int i = 0; i < this.shapeIndex; i++)
            {
                this.shapes[i].Draw();
            }
        }

    }
}
