using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start ...");
            using (var ctx = new EFDbContext())
            {
                //var product = new Product() {Name="Football", Price = 25 };

                

                for (int i = 0; i < 10; i++)
                {
                    var product = new Product
                    {
                        Name = $"Football{i}",
                        Price = i + 12,
                        Description = $"this is football {i}"

                    };
                    ctx.Products.Add(product);
                
                }


                ctx.SaveChanges();

            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
