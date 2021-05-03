using Business.ModelView;
using Data.BaseRepository;
using Data.Entity.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Presentation.Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Presentation.Dashboard.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            using (var context = new GvResourceContext())
            {
                var unitofwork = new UnitOfWork(context);
                IEnumerable<Product> customers = unitofwork.Queryable<Product>().ToList();
                DataSourceResult result = customers.ToDataSourceResult(request);
                return Json(result);
            }
        }

        public ActionResult AdaptiveRendering_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(Read().ToDataSourceResult(request));
        }


        public IList<ProductModel> GetAll()
        {
            using (var context = new GvResourceContext())
            {
                var unitofwork = new UnitOfWork(context);
                var lst = unitofwork.Queryable<Product>().ToList();
                return (IList<ProductModel>)lst;
            }
        }

        public IEnumerable<ProductModel> Read()
        {
            return GetAll();
        }
    }
}