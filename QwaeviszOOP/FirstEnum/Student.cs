using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEnum
{
    public class Student
    {


        private string name;
        private Grade[] grades;
        private int numberOfGrades;
        public Student( string name, int maxGrades )
        {
            this.name = name;
            this.grades = new Grade[maxGrades];
        }

        public void AddGrade( Subject subject, int value )
        {
            if ( this.numberOfGrades < this.grades.Length )
            {
                this.grades[this.numberOfGrades++] = new Grade(subject, value);
            }
        }

        public void GenerateGrades(Random generator, Subject subject, int numberOfGrades )
        {
            for ( int i = 0; i < numberOfGrades; i++ )
            {
                this.AddGrade(subject, Grade.GetRandomValue(generator));
            }
        }

        public void GenerateGrades( Random generator, int maxNumberOfGradesPerSubject)
        {
            this.GenerateGrades(generator, Subject.MATH, generator.Next(1, maxNumberOfGradesPerSubject));
            this.GenerateGrades(generator, Subject.LITERATURE, generator.Next(1, maxNumberOfGradesPerSubject));
            this.GenerateGrades(generator, Subject.HISTORY, generator.Next(1, maxNumberOfGradesPerSubject));

            // this.GenerateGrades(generator, (Subject)generator.Next(3), generator.Next(1, maxNumberOfGradesPerSubject));

        }

        public double GetAverage()
        {
            double result = 0;
            if (this.grades.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < this.numberOfGrades; i++)
                {
                    sum += this.grades[i].GetValue();
                }
                result = (double)sum / this.numberOfGrades;
            }
            return result;
        }

        public double GetAverage( Subject subject )
        {
            double result = 0;
            if (this.grades.Length > 0)
            {
                result = (double)this.GetSum(subject) / this.GetNumberOfGrades(subject);
            }
            return result;
        }

        private int GetSum(Subject subject)
        {
            int sum = 0;
            for (int i = 0; i < this.numberOfGrades; i++)
            {
                if (this.grades[i].GetSubject() == subject)
                {
                    sum += this.grades[i].GetValue();
                }
            }
            return sum;
        }

        private int GetNumberOfGrades(Subject subject)
        {
            int count = 0;
            for (int i = 0; i < this.numberOfGrades; i++)
            {
                if (this.grades[i].GetSubject() == subject)
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            string text = "<<< " + this.name + " >>>\n";
            for ( int i = 0; i < this.numberOfGrades; i++ )
            {
                text += this.grades[i].ToString() + "\n";
            }

            text += Subject.MATH + " average: " + this.GetAverage(Subject.MATH) + "\n";
            text += Subject.LITERATURE + " average: " + this.GetAverage(Subject.LITERATURE) + "\n";
            text += Subject.HISTORY + " average: " + this.GetAverage(Subject.HISTORY) + "\n";
            
            text += "Total average: " + this.GetAverage() + "\n";
            return text;
        }

    }
}
