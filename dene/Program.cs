using System;
using System.Collections.Generic;
using System.Linq;

namespace dene
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category { CategoryId=1, CategoryName="bilişim"},
                new Category { CategoryId=2, CategoryName="eşya"}
            };

             List<Product> products = new List<Product> {
            new Product{ ProductId=1,CategoryId=1, ProductName="bardak", UnitPrice=15, UnitsInStock=15},
            new Product { ProductId = 2, CategoryId = 1, ProductName = "kamera", UnitPrice = 500, UnitsInStock = 3 },
            new Product { ProductId = 3, CategoryId = 2, ProductName = "telefon", UnitPrice = 1500, UnitsInStock = 2},
            new Product { ProductId = 4, CategoryId = 2, ProductName = "klavye", UnitPrice = 150, UnitsInStock = 65 },
            new Product { ProductId = 5, CategoryId = 2, ProductName = "fare", UnitPrice = 85, UnitsInStock = 1 },

            };

            

            var sonuc = products.First(product=> product.ProductName==product.ProductName);
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);

            }
            Console.WriteLine("*****************************");
            var sonuc1 = products.Where(p => p.UnitPrice<500).OrderByDescending(p=>p.UnitPrice);
            foreach (var item in sonuc1)
            {
                Console.WriteLine(item.UnitPrice);
            }
        }


        class Product 
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public short UnitsInStock { get; set; }
            public decimal UnitPrice { get; set; }
        }

       class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
