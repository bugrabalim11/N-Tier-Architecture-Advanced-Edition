using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinnesLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal? _productDal;

        public ProductManager()
        {
        }

        public ProductManager(IProductDal? productDal) // Constructor metot
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            _productDal?.Delete(t);
        }

        public Product? TGetById(int id)
        {
            return _productDal!.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _productDal!.GetList();
        }

        public void TInsert(Product t)
        {
              _productDal?.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal?.Update(t);
        }
    }
}
