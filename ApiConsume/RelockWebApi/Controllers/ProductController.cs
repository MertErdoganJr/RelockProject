using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelockProject.BusinessLayer.Abstract;
using RelockProject.EntityLayer.Concrete;

namespace RelockWebApi.Controllers
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
        public IActionResult ProductList()
        {
            _productService.TGetList();
            return Ok();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TInsert(product);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var values = _productService.TGetById(id);
            _productService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetById(id);
            return Ok(values);
        }
    }
}
