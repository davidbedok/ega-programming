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

            Child c1 = new Child("Joe", 6);
            Child c2 = new Child("Sue", 4);
            Child c3 = new Child("Karcsi", 56);

            c1.SetFavouriteToy("Kisautó", 4, 5, 6);
            c2.SetFavouriteToy("Baba", 12, 12, 5);
            c3.SetFavouriteToy(new Toy("Ásó", 20, 78, 30));

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

        }
    }
}
