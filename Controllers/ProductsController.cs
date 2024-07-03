
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Services;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("/search")]
        public ActionResult<IEnumerable<Product>> Search([FromQuery] string text)
        {
            var products = _productService.SearchProducts(text);
            return Ok(products);
        }

    }
}

