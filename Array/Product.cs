using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class Details
    {
        static void Main(string[] args)
        {
            Product[] list = new Product[]
            {
                new Product { Id = 1, Name = "Iphone",Price =85000 },
                new Product { Id = 2,Name = "Onpluse",Price =30000},
                new Product { Id = 3,Name = "Redmi7A",Price =6500}
            };
            foreach(Product p in list)
            {
                Console.WriteLine($"{ p.Id}{ p.Name}{ p.Price}");

            }
        }
    }
}
