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
            int fullTime = 1, employeeCheck;
            int perHourPay = 100;
            int salary, hoursPerDay;
            Random random = new Random();
            EmployeeCheck = random.Next(0, 2);
            if (employeeCheck == fullTime)
            {
                Console.WriteLine("Employee is Present");
                hoursPerDay = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                hoursPerDay = 0;
            }
            salary = perHourPay * hoursPerDay;
            Console.WriteLine("The salary of employee per day is : " + salary);
            Console.ReadLine();
        }


    }
}
