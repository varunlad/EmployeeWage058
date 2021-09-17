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
            EmpWageBuildertArray empWageBuilder = new EmpWageBuildertArray();
            empWageBuilder.addCompanyEmpWage("Dmart",20,20,100);
            empWageBuilder.addCompanyEmpWage("Kmall", 50, 20, 100);
            empWageBuilder.computeEmpWage();
            Console.ReadLine();
        }
    }
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int noOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int maxHoursPerMonth, int noOfWorkingDays)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.noOfWorkingDays = noOfWorkingDays;
        }
    
    public void setTotalEmpWage(int totalEmpWage)
    {
        this.totalEmpWage = totalEmpWage;
    }
    public string toString()
    {
        return "Total Wage of Employee is :" + this.totalEmpWage + " in company : " + this.company;

    } 
}

    public class EmpWageBuildertArray
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        private int numOfCompany = 0;
        private CompanyEmpWage[] CompanyEmpWageArray;
        public EmpWageBuildertArray()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage( string company,int empRatePerHour,int numOfWorkingDays,int MaxHoursPerMonth)
        {
            CompanyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, MaxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i=0;i< numOfCompany;i++)
            {
                CompanyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].tostring());
            }
        }
           private int  ComputeEmpWage(CompanyEmpWage companyEmpWage)
          { 
            int empCheck,empHours, totalWorkingDay = 0, totalEmpHours = 0;
            
            Random random = new Random();
            while (totalEmpHours <= computeEmpWage.maxHoursPerMonth && totalWorkingDay < computeEmpWage.numOfWorkingDays)
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
                Console.WriteLine("Days "+totalWorkingDay +"Emp Hours :"+empHours);
            }
                return totalEmpHours * companyEmpWage.empRatePerHour;
                
                
               
           }
       
    }
}
