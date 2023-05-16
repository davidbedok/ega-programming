using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class PersonComparer : IComparer<Person>
    {

        public int Compare(Person left, Person right)
        {
            return left.Name.CompareTo(right.Name);
        }

    }
}
