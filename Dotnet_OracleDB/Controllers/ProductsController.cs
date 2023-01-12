using Dotnet_OracleDB.Context;
using Dotnet_OracleDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_OracleDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly OracleDbContext _context;

        public ProductsController(OracleDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _context.Productos.ToList();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpPost]
        public ActionResult<Product> Add(Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            _context.Productos.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }
    }
}
