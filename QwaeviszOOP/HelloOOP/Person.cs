using System;
using System.Collections.Generic;
using System.Text;

namespace HelloClass
{
    public class Person
    {

        private string firstName;
        private string lastName;
        private int yearOfBirth;

        public Person( string first, string last )
        {
            firstName = first;
            lastName = last;
        }

        public void SetYearOfBirth( int year )
        {
            if (year <= 2022)
            {
                yearOfBirth = year;
            }
        }

        public int GetAge()
        {
            return 2022 - yearOfBirth;
        }

        public string GetName()
        {
            return firstName + " " + lastName;
        }

    }

}
