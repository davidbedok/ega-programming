using System;

namespace HelloClass
{
    public class Program
    {
        private static void Main(string[] args)
        {

            string joeName = "John Doe";
            int joeYearOfBirth = 1995;
            Console.WriteLine(joeName + " " + GetPersonAge(joeYearOfBirth) + " éves.");


            Person joe = new Person("John", "Doe");
            joe.SetYearOfBirth(1995);
            Console.WriteLine(joe.GetName() + " " + joe.GetAge() + " éves.");

            Person sue = new Person("Sue", "Darling");
            sue.SetYearOfBirth(1997);
            Console.WriteLine(sue.GetName() + " " + sue.GetAge() + " éves.");


        }


        private static int GetPersonAge( int personYearOfBirth ) {
            return 2022 - personYearOfBirth;
        }

    }
}
