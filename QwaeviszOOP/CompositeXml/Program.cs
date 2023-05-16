using System;

namespace CompositeXml
{
    public class Program
    {
        private static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument("People");

            doc.Root.AddChild(CreatePerson("John", "Doe", 42, "Buksi", 36));
            doc.Root.AddChild(CreatePerson("Teszt", "Elek", 17, "Domotor", 78));

            Console.WriteLine("ORIGINAL");
            Console.WriteLine(doc.Root.Print());

            doc.Root.ToUpperCase();
            doc.Root.MultiplyBy(2);

            Console.WriteLine("MODIFIED");
            Console.WriteLine(doc.Root.Print());
        }

        private static CompositeElement CreatePerson( string familyName, string firstName, int age, string dogName, int dogIq)
        {
            CompositeElement person = new CompositeElement("Person");
            person.AddChild(new LeafElement("FamilyName", familyName));
            person.AddChild(new LeafElement("FirstName", firstName));
            person.AddChild(new LeafElement("Age", "" + age));
            person.AddChild(CreateDog(dogName, dogIq));
            return person;
        }

        private static CompositeElement CreateDog( string name, int iq )
        {
            CompositeElement dog = new CompositeElement("Dog");
            dog.AddChild(new LeafElement("Name", name));
            dog.AddChild(new LeafElement("IQ", "" + iq));
            return dog;
        }

    }
}
