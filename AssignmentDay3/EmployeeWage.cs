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
            Console.WriteLine("Welcome to Employee wage Computation program on master branch");
            int IS_PRESENT = 1;
            Random random = new Random();
            int empCheck = random.Next(0,2);
            if(empCheck==IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

         

        }

    }
}
