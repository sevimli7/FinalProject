﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            using (NorthwindContext context = new NorthwindContext()) 
            {
                var addedEntity = context.Entry(entity); //framework ile ekleme böyle yapılıyor
                addedEntity.State = EntityState.Added;   //
                context.SaveChanges();                   //
            }
        }

        public void Delete(Customer entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);    //framework ile silme böyle yapılıyor
                deletedEntity.State = EntityState.Deleted;    //
                context.SaveChanges();                        //
            }
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Customer>().SingleOrDefault(filter);
            }
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Customer>().ToList()
                                     : context.Set<Customer>().Where(filter).ToList();
            }
        }

        public void Update(Customer entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);   //framework ile güncelleme böyle yapılıyor
                updatedEntity.State = EntityState.Modified;   //
                context.SaveChanges();                       //
            }
        }
    }
}
