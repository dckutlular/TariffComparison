using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TariffComparison.Data.Models.ProductModels;
using TariffComparison.Services.ProductService;

namespace TariffComparison.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("{consumption}")]
        public ActionResult<List<Product>> GetProducts(double consumption)
        {
            if (consumption < 0)
                return BadRequest("The annual consumption value can not be lower than 0");

            return _productService.GetComparedProducts(consumption);
        }
    }
}
