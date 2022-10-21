using System;

namespace HelloCar
{
    public class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();

            string car1Name = "Dacia Duster 1.6";
            int car1km = 0;
            Console.WriteLine("A " + car1Name + " futott km-e: " + car1km + " km");
            
            car1km += GoTravel(generator, car1Name, "Siófok", "Budapest");
            Console.WriteLine("A " + car1Name + " futott km-e: " + car1km + " km");
            
            string car2Name = "Rover 45";
            int car2km = 0;
            Console.WriteLine("A " + car2Name + " futott km-e: " + car2km + " km");

            car2km += GoTravel(generator, car2Name, "Siófok", "Budapest");
            Console.WriteLine("A " + car2Name + " futott km-e: " + car2km + " km");

            car1km += GoTravel(generator, car1Name, "Ajka", "Szeged");
            Console.WriteLine("A " + car1Name + " futott km-e: " + car1km + " km");

            car2km += GoTravel(generator, car2Name, "Ajka", "Szeged");
            Console.WriteLine("A " + car2Name + " futott km-e: " + car2km + " km");

            Car car1;
            car1 = new Car("Dacia Duster 1.6");
            Car car2 = new Car("Rover 45");
            
            car1.GoTravel(generator, "Siófok", "Budapest");
            car2.GoTravel(generator, "Siófok", "Budapest");

            car1.GoTravel(generator, "Ajka", "Szeged");
            Console.WriteLine(car2.GoTravel(generator, "Ajka", "Szeged"));

            Console.WriteLine(car1);
            Console.WriteLine(car2);

        }


        private static int GoTravel(Random generator, string car, string startLocation, string destination )
        {
            int km = generator.Next(10, 100);
            Console.WriteLine(car + " elvitte utasait " + startLocation + "-ből " + destination + "-be, ami "+ km + " km utat jelent.");
            return km;
        }


    }
}
