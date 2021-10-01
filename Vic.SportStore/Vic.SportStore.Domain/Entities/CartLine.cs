using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportStore.Domain.Entities
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
