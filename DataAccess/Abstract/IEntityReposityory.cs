using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{//generic constraint/jenerik kısıtlama
    //class:referans tip
    //IEntity: ıentity olabilir yada onu implement eden bir nesne  olabilir.
    //new: newlenebilir olmalı
    public interface IEntityReposityory<T> where T:class, IEntity, new() 
    {// burada Tnin alabileceği değerleri kısıtladık where koşulu ile
        List<T> GetAll(Expression<Func<T, bool>> filter=null);//expression ile filtreleme şartlarına gerek kalmadı
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       // List<T> GetAllByCategory(int categoryId); //ürünleri kategoriye göre filtrele
       //T Get metodu ile tek ürünü sorgulayabilecğimiz için artık  GetByCategory kısmına gerek kalmadı

    }
}
