using System;
using System.Collections.Generic;
using System.Text;

namespace HelloCar
{
    public class Car
    {

        private string name;
        private int km;

        public Car( string name )
        {
            this.name = name;
            this.km = 0;
        }

        public string GoTravel( Random generator, string startLocation, string destination )
        {
            int distance = generator.Next(10, 100);
            this.km += distance;
            return this.name + " elvitte utasait " + startLocation + "-ből " + destination + "-be, ami " + distance + " km utat jelent.";
        }

        public override string ToString()
        {
            return "A " + this.name + " futott km-e: " + this.km + " km";
        }


    }
}
