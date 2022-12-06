using System;
using System.Reflection.Emit;

namespace FirstEnum
{
    internal class Grade
    {

        private const int MIN_GRADE = 1;
        private const int MAX_GRADE = 1;

        private Subject subject;
        private int value;

        public Grade(Subject subject, int value)
        {
            this.subject = subject;
            this.value = value ;
        }

        public static int GetRandomValue(Random generator)
        {
            return generator.Next(MIN_GRADE, MAX_GRADE + 1);
        }

        public int GetValue()
        {
            return this.value;
        }

        public Subject GetSubject()
        {
            return this.subject;
        }

        public override string ToString()
        {
            return this.subject + " --> " + this.value;
        }

    }
}