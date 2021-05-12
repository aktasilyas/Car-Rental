using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // ProductTest();
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            /* foreach (var category in categoryManager.GetAll())
             {
                 Console.WriteLine(category.CategoryName);
             }*/
        

        }

        private static ICategoryDal ICategoryDal()
        {
            throw new NotImplementedException();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine(product.ProductName);

            }
        }
    }
}
