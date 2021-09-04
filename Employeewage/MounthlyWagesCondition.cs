using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    class attendence
    {
        
        public const int  FULL_TIME = 1;
        public const int PART_TIME = 2;
        static void Main(string[] arug)
        {
            int employeeCheck , hoursPerDay ,day=0 , hours = 0;
            int perHourPay = 20, salary=0, totalPay=0  ;
            Random random = new Random();
            while(hours<=100 && day<=20 )
            {
                
                employeeCheck = random.Next(0, 3);
                switch (employeeCheck)
                {
                    case 1:
                        Console.WriteLine("full Time  on day :" + day);
                        hoursPerDay = 8;
                        break;
                    case 2:
                        Console.WriteLine("Part Time on day :" + day);
                        hoursPerDay = 4;
                        break;
                    default:
                        Console.WriteLine("Absent on day : "+day);
                        hoursPerDay = 0;
                        break;
                }
                hours += hoursPerDay;

                day++;
                salary = perHourPay * hoursPerDay;
                Console.WriteLine("salary of Employee per day = " + salary);
                TotalPay += salary;
            }
            Console.WriteLine("Total Wage of Employee is :{0} in days : {1}",totalPay,day);
            Console.ReadLine();
        }


    }
}
