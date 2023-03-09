using System;

namespace CompanyBonus
{
    public class Employee
    {
        private readonly string name;
        private int baseMonthlySalary;

        public Employee(string name, int baseMonthlySalary)
        {
            this.name = name;
            this.baseMonthlySalary = baseMonthlySalary;
        }

        public string PrintYearlyBonus(double globalBonusRatio)
        {
            return this.name + " (" + this.baseMonthlySalary + ") --> Bonus: " + this.GetYearlyBonus(globalBonusRatio);
        }

        public virtual int GetYearlyBonus(double globalBonusRatio)
        {
            return Convert.ToInt32(Math.Round(12 * this.baseMonthlySalary * globalBonusRatio / 100));
        }

    }
}