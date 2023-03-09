using System;
using System.Net.WebSockets;
using System.Threading;

namespace StaticKeyword
{
    public class Program
    {
      
        private static void Main(string[] args)
        {

            Console.WriteLine("Number of Person instances? " + Person.GlobalGetNumberOfPeople());

            PersonConfig config = PersonConfig.GetInstance();
            config.SetFactorA(42);
            config.SetFactorB("Lorem ipsum");

            Person bela = new Person("Bela", 13);

            Person joe = new Person("Joe", 17);
            Person sue = new Person("Sue", 19);

            People collection = new People();
            collection.AddPerson(joe);
            collection.AddPerson(sue);

            Console.WriteLine("DD" + config.GetFactorB());

            Console.WriteLine("Number of Person instances before Karoly? " + Person.GlobalGetNumberOfPeople());
            bela = new Person("Karoly", 25);
            Console.WriteLine("Number of Person instances after Karoly? " + Person.GlobalGetNumberOfPeople());

            PersonConfig config2 = PersonConfig.GetInstance();
            Console.WriteLine("DD" + config2.GetFactorB());

            Console.WriteLine("Number of Person instances? " + collection.GetNumberOfPeople());
            Console.WriteLine("Number of Person instances? " + joe.GetNumberOfPeople());
            Console.WriteLine("Number of Person instances? " + sue.GetNumberOfPeople());
            Console.WriteLine("Number of Person instances? " + bela.GetNumberOfPeople());
            Console.WriteLine("Number of Person instances? " + Person.GlobalGetNumberOfPeople());

            
            int index = 0;
            while (true )
            {
                bela = new Person("Person_" + index++, index);
                Console.WriteLine("Number of instance ("+index+"): " + Person.GlobalGetNumberOfPeople());
            }
            


        }

    }
}
