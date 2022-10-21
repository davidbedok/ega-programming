using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenAndToys
{
    public class Toy
    {

        private string name;
        private int width;
        private int height;
        private int length;

        public Toy(string name, int width, int height, int length)
        {
            this.name = name;
            this.width = width;
            this.height = height;
            this.length = length;
        }

        public int GetVolume()
        {
            return width * height * length;
        }

        public override string ToString()
        {
            return name + " (doboz térfogat: " + this.GetVolume() + " cm3)";
        }

    }
}
