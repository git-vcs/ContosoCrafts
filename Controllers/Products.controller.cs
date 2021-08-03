using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ContosoCrafts.WebSite.Services;
using ContosoCrafts.WebSite.Models;

namespace ContosoCrafts.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

            public  JsonFileProductService ProductService { get; }

            public IEnumerable<Product> Get()
            {
                return ProductService.GetProducts();
            }

            [Route("Rate")]
            [HttpGet]
            public ActionResult Get([FromQuery]string productId, [FromQuery]int rating)
            {
                ProductService.AddRating(productId,rating);
                return Ok();
            }

    }
}