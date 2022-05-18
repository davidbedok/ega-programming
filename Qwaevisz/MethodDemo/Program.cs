namespace MethodDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Hello");
            MethodDemo.Program.MyPrint("Hello");

            int a = 10;
            int b = 20;
            int r = AddNumbers(a, b);
            int left = 10;
            int r2 = AddNumbers(42, left);

        }

        private static void MyPrint( string text )
        {
            System.Console.WriteLine(text);
        }

        private static int AddNumbers( int left, int right )
        {
            int result = left + right;
            return result;
        }

        private static string[] GiveMeNames()
        {
            string[] names = new string[4];
            names[0] = "Alma";
            names[1] = "Korte";
            names[2] = "Szilva";
            names[3] = "Barack";
            return names;
        }

    }
}
