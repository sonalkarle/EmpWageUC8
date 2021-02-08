using System;

namespace EmpWageUC8
{
    class Program
    {
        //constant
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int computEmpWage(string company,int empRatePerHr,int numOfWorkingDays,int maxHourMonth)
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while(totalEmpHrs <= maxHourMonth && totalWorkingDays< numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + "Emp Hrs" + totalEmpHrs);
            }
            int totalempWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total EmpWage for company : " + company + "is" + totalempWage);
            return totalempWage;
        }
        
        static void Main(string[] args)
        {
            computEmpWage("Dmar",28,22,45);
            computEmpWage("TATA",30, 15, 10);
        }
    }
}
