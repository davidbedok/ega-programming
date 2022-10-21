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
        private bool favourite;

        public Toy(string name, int width, int height, int length) : this(name, width, height, length, false)
        {
            
        }

        public Toy(string name, int width, int height, int length, bool favourite)
        {
            this.name = name;
            this.width = width;
            this.height = height;
            this.length = length;
            this.favourite = favourite;
        }

        public int GetVolume()
        {
            return width * height * length;
        }

        public override string ToString()
        {
            string favouriteText = this.favourite ? " - Kedvenc" : "";
            return name + " (doboz térfogat: " + this.GetVolume() + " cm3)" + favouriteText;
        }

    }
}
