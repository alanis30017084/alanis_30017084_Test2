/*Name: Alanis Correa Kriener
  Purpose: An application that calculates salary and wages of staff.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alanis_payrollapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu Extension
            Console.Write("Welcome to the staff payroll system\nenter 1 to display Salary\nenter 2 to display Wages\nEnter option: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 == 1)
            {
                // Salary class object
                Salary salary1 = new Salary();
                Console.WriteLine(salary1.DisplaySalary());
                Console.WriteLine("\n");
            }

            if (num1 == 2)
            {
                // Wages class object
                Wages wages1 = new Wages();
                Console.Write("Enter the number of hours worked: ");
                double numHours = double.Parse(Console.ReadLine());
                Console.Write($"Your wages per week is ${wages1.DisplayWages(wages1.NumHours, wages1.WeeklyWages)}");
            }

            Console.ReadLine();
        }
    }

    class Salary
    {
        // Properties
        private double annualSalary;
        private double weeklySalary;

        // Getters and setters
        public double AnnualSalary { get; set; } = 80000;
        public double WeeklySalary { get { return weeklySalary; } set { weeklySalary = value; } }

        // Salary Constructor
        public Salary()
        {
            Console.WriteLine($"Your salary is set at 80000 per year");
        }

        // Salary Method
        public string DisplaySalary()
        {
            return $"Your salary per week is ${Math.Round(AnnualSalary / 52, 2)}";
        }

    }

    class Wages
    {
        // Properties
        private double hourlyRate;
        private double numHours;
        private double weeklyWages;

        // Getters and setters
        public double NumHours { get { return numHours; } set { numHours = value; } }
        public double HourlyRate { get; set; } = 33.72;
        public double WeeklyWages { get { return weeklyWages; } set { weeklyWages = value; } }

        // Wages Constructor
        public Wages()
        {
            Console.WriteLine("I will calculate your wages");
        }

        // Wages Method
        public double DisplayWages(double _numHours, double _weeklyWages)
        {
            NumHours = _numHours;
            WeeklyWages = _weeklyWages;
            return _weeklyWages = Math.Round(NumHours * HourlyRate);
        }
        
    }
}
