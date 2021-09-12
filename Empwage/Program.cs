using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage
{
    class Program
    {

        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public static int EmpWage(string company, int PER_HOUR_PAY, int MAX_HOURS, int MAX_DAYS)
        {
            int EmployeeCheck, HoursPerDay, day = 0, Hours = 0;
            int salary = 0, TotalPay = 0;
            Random random = new Random();
            while (Hours <= MAX_HOURS && day <= MAX_DAYS)
            {

                EmployeeCheck = random.Next(0, 3);
                switch (EmployeeCheck)
                {
                    case 1:
                        Console.WriteLine("full Time  on day :" + day);
                        HoursPerDay = 8;
                        break;
                    case 2:
                        Console.WriteLine("Part Time on day :" + day);
                        HoursPerDay = 4;
                        break;
                    default:
                        Console.WriteLine("Absent on day : " + day);
                        HoursPerDay = 0;
                        break;
                }
                Hours += HoursPerDay;
                day++;
                salary = PER_HOUR_PAY * HoursPerDay;
                Console.WriteLine("salary of Employee per day = " + salary);
                TotalPay += salary;
            }
            Console.WriteLine("Total Wage of Employee is :{0} in days : {1}", TotalPay, day);
            return TotalPay;
        }
        static void Main(string[] arug)
        {
            EmpWage("Dmart", 80, 50, 10);
            EmpWage("Orion", 90, 60, 10);
            EmpWage("Kmall", 60, 60, 15);
            Console.ReadLine();
        }
    }
}
