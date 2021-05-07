using Business.ModelView;
using Data.Entity.Models;
using System;
using System.Collections.Generic;
using Data.BaseRepository;
using System.Linq;
using Data.Entity;

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
                return null;
            }
        }
    }
}
