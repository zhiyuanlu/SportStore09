using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportStore.Domain.Abstract;
using Vic.SportStore.Domain.Concrete;

namespace Vic.SportStore.WebApp.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsRepository repository = new InMemoryProductRepository();
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
    }


}