using System;

namespace Exceptions
{
    public class Program
    {

        private void Hello()
        {

        }

        static void Main(string[] args)
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
