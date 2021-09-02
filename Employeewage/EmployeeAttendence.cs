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
           
           
            Random random = new Random();
            EmployeeCheck = random.Next(0, 2);
            if (EmployeeCheck == fulltime)
            {
                Console.WriteLine("Employee is Present");
               
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                
            }
            
            Console.ReadLine();
        }


    }
}
