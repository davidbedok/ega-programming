using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenAndToys
{
    public class Child
    {

        private readonly string name;
        private readonly int age;
        private Toy favouriteToy;
        
        public Child( string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        public void SetFavouriteToy( Toy favouriteToy )
        {
            this.favouriteToy = favouriteToy;
        }

        public void SetFavouriteToy(string name, int width, int height, int length)
        {
            this.SetFavouriteToy(new Toy(name, width, height, length));
            // this.favouriteToy = new Toy(name,width, height, length);
        }

        public override string ToString()
        {
            return name + ", aki " + age + " éves, a kedvenc játéka a " + favouriteToy;
        }

    }
}
