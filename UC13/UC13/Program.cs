using System;

public class CompanyEmpWage
{
    public string company;
    public int empRatePerHour;
    public int numOfWorkingDays;
    public int maxHoursPerMonth;
    public int totalEmpWage;

    public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        this.company = company;
        this.empRatePerHour = empRatePerHour;
        this.maxHoursPerMonth = maxHoursPerMonth;
        this.numOfWorkingDays = numOfWorkingDays;
        this.totalEmpWage = 0;
    }
    public void setTotalEmpWage(int totalEmpWage)
    {
        this.totalEmpWage = totalEmpWage;

    }
    public string toString()
    {
        return "Total Employee Wage for Company  " + this.company + " is: " + this.totalEmpWage + "\n";
    }
   

    public class EmpWageBuilderArray
    {

        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        private CompanyEmpWage[] companyEmpWageArray;
        public int numOfCompnay;
        private int numOfCompany;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
           
        }


        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompnay] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompnay++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                object p = companyEmpWageArray.setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //Console.WriteLine("Welcome to employee wage computation");
            //Creating a Random Function
            int empHours = 0, totalEmpHrs = 0, totalWorkingDays = 0;


            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                Console.WriteLine("Days :" + totalWorkingDays + "Emp Hours :" + empHours);
            }
            return totalEmpHrs = companyEmpWage.empRatePerHour;
            


        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}
