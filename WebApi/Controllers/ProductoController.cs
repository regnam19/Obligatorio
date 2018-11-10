using WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ProductoController : ApiController
    {
        Productos[] products = new Productos[] {
            new Productos { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Productos { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Productos { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };
        public IEnumerable<Productos> GetAllProducts() { return products; }
        public IHttpActionResult GetProductos(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
