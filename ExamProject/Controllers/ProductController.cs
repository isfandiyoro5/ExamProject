using ExamProject.Models;
using ExamProject.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamProject.Controllers
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

       /* [HttpGet]
        public ActionResult<Product> GetProduct(Product product)
        {
            _productService.GetProduct(product);
            return product;
        }*/
        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            _productService.AddProduct(product);
            return product;
        }
    }
}
