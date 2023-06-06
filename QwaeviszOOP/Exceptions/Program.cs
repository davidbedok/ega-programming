using System;
using System.Reflection;

namespace Exceptions
{
    public class Program
    {


        private static void Main(string[] args)
        {
            LifeInsurrance(4000);
        }

        private static void LifeInsurrance( int feeUnit )
        {
            Console.Write("Van-e? (y/n)");
            bool exists = Console.ReadLine().Equals("y");
            if ( !exists )
            {
                int monthlyFee = 0;
                try
                {
                    monthlyFee = LifeInsurranceDetails(feeUnit);

                }
                catch (MemberTooOld e)
                {
                    monthlyFee = 0;
                    Console.WriteLine("Sajnos onnel nem kotunk szerzodest.");
                    Console.WriteLine("De azért megemekljuk a havi szamlavezetesi dijat!");
                }
                catch (SeriesDeseaseFamilyMember e)
                {
                    monthlyFee = e.MonthlyBaseFee * 3;
                }
                catch ( Exception e )
                {
                    Console.WriteLine("General error.");
                }
                finally
                {
                    Console.WriteLine("Gratulalunk. On most fizetett ki evi " + monthlyFee * 12 + " Ft-ot.");
                }
                
            } else
            {
                Console.WriteLine("Sajnaljuk, de meg kell emeljuk a havi szamlavezetesi dijat!");
            }
        }


        private static int LifeInsurranceDetails(int feeUnit)
        {
            Console.Write("Mennyi csaladtag? (x)");
            int familySize = Int32.Parse(Console.ReadLine());

            Console.Write("Van-e sulyos betegseg? (y/n)");
            int monthlyFee = familySize * feeUnit;

            bool disease = Console.ReadLine().Equals("y");
            if (disease)
            {
                throw new SeriesDeseaseFamilyMember(monthlyFee);
            }

            Console.Write("Legidosebb csaladtag? (eletkor)");
            int age = Int32.Parse(Console.ReadLine());
            if (age > 80 )
            {
                throw new MemberTooOld(monthlyFee);
            }
            return monthlyFee;
        }

            private void Hello()
        {

        }




        static void Main22(string[] args)
        {
            try
            {
                Program p = null;
                p.Hello();
                throw new CustomNotFoundException("Hello", new NullReferenceException());
            } catch ( CustomNotFoundException e )
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.StackTrace);
            } catch (Exception e )
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.StackTrace);
            }

}
    }
}
