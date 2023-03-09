using System;

namespace Zoo
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Tiger t2 = new Tiger(6, "Julcsi", "Juliska");

            Defensable t5 = new Tiger(65, "Frggrt");
            Attackable t6 = new Tiger(632435, "Fegth");

            t5.Defense();
            t6.Attack();

            Living l = new Tiger(65, "Fefgrhrt");

            l.DieHard();
            t6.DieHard();


            t2 = null;

            /*
             Tiger t = new Tiger(3, "Karcsi");


            Mouse m = new Mouse(1);
            // Animal a = new Animal(); // ???
            Animal t1 = new Tiger(4, "Bela");
            Animal m2 = new Mouse(2);

            */

        }
    }
}
