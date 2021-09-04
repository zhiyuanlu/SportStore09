using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.WebApp.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsRepository repository = new InMemoryProductRepository();
        // GET: Products
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult List()
        {
            return View(repository.Products);
        }

    }


}