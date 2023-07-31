using Microsoft.AspNetCore.Mvc;
using ProductStock.EntityConfiguration;

namespace ProductStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductStockContext _context;
        public ProductController(ProductStockContext context)
        {
            _context= context;  
        }
        [HttpGet]
        public IActionResult GetValue()
        {
            
            var value = _context.Products;
            return Ok(value);
        }
    }
}
