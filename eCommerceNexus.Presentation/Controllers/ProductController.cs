using Microsoft.AspNetCore.Mvc;
using eCommerceNexus.Domain.Entities;
using eCommerceNexus.Application.Services.Interfaces;

namespace eCommerceNexus.Presentation.Controllers
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
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _productService.GetAllProductsAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _productService.UpsertProductAsync(product);

            return CreatedAtRoute("GetProduct", new { }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingProduct = await _productService.GetProductByIdAsync(id);

            if (existingProduct == null)
            {
                return NotFound("Product with the provided ID not found.");
            }

            product.Id = existingProduct.Id;
            await _productService.UpsertProductAsync(product);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var existingProduct = await _productService.GetProductByIdAsync(id);

            if (existingProduct == null)
            {
                return NotFound("Product with the provided ID not found.");
            }

            await _productService.DeleteProductAsync(id);

            return NoContent();
        }
    }
}