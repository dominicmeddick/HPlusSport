using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPlusSport.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSport.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context) {

            _context = context;

            _context.Database.EnsureCreated();
        }
        [HttpGet]
        public IEnumerable<Product> GetAllProducts() {
            return _context.Products.ToArray();
        }
    }
}