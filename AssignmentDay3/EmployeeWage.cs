using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace AssignmentDay3
{
     public class EmployeeWage
    {
      static int IS_FULL_TIME = 1;
        static int IS_PART_TIME = 2;
        static int WAGE_PER_HOUR = 20;
        static int DAYS_PER_MONTH = 20;
        static int empMonthlyWage = 0;
        static int empHrs = 0;
        static int empWage = 0;
        static int totalHours = 0;
        static int totalDays = 0;

        public static void employee()
        {
            
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

