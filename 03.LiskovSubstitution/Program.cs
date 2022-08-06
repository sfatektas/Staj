using System;

namespace _03.LiskovSubstitution
{
    class Program
    {
        //S eğer T nin bir alt türü ise S nin T nin yerine geçebilmesi gerekir.
        static void Main(string[] args)
        {
            Employee isci = new FullTimeEmployee2();
            //şu kavram detaylı olarak anlatılacak . 
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }


    class FullTimeEmployee2 : Employee
    {
        public decimal DailyWage { get; set; }
    }
    class PartTimeEmployee3 : Employee
    {
        public decimal HorslyWage { get; set; }
    }
    class CalculateManager2
    {
        private readonly Employee employee;
    }

}
