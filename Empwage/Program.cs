using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage
{
    class Program
    {
        
        static void Main(string[] arug)
        {
            EmpWageBuilderObject Dmart = new EmpWageBuilderObject("Dmart", 20, 100, 20);
            Dmart.ComputeEmpWage();
            Console.WriteLine(Dmart.toString());
            Console.ReadLine();
        }
    }
    public class EmpWageBuilderObject
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        private string company;
        private int empRatePerHour;
        private int noOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;


        public EmpWageBuilderObject(string company, int empRatePerHour, int maxHoursPerMonth, int noOfWorkingDays)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.noOfWorkingDays = noOfWorkingDays;
        }
           public void ComputeEmpWage()
            { 
            int empCheck,empHours, totalWorkingDay = 0, totalEmpHours = 0;
            
            Random random = new Random();
                while (totalEmpHours <= this.maxHoursPerMonth && totalWorkingDay < this.noOfWorkingDays)
                {
                totalWorkingDay++;
                empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case 1:
                            Console.WriteLine("full Time  on day :" + totalWorkingDay);
                        empHours = 8;
                            break;
                        case 2:
                            Console.WriteLine("Part Time on day :" + totalWorkingDay);
                        empHours = 4;
                            break;
                        default:
                            Console.WriteLine("Absent on day : " + totalWorkingDay);
                        empHours = 0;
                            break;
                    }
                totalEmpHours += empHours;
                
                int salary = this.empRatePerHour * empHours;
                    Console.WriteLine("salary of Employee per day = " + salary);
                totalEmpWage += salary;
                }
            }
        public string toString()
        { 
            return "Total Wage of Employee is :" +this.totalEmpWage +" in company : " +this.company;
            
        }
    }
}
