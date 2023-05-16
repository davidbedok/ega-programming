using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataStructures
{
    public class Person /* : IComparable<Person> */
    {

        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public Person( string name, int age )
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person other)
        {
            return other.name.CompareTo(this.name);
        }
 
        /*
        public override bool Equals(object other)
        {
            if (other == null) return false;
            Person that = other as Person;  
            if (that == null) return false;
            if (this.age == that.age && this.name.Equals(that.name)) {
                return true;
            }
            return false;
        } */
        
        
        public override int GetHashCode()
        {
            return this.name.GetHashCode();
            // return this.age;
        }
       
        
        public override string ToString()
        {
            return this.name + " ("+this.age+")";
        }


    }
}
