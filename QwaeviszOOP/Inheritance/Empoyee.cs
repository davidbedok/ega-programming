using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Employee : Object, Loveable
    {

        protected string name;
        protected int age;

        public Employee( string name ): base()
        {
            this.name = name;
        }

        public int gello()
        {
            return 3;
        }

        public Employee(int age): this("Krumpli")
        {
            this.age = age;
        }

        public int fregre(string gegr)
        {
            throw new NotImplementedException();
        }

        public string htrht(string gegr)
        {
            throw new NotImplementedException();
        }

        public int jzjz(string gegr)
        {
            throw new NotImplementedException();
        }

        public int loveFactor(string gegr)
        {
            throw new NotImplementedException();
        }
    }
}
