using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8ComputeEmployeeWages
{
    class Program
    {
        public int len1;
        public int len2;
        public int x1;
        public int y1;
        public int x2;
        public int y2;


        public Program()
        {
            double[] StoringLength = new double[5];
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("Enter value for  coordinate x1");
                this.x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for   coordinate y1");
                this.y1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter value for  first coordinate x2");
                this.x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for  first coordinate y2");
                this.y2 = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double FindingLength()
        {
            //Calculating a line length
            double LineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double len = Math.Round(LineLength, 2);
            return len;

        }

        public void EqualityMethod(string len1, string len2)
        {
            if (len1.Equals(len2))
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }

        public void comparingLines(string len1, string len2)
        {
            if (len1.CompareTo(len2) > 0)
            {
                Console.WriteLine("Line1 is greater than line2");
            }
            else if (len1.CompareTo(len2) < 0)
            {
                Console.WriteLine("Line1 is lesser than line2");
            }
            if (len1.CompareTo(len2) > 0)
            {
                Console.WriteLine("both lines are equal");
            }
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            double length1 = obj1.FindingLength();
            Program obj2 = new Program();
            double length2 = obj2.FindingLength();

            Console.WriteLine("Length of First Line " + length1);
            Console.WriteLine("Length of Second Line " + length2);
            obj1.EqualityMethod(length1.ToString(), length2.ToString());
            obj2.comparingLines(length1.ToString(), length2.ToString());



        }


    }
}