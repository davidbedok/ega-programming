using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeyword
{
    public class People
    {

        private List<Person> items;

        public People()
        {
            this.items = new List<Person>();
        }

        public void AddPerson( Person person ) 
        {
            this.items.Add(person);
        }

        public int GetNumberOfPeople()
        {
            return this.items.Count;
        }

    }
}
