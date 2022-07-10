using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay3
{
     public class EmployeeWage
    {
       
        public static void employee()
        {
            int IS_FULL_TIME = 1;
            int WAGE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0,2);
            if(empCheck==IS_FULL_TIME)
            {
                empHrs = 8;
                empWage = empHrs * WAGE_PER_HOUR;
                Console.WriteLine(empWage);
            }
          
            else
            { 
                Console.WriteLine("Employee is absent");
            }

         

        }

    }
}
