using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDForMySQLWithEFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly MySQLDbContext dbContext;

        public ProductController(ILogger<ProductController> logger,MySQLDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddProducts(Products products)
        {
            dbContext.Products.Add(products);
            await dbContext.SaveChangesAsync();
            return Ok(products);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var allProducts = await dbContext.Products.ToListAsync();
            return Ok(allProducts);
        }

    }
}
