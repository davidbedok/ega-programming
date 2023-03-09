using System;
using System.ComponentModel;

namespace CompanyBonus
{
    public class Leader : Employee
    {
        private const int MAX_NUMBER_OF_DIRECTS = 30;
        private double bonusRatio;
        private int index;
        private readonly Employee[] directs;
        
        public Leader(string name, int baseMonthlySalary, double bonusRatio) : base(name, baseMonthlySalary)
        {
            this.bonusRatio = bonusRatio;
            this.directs = new Employee[MAX_NUMBER_OF_DIRECTS];
            this.index = 0;
        }

        public void AddDirect(params Employee[] directs)
        {
            foreach (Employee direct in directs) {
                this.directs[this.index++] = direct;
            }
        }

        public override int GetYearlyBonus(double globalBonusRatio)
        {
            int employeeBonus = base.GetYearlyBonus(globalBonusRatio);
            return employeeBonus + this.GetDirectsBonuses(globalBonusRatio);
        }

        private int GetDirectsBonuses(double globalBonusRatio)
        {
            double result = 0;
            for ( int i = 0; i < this.index; i++ )
            {
                result += this.directs[i].GetYearlyBonus(globalBonusRatio) * this.bonusRatio / 100;
            }
            return Convert.ToInt32(Math.Round(result));
        }
    }
}