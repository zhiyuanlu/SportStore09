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

        public const int PageSize = 3;
        //private IProductsRepository repository = new InMemoryProductRepository();

        //Property Dependecy 
        public IProductsRepository Repository { get; set; }

        //Constructor Dependecy
        //private IProductsRepository _repository;
        //public ProductsController(IProductsRepository Repository) 
        //{
        //    _repository = Repository;
        //}


        // GET: Products
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult List(int page = 1)
        {
            //return View(Repository.Products);
            var result = Repository
                .Products
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize);

            return View(result);

        }

    }


}