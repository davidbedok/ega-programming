using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Zoo
{
    public abstract class Animal : Object
    {

        protected int code;

        public Animal( int code ) : base()
        {
            this.code = code;
            Console.WriteLine("Animal ctor(): " + this.code);
        }

        public abstract String Feed();

    }
}
