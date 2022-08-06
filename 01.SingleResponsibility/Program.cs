using System;

namespace _01.SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Customer
    {
        public string Name { get; set; }

        //public bool ValidateName()
        //{
        //    return !string.IsNullOrEmpty(Name);
        //}
        
        //public void SayHi()
        //{
        //    Console.WriteLine("Hello"+Name);
        //}
        
        //Single Responsibility bu işlemlere karşıdır her methodun veya clasın tek bir sorumluluğa sahip
        //olması gereklidir.
    }
    public class CustomerManager
    {
        public void SayHi(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }

    public class CustomerValidation
    {
        public bool ValidateName()
        {
            return !string.IsNullOrEmpty(Name);
        }
    }

    // Doğru kullanım bu şekilde olmalıdır.
}
