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
            int IS_PART_TIME = 2;
            int WAGE_PER_HOUR = 20;
            int DAYS_PER_MONTH = 20;
            int empMonthlyWage = 0;
            int empHrs = 0;
            int empWage = 0;
            int totalHours = 0;
            int totalDays = 0;
            while(totalHours<100 && totalDays<DAYS_PER_MONTH)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case 1:
                        Console.WriteLine("employee is working fulltime");
                        empHrs = 8;
                        break;
                    case 2:
                        Console.WriteLine("employee is working parttime");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("employee is absent");
                        empHrs = 0;
                        break;

                }
                totalDays++;
                totalHours = totalHours + empHrs;


               
                
              

            }
            empMonthlyWage = totalHours * WAGE_PER_HOUR;
            Console.WriteLine("Employee monthly wage is " + empMonthlyWage);
            Console.WriteLine("Total workdays is " + totalDays );
            Console.WriteLine("Total work hours is " + totalHours );
        }

    }
}
