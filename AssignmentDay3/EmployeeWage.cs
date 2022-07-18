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

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public  void Employee()
        {
             int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs<=this.maxHoursPerMonth && totalWorkingDays<this.numOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#" + totalWorkingDays + "EmpHrs");
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " +company+ " is :" +totalEmpWage);
        }

        public string tostring()
        {
            return "Total Emp Wage for company : " + this.company + "is: " + this.totalEmpWage;
        }
    }
}

