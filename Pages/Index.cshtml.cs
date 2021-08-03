using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;


namespace ContosoCrafts.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private JsonFileProductService ProductService;

        public IEnumerable<Product> Products{get; private set;}
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        // loading page
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
