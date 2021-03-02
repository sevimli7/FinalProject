using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {   
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EFProductDal());
            // productManager.Add(new Entities.Concrete.Product { CategoryId=2, ProductName="elma",UnitPrice=5, UnitsInStock=6});//yeni ürün ekledim db ye
            // productManager.Add(new Entities.Concrete.Product { CategoryId = 3, ProductName = "ARMUT", UnitPrice = 5, UnitsInStock = 6 });//yeni ürün ekledim db ye

            //foreach (var product in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(product.ProductName);

            //}

            //Console.WriteLine("*************");


            //foreach (var product in productManager.GetByUnitPrice(40,100)) //40 ile 100 arasındaki fiyatları listele
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //Console.WriteLine("//////////////////////////");
            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.ProductName);
            } 

        }
    }
}
