using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    class attendence
    {
           
        public const int fulltime = 1;
        public const int Parttime = 2;
        static void Main(string[] arug)
        {
            int EmployeeCheck;
            int PerHourPay = 20, salary=0, TotalPay=0 , HoursPerDay;
            Random random = new Random();
            for (int day = 1; day < 20; day++)
            {
                EmployeeCheck = random.Next(0, 3);
                switch (EmployeeCheck)
                {
                    case 1:
                        Console.WriteLine("full Time  on day :"+day);
                        HoursPerDay = 8;
                        break;
                    case 2:
                        Console.WriteLine("Part Time on day :" +day);
                        HoursPerDay = 4;
                        break;
                    default:
                        Console.WriteLine("Absent on day :"+day);
                        HoursPerDay = 0;
                        break;
                }

                salary = PerHourPay * HoursPerDay;
                Console.WriteLine("salary of Employee per day = " + salary);
                TotalPay += salary;
            }
            Console.WriteLine("Total Wage of Employee is :"+TotalPay);
            Console.ReadLine();
        }


    }
}
