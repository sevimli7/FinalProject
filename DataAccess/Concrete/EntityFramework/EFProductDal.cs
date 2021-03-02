using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EFProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context=new NorthwindContext()) //using e yazılan northwindcontext işi bitince silinecek demek. 
            {
                var addedEntity = context.Entry(entity); //bu kod ile referansı yakalıyoruz
                addedEntity.State = EntityState.Added;   //ekleme burası ile oluyor
                context.SaveChanges();                   //ekleneni kayıt ediyor
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())  
            {
                var deletedEntity = context.Entry(entity);    //framework ile silme böyle yapılıyor
                deletedEntity.State = EntityState.Deleted;    //
                context.SaveChanges();                        //
            }

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList()
                                     : context.Set<Product>().Where(filter).ToList();
            }
        }


        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);   //referansı yakalıyor
                updatedEntity.State = EntityState.Modified;   //güncelleme yapıyor
                context.SaveChanges();                       //güncelleneni kayıt yapıyor db ye
            }
        }
    }
}
 