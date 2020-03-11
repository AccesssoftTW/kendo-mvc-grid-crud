using kendo_grid_crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace kendo_grid_crud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }


        public ActionResult GetAll([DataSourceRequest]DataSourceRequest request)
        {
            var products = new List<Product>();

            for (int i = 1; i < 21; i++)
            {
                var product = new Product();
                product.ProductID = i;
                product.ProductName = "Product-" + i.ToString();
                product.UnitPrice = i * 10;
                products.Add(product);
            }
            return Json(products.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add([DataSourceRequest]DataSourceRequest request, Product product)
        {

            return Json(product, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update([DataSourceRequest]DataSourceRequest request, Product product)
        {

            return Json(product, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete([DataSourceRequest]DataSourceRequest request, Product product)
        {

            return Json(product, JsonRequestBehavior.AllowGet);
        }
    }
}
