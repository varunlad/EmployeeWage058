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
            EmployeeCheck = random.Next(0, 3);
           switch(employeeCheck)
            {
                case 1:
                    Console.WriteLine("full Time");
                    hoursPerDay = 8;
                    break;
                case 2:
                    Console.WriteLine("Part Time");
                    hoursPerDay = 4;
                    break;
                 default:
                     Console.WriteLine("Absent");
                     hoursPerDay = 0;
                     break;
            }
            
            salary = perHourPay * hoursPerDay;
            Console.WriteLine("salary of Employee per day = " + salary);
            Console.ReadLine();
        }


    }
}
