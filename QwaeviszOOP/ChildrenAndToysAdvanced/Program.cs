using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenAndToys
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Child joe = new Child("Joe", 6, 20);
            joe.AddToy("Kisautó", 4, 5, 6);
            joe.AddToy("Teherautoja", 40, 3, 8, true);
            joe.AddToy("Domper", 41, 51, 63);
            joe.AddToy("PC", 422, 51, 63, true);
            Console.WriteLine(joe);

        }
    }
}
