using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    class attendence
    {
        static void Main(string[] args)


        {
            int fulltime = 1, EmployeeCheck;
            int PerHourPay = 100;
            int salary, HoursPerDay;
            Random random = new Random();
            EmployeeCheck = random.Next(0, 2);
            if (EmployeeCheck == fulltime)
            {
                Console.WriteLine("Employee is Present");
                HoursPerDay = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                HoursPerDay = 0;
            }
            salary = PerHourPay * HoursPerDay;
            Console.WriteLine("The salary of employee per day is : " + salary);
            Console.ReadLine();
        }


    }
}
