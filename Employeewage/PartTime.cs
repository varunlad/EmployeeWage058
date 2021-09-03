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
            int PerHourPay = 20, salary, HoursPerDay;
            Random random = new Random();
            EmployeeCheck = random.Next(0, 3);
            if (EmployeeCheck == fulltime)
            {
                HoursPerDay = 8;
                Console.WriteLine("Employee work  full Time");
            }
            else if (EmployeeCheck == Parttime)
            {
                HoursPerDay = 8;
                Console.WriteLine("Employee work  Part Time Time");
            }
            else
            {
                HoursPerDay = 0;
                Console.WriteLine("Employee was Absent");
            }
            salary = PerHourPay * HoursPerDay;
            Console.WriteLine("salary of Employee per day = " + salary);
            Console.ReadLine();
        }


    }
}
