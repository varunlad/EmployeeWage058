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
           switch(EmployeeCheck)
            {
                case 1:
                    Console.WriteLine("full Time");
                    HoursPerDay = 8;
                    break;
                case 2:
                    Console.WriteLine("Part Time");
                    HoursPerDay = 4;
                    break;
                 default:
                     Console.WriteLine("Absent");
                     HoursPerDay = 0;
                     break;
            }
            
            salary = PerHourPay * HoursPerDay;
            Console.WriteLine("salary of Employee per day = " + salary);
            Console.ReadLine();
        }


    }
}
