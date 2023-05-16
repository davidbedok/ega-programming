using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeXml
{
    public abstract class Element
    {

        protected string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Element( string name )
        {
            this.name = name;
        }

        public abstract string Print();

        public abstract void ToUpperCase();

        public abstract void MultiplyBy( int multiplier );


    }
}
