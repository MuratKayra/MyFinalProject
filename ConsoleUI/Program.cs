using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        //SOLID
        //Open Closed Principle
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(10, 20))
            {
                Console.WriteLine("{0} {1} {2}", product.ProductId, product.ProductName, product.UnitPrice);
            }
        }
    }
}
