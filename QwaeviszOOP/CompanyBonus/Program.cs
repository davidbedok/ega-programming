using System;

namespace CompanyBonus
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Program.PrintCompanySalaries(); 
            
        }

        private static void PrintCompanySalaries()
        {
            Company company = new Company("Qwaevisz Ltd.");
            Employee albert = company.AddEmployee("Albert", 8000);
            Employee brutus = company.AddEmployee("Brutus", 7500);
            Employee cecil = company.AddEmployee("Cecil", 9200);
            Leader devil = company.AddLeader("Devil", 14000, 15);
            devil.AddDirect(albert, cecil);

            Leader erik = company.AddLeader("Erik", 16000, 20);
            erik.AddDirect(brutus, devil);

            Console.WriteLine(company.PrintYearlyBonuses(8));
        }
    }
}
