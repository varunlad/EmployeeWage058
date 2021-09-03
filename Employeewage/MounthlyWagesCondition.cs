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
            int EmployeeCheck , HoursPerDay ,day=0 , Hours = 0;
            int PerHourPay = 20, salary=0, TotalPay=0  ;
            Random random = new Random();
            while(Hours<=100 && day<=20 )
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
                        Console.WriteLine("Absent on day : "+day);
                        HoursPerDay = 0;
                        break;
                }
                Hours += HoursPerDay;

                day++;
                salary = PerHourPay * HoursPerDay;
                Console.WriteLine("salary of Employee per day = " + salary);
                TotalPay += salary;
            }
            Console.WriteLine("Total Wage of Employee is :{0} in days : {1}",TotalPay,day);
            Console.ReadLine();
        }


    }
}
