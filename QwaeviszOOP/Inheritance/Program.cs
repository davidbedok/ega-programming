using System;

namespace Inheritance
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Employee e = new Employee("Kriumpki");

            Loveable[] l = new Loveable[10];
            l[3] = new Employee("fefre");
            l[6] = new Leader("gegre");

            foreach ( Loveable lo in l ) {
                lo.htrht ("gergr");
            }

            if ( l[3] is Employee )
            {
                Employee e1 = (Employee)l[3];
                e1.gello();

                (l[3] as Employee).gello();
            }

        }
    }
}
