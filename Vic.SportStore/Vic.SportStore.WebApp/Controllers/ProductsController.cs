using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.Domain.Entities;
using Vic.SportsStore.WebApp.Models;
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
        public ViewResult List(string category,int page = 1)
        {
            //return View(Repository.Products);
            var result = Repository
                .Products
                .Where(p => category==null||p.Category== category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize);

            var pageinfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = PageSize,
                TotalItems = Repository
                .Products
                .Where(p => category == null || p.Category == category)
                .Count()
            };

            var vm = new ProductsListViewModel
            { 
                PagingInfo = pageinfo,
                Products = result,
                CurrentCategory = category 
            };


            return View(vm);

        }

    }


}