﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.Domain.Concrete
{
    public class InMemoryProductRepository : IProductsRepository
    {
        private List<Product> _products = new List<Product>
{
new Product { Name = "Football", Price = 25 },
new Product { Name = "Surf board", Price = 179 },
new Product { Name = "Running shoes", Price = 95 }
};
        public IEnumerable<Product> Products
        {
            get { return _products; }
        }
    }

}
