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
        

        public static void Employee(string company, int wagePerhour, int daysPerMonth, int workHourPerMonth)
        {
             int empHrs = 0;
            int empWage = 0;
            int totalHours = 0;
            int totalDays = 0;
            int empMonthlyWage = 0;

            while (totalHours<workHourPerMonth && totalDays<daysPerMonth)
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
            empMonthlyWage = totalHours * wagePerhour;
            Console.WriteLine("Employee monthly wage for company " +company+ " is " +empMonthlyWage);
            Console.WriteLine("Total workdays is " + totalDays );
            Console.WriteLine("Total work hours is " + totalHours );
        }

    }
}

