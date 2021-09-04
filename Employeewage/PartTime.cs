using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    class attendence
    {
      
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        static void Main(string[] arug)
        {   
            int employeeCheck;
            int perHourPay = 20, salary, hoursPerDay;
            Random random = new Random();
            employeeCheck = random.Next(0, 3);
            if (employeeCheck == FULL_TIME)
            {
                hoursPerDay = 8;
                Console.WriteLine("Employee work  full Time");
            }
            else if (employeeCheck == PART_TIME)
            {
                hoursPerDay = 8;
                Console.WriteLine("Employee work  Part Time Time");
            }
            else
            {
                hoursPerDay = 0;
                Console.WriteLine("Employee was Absent");
            }
            salary = perHourPay * hoursPerDay;
            Console.WriteLine("salary of Employee per day = " + salary);
            Console.ReadLine();
        }


    }
}
