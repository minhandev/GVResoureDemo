using Business.ModelView;
using Data.Entity.Models;
using System;
using System.Collections.Generic;
using Data.BaseRepository;
using System.Linq;

namespace Business.Services
{
    public class ProductServices 
    {
        public ProductServices()
        {

        }

        public List<ProductModel> getProduct()
        {
            using (var context = new GvResourceContext())
            {
                var UnitOfWork = new UnitOfWork(context);
                var lstProduct = UnitOfWork.Queryable<Product>().Select(s=> new ProductModel { }).ToList();
                if (lstProduct != null)
                {
                    return lstProduct;
                }
                return null;
            }
        }
    }
}
