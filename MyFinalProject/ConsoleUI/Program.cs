using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("Ürün adı: "+product.ProductName+" Ürün fiyatı:"+product.UnitPrice +" Stok adedi:"+product.UnitsInStock);
            }
        }
    }
}
