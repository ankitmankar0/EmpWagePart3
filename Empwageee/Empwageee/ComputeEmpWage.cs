using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays);
        public void computeEmpWage();
        public int getTotalWage();
    }
    public class CompanyEmpWage
    {
        public string company;
        public int wagePerHour;
        public int maxHoursPerMonth;
        public int maxWorkingDays;
        public int totalEmpWage;
        public int dailyWage = 0;


        public CompanyEmpWage(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays)
        {
            this.company = company;
            this.wagePerHour = wagePerHour;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.maxWorkingDays = maxWorkingDays;
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

    }
    public class EmpWageBuilder : IComputeEmpWage
    {
        //Declaring Constant Variable
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
<<<<<<< HEAD

=======
        
>>>>>>> 61b277f6979896c99267cb61cfa6e3f19f9e8b2b
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();

        }


        public void addCompanyEmpWage(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays)
        {
            CompanyEmpWage CompanyEmpWage = new CompanyEmpWage(company, wagePerHour, maxHoursPerMonth, maxWorkingDays);
            this.companyEmpWageList.AddLast(CompanyEmpWage);
            this.companyToEmpWageMap.Add(company, CompanyEmpWage);

        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
<<<<<<< HEAD
                companyEmpWage.setTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
=======
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
>>>>>>> 61b277f6979896c99267cb61cfa6e3f19f9e8b2b
                Console.WriteLine(companyEmpWage.toString());

            }

        }
<<<<<<< HEAD
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        { }

            public int getTotalWage(string compnay)
            {
                return this.companyToEmpWageMap[compnay].totalEmpWage;
            }
         
=======
        private int computeEmpWage (CompanyEmpWage companyEmpWage)


             public int getTotalWage(string compnay)
        {
            return this.companyToEmpWageMap[compnay].totalEmpWage;
        }
>>>>>>> 61b277f6979896c99267cb61cfa6e3f19f9e8b2b
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage for Dmart Company: " + empWageBuilder.getTotalWage("Dmart"));
        }
    }

}

