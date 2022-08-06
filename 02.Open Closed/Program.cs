using System;

namespace _02.Open_Closed
{
    //02.Open Closed = Nesneler gelişime açık değişime kapalı olmalıdır.
    class Program
    {
        static void Main(string[] args)
        {
            CalculateManager calculateManager = new(new FullTimeEmployee());
            calculateManager.SalaryCalculator();

            CalculateManager calculate = new CalculateManager(new PartTimeEmployee());
            calculate.SalaryCalculator();

            //abstract

            CalculateManager2 calc2 = new(new FullTimeEmployee2());
            calc2.SalaryCalculator();

            CalculateManager2 calc3 = new(new PartTimeEmployee3());
            calc3.SalaryCalculator();
        }
    }
     interface IEmployee
    {
        void CalculateSalary();
    }
     
    // Interface kullanımı ile gelişime açık değişime kapalı bir kod tasarlanmıştır.

    class FullTimeEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Full");
        }
    }
    class PartTimeEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("PartTime");
        }
    }
    class CalculateManager
    {
        private readonly IEmployee employee;

        public CalculateManager(IEmployee employee)
        {
            this.employee = employee;
        }
        public void SalaryCalculator()
        {
            this.employee.CalculateSalary();
        }
    }

    // Abstract class ile birlikte de bir geliştirme yapılabilir.

    abstract class Employee
    {
        public abstract void CalculateSalary();
    }

    class FullTimeEmployee2 : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("FullTime");
        }
    }
    class PartTimeEmployee3 : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("PartTime");
        }
    }
    class CalculateManager2
    {
        private readonly Employee employee;

        public CalculateManager2(Employee employee)
        {
            this.employee = employee;
        }
        public void SalaryCalculator()
        {
            this.employee.CalculateSalary();
        }
    }

}
