using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEnum
{
    public class Program
    {

        private const int MAX_GRADES = 20;

        private static void Main(string[] args)
        {
            int maxStudent = 3;
            Student[] students = new Student[maxStudent];

            students[0] = new Student("Joe", MAX_GRADES);
            students[1] = new Student("Anakin Skywalker", Program.MAX_GRADES);
            students[2] = new Student("Darth Vader", MAX_GRADES);

            Random generator = new Random();
            for ( int i = 0; i < students.Length; i++ )
            {
                students[i].GenerateGrades(generator, 5);
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());
            }

        }
    }
}
