using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id); //ürünleri kategoriye göre getir
        List<Product> GetByUnitPrice(decimal min,decimal max);//şu fiyat aralığındaki ürünleri getir
        void Add( Product product);
        void Update(Product product);
        void Delete(Product product);



    }
}
