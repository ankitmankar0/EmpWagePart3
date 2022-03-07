using System;

namespace EmployeeWages
{
    class CompanyEmpWage
    {
        //Declaring Constant Variable
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        private int wagePerHour;
        public string company;
        public int maxHoursPerMonth;
        public int maxWorkingDays;
        int setTotalEmpWage;

        public CompanyEmpWage(string company, int wagePerhour, int maxHoursPerMonth, int maxWorkingDays)
        {
            this.company = company;
            this.wagePerHour = wagePerhour;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.maxWorkingDays = maxWorkingDays;
        }

        //Creating a interface 
        public interface ComputationEmployeeWage
        {
            void ComputeEmpWage();
            int ComputeEmpWage(CompanyEmpWage companyEmpWage);
        }
        //Implements the interface in class
        public class EmpBuilderWage : ComputationEmployeeWage
        {
            public const int FULL_TIME = 1;
            public const int PART_TIME = 2;
            public int numOfCompany = 0;

            public CompanyEmpWage[] companyEmpWageArray;
            public int totalWage;


            public EmpBuilderWage()
            {
                this.companyEmpWageArray = new CompanyEmpWage[5];
            }
            public void addCompanyEmpWage(string company, int wagePerhour, int maxHoursPerMonth, int maxWorkingDays)
            {
                companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, wagePerhour, maxHoursPerMonth, maxWorkingDays);
                numOfCompany++;
            }
            public void ComputeEmpWage()
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    object p = companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                    Console.WriteLine(this.companyEmpWageArray[i].ToString());
                }
            }
            public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
            {
                //Console.WriteLine("Welcome to employee wage computation");
                //Creating a Random Function
                int empHours = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                //workingHrs=0;


                while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage.maxWorkingDays)
                {
                    //Calling the next method in Random Class
                    totalWorkingDays++;
                    Random r = new Random();
                    int empAttendance = r.Next(0, 3);
                    switch (empAttendance)
                    {
                        case FULL_TIME:
                            empHours = 8;
                            break;
                        case PART_TIME:
                            empHours = 4;
                            break;
                        default:
                            empHours = 0;
                            break;

                    }

                    totalEmpHrs += empHours;


                }

                Console.WriteLine("Days : " + totalWorkingDays + " Emp Hours : " + empHours);
                return totalEmpHrs * companyEmpWage.wagePerHour;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to employee wage computation");
                EmpBuilderWage empBuilderWage = new EmpBuilderWage();
                empBuilderWage.addCompanyEmpWage("TCS", 70, 20, 10);
                empBuilderWage.addCompanyEmpWage("Accenture", 50, 30, 20);
                empBuilderWage.ComputeEmpWage();
            }
        }

    }
}