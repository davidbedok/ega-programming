using System;
using System.Text;

namespace CompanyBonus
{
    public class Company
    {
        private const int MAX_NUM_OF_EMPLOYEES = 50;

        private string name;
        private int index;
        private readonly Employee[] employees;
        
        public Company(string name)
        {
            this.name = name;
            this.employees = new Employee[MAX_NUM_OF_EMPLOYEES];
            this.index = 0;
        }

        public Employee AddEmployee(string name, int baseMonthlySalary)
        {
            Employee result = new Employee(name, baseMonthlySalary);
            this.employees[this.index++] = result;
            return result;
        }

        public Leader AddLeader(string name, int baseMonthlySalary, double bonusRatio)
        {
            Leader result = new Leader(name, baseMonthlySalary, bonusRatio);
            this.employees[this.index++] = result;
            return result;
        }

        public string PrintYearlyBonuses(double globalBonusRatio)
        {
            StringBuilder content = new StringBuilder(200);
            content.Append("---< ").Append(this.name).AppendLine(" >---");
            
            for (int i = 0; i < this.index; i++ )
            {
                Employee employee = this.employees[i];
                content.AppendLine(employee.PrintYearlyBonus(globalBonusRatio));
            }
            
            return content.ToString();
        }
    }
}