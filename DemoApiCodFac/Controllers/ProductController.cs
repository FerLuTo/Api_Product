using DemoApiCodFac.Models;
using DemoApiCodFac.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApiCodFac.Controllers
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
        public IActionResult GetAllProduct()
        {
           List<ProductEntity> product =  _productService.GetAllProduct();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody]ProductModel product)
        {
            _productService.CreateProduct(product);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProduct([FromQuery]int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }

        [HttpGet]
        [Route("getproduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            ProductEntity product = _productService.GetProductById(id);
            return Ok(product);
        }
    }
}
