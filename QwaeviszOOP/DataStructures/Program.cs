using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DataStructures
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // listDemo();
            dictionaryDemo();
        }

        private static void dictionaryDemo()
        {
            

            Random generator = new Random();

            List<Person> people = new List<Person>();
            int numberOfPeople = 1000;
            for (int i = 0; i < numberOfPeople; i++)
            {
                string name = generator.Next(1, 10000) + "name" + generator.Next(1, 10000);
                people.Add(new Person(name, generator.Next(1, 150)));
            }
            Console.WriteLine(numberOfPeople + " people created.");

            Dictionary<String, Person> nameIndex = new Dictionary<String, Person>();
            foreach ( Person person in people )
            {
                if (!nameIndex.ContainsKey(person.Name))
                {
                    nameIndex.Add(person.Name, person);
                    // nameIndex[person.Name] = person;
                }
            }
            Console.WriteLine(numberOfPeople + " index created.");
            int numberOfSearch = 100;
            
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            /*
            watch.Start();
            for (int i = 0; i < numberOfSearch; i++)
            {
                string name = generator.Next(1, 10000) + "name" + generator.Next(1, 10000);
                Person p = find(people, name);
                if (i % 50 == 0)
                {
                    Console.WriteLine("Search index: " + i);
                }
            }
            watch.Stop();
            Console.WriteLine("List. Find by name: " + watch.ElapsedMilliseconds + " ms");
            */
            watch.Restart();

            for (int i = 0; i < numberOfSearch; i++)
            {
                string name = generator.Next(1, 10000) + "name" + generator.Next(1, 10000);
                if ( nameIndex.ContainsKey(name) )
                {
                    Person p = nameIndex[name];
                }
                if (i % 100 == 0)
                {
                    Console.WriteLine("Search index: " + i);
                }
            }
            watch.Stop();
            Console.WriteLine("Dictionary. Find by name: " + watch.ElapsedMilliseconds + " ms");


            Dictionary<Person, Int32> personIndex = new Dictionary<Person, Int32>();

            Dictionary<Int32, List<Person>> ageIndex = new Dictionary<Int32, List<Person>>();

            int k = 0;
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name + " --> " + person.GetHashCode());

                if ( ageIndex.ContainsKey(person.Age))
                {
                    ageIndex[person.Age].Add(person);

                } else
                {
                    List<Person> aa = new List<Person>();
                    aa.Add(person);
                    ageIndex[person.Age] = aa;
                }

                if (!personIndex.ContainsKey(person))
                {
                    personIndex.Add(person, generator.Next(1, 1000000));
                }
                if (k % 100 == 0)
                {
                    Console.WriteLine("Search index: " + k);
                }
                k++;
            }
            Console.WriteLine(personIndex.Count + " index created.");

            numberOfSearch = 10000;

            watch.Restart();
            for (int i = 0; i < numberOfSearch; i++)
            {
                Person randomPerson = people.ElementAt(generator.Next(0, people.Count - 1));
                if (personIndex.ContainsKey(randomPerson))
                {
                    Int32 value = personIndex[randomPerson];
                }
                if (i % 100 == 0)
                {
                    Console.WriteLine("Search index: " + i);
                }
            }
            watch.Stop();
            Console.WriteLine("Dictionary. Find by person: " + watch.ElapsedMilliseconds + " ms");





        }

        private static void listDemo()
        {
            Person bela = new Person("Bela", 32);
            Person geza = new Person("Geza", 41);
            Console.WriteLine(bela);
            Console.WriteLine(geza);

            Person bela2 = new Person("Bela", 32);

            // if ( bela == bela2 )
            if (bela.Equals(bela2))
            {
                Console.WriteLine("Azonosak :)");
            }
            else
            {
                Console.WriteLine("Nem azonosak :(");
            }

            List<Person> people = new List<Person>();
            people.Add(bela);
            people.Add(geza);
            people.Add(bela2);

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            // people.Sort(new PersonComparer());
            people.Sort();

            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people.ElementAt(i));
                // Console.WriteLine(people[i]);
            }
        }

        private static Person find( List<Person> data, string name )
        {
            Person result = null;
            foreach (Person p in data)
            {
                if ( p.Name.Equals(name) )
                {
                    result = p;
                    break;
                }
            }
            return result;
        }

        private static List<Person> find(List<Person> data, int age)
        {
            List<Person> result = null;
            foreach (Person p in data)
            {
                if (p.Age == age)
                {
                    result.Add(p);
                }
            }
            return result;
        }

        private static void tmp(string[] args)
        {
            
            
            Dictionary<String, Person> s = new Dictionary<String, Person>();
            s.Add("key1", new Person("fefe", 43));
            s.Add("key2", new Person("fefe", 43));
            s.Add("key3", new Person("fefe", 43));
            s.Add("key4", new Person("fefe", 43));
            s.Add("key5", new Person("fefe", 43));

            bool has = s.ContainsKey("key3");
            Person p = s["key3"];

            
            foreach (KeyValuePair<String, Person> pair in s)
            {
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }

            s.ContainsKey("key1");

            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine(s.ElementAt(i).Key);
                Console.WriteLine(s.ElementAt(i).Value);

            }

            s["key1"] = new Person("Bela", 32);
            Console.WriteLine(s["key1"].Name);

            s.Remove("key1");
        }
    }
}
