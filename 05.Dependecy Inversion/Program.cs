using System;

namespace _05.Dependecy_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeIndex();
            CategoryIndex();
            CategoryIndex2();
            CategoryIndex3();
            CategoryIndex4();
        }
        //Bu kullanımla birlikte aslında biz tüm action methodlarında new methodu ile yeni 
        //nesne ürettip ürettiğimiz nesneye bağımlı kaldık biz eğer DP yerin EF kullanmak istersek 
        //bunu tüm action methodlarına girip değiştirmemiz gerekir.BU kullanım YANLIŞTIR:

        static void HomeIndex() // bunları action methodmuş gibi farz et.
        {
            ////CategoryRepositoryDP categoryRepositoryDP = new();
            ////categoryRepositoryDP.GetRepository();
        }
        static void CategoryIndex()
        {
            ////CategoryRepositoryDP categoryRepositoryDP = new();
            ////categoryRepositoryDP.GetRepository();
        }
        static void CategoryIndex2()
        {
            ////CategoryRepositoryDP categoryRepositoryDP = new();
            ////categoryRepositoryDP.GetRepository();
        }
        static void CategoryIndex3()
        {
            ////CategoryRepositoryDP categoryRepositoryDP = new();
            ////categoryRepositoryDP.GetRepository();
        }
        static void CategoryIndex4()
        {
            ////CategoryRepositoryDP categoryRepositoryDP = new();
            ////categoryRepositoryDP.GetRepository();
        }
    }

    interface ICategoryRepository
    {
        void GetRepository();
    }
    class CategoryRepositoryEF : ICategoryRepository//Entity Framework ORM i 
    {
        private readonly ICategoryRepository _repostory;

        public CategoryRepositoryEF(ICategoryRepository repostory)
        {
            this._repostory = repostory;
        }
        public void GetRepository()
        {
            Console.WriteLine("EF");
        }
    }
    class CategoryRepositoryDP : ICategoryRepository// Depper ORM i 
    {
        public void GetRepository()
        {
            Console.WriteLine("DP");
        }
    }
    class Container // Bir tane container oluşturup içerisinde bir method tanımlayabilrirz.
    {
       
        public ICategoryRepository GetInstance()
        {
            return new CategoryRepositoryDP();
        }
    }
}
