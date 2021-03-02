using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context: db tabloları ile proje claslarını ilişkilendirir.
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= (localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
            //bu metod, projemizin hangi veri tabanı ile ilişkili olduğunu belirteceğimiz yer
            //yukarıda server yazdığımız yerde = den sonra serverın olduğu IP yazılır. ama biz develop ortamında olduğumuzdan, adres giriyoruz.
            //hangi db ile çalışacağımızı tanıttık. şimdide hangi nesnem, hangi nesneye karşılık gelir onu tanımlamak için,aşağıda propları kullanacağız
        }
        public DbSet<Product> Products { get; set; }//benim product nesnem products tablosuna eşit
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Employee> Employees { get; set; } 
       

    }
    
 }

//employee-employees tablolarını eşitledik. yani bizim employee nesnemizi db deki employees e manuel eşleyeceğiz. bunu bizim nesnemiz ve db deki karşılığı
//olan tablonun isimleri uyuşmadığında yaparız. bu yönteme mapping denir. 

/**protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // modelBuilder.HasDefaultSchema("admin"); ------- genelde vrasayılan dbo şeması kullanılır. ama burada admin şeması tanıttık. 
    modelBuilder.Entity<Personel>().ToTable(Employees);-----benim personel nesnem, db deki employees tablosuna eşit demek istiyoruz. 
    modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeId");--bendeki Id yi db deki employeeId ye eşitle
    modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");--bendeki name i db deki firstname eşitle
            //                                          //
            //                                          //böyle devam eder eşitleme her colum için.
}
**/