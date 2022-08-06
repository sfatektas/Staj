using System;

namespace _04.Interface_Segration
{
    class Program
    {
        //Adından da anlaşıldığı gibi İnterface Ayırma/Bölme
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        interface IRepository
        {
            void Add();
        }
        interface ICategoryRepository : IRepository
        {
            void GetCategories();
        }
        interface IProudctRepository : IRepository
        {
            void GetProducts();
        }
        //örneğin ortak olan methodu başka bir interface üzerinde tenımlayıp p interfaci diğer interfacelere kalıtım olarak 
        //verdik.

        public class ProductRepository : IProudctRepository
        {
            public void Add()
            {
                Console.WriteLine("Added Product");
            }

            public void GetProducts()
            {
                Console.WriteLine("Get Product");
            }
        }
        public class CategoryRepository : ICategoryRepository
        {
            public void Add()
            {
                Console.WriteLine("Added Category");
            }

            public void GetCategories()
            {
                Console.WriteLine("Get Product");
            }
        }
    }
}
