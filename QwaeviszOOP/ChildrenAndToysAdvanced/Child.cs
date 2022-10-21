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
        private readonly Toy[] toys;
        private int toyIndex;

        public Child( string name, int age, int maxToys)
        {
            this.name = name;
            this.age = age;
            this.toys = new Toy[maxToys];
            this.toyIndex = 0;
        }   

        public void AddToy( Toy favouriteToy )
        {
            if (this.toyIndex < this.toys.Length)
            {
                this.toys[this.toyIndex++] = favouriteToy;
            } else
            {
                Console.WriteLine("Nincs hely több játéknak!");
            }
        }

        public void AddToy(string name, int width, int height, int length, bool favourite)
        {
            this.AddToy(new Toy(name, width, height, length, favourite));
        }

        public void AddToy(string name, int width, int height, int length)
        {
            this.AddToy(name, width, height, length, false);
        }

        public override string ToString()
        {

            return name + ", " + age + " éves, és a következő játékai vannak:\n" + this.PrintToys();
        }

        private string PrintToys()
        {
            string result = "";
            for ( int i = 0; i < this.toyIndex; i++ )
            {
                result += this.toys[i].ToString() + "\n";
            }
            return result;
        }

    }
}
