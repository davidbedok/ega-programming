using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeyword
{
    public class Person
    {

        private readonly string name;
        private int age;

        private static int numberOfPeople = 0;

        public static readonly int MOL = 42;

        public Person( string name, int age )
        {
            this.name = name;
            this.age = age;
            numberOfPeople++;
        } 

        ~Person()
        {
            numberOfPeople--;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge( int age )
        {
            this.age = age;
        }

        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }

        public static int GlobalGetNumberOfPeople()
        {
            return numberOfPeople;
        }


    }
}
