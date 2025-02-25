using EComDAL.DTOs;
using EComDAL.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EComWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [Authorize]
        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();

            if (products == null)
            {
                throw new KeyNotFoundException($"Product List Empty");
            }

            return Ok(products);
        }

        [Authorize]
        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productRepository.GetProduct(id);
            if (product == null)
            {
                throw new KeyNotFoundException($"Product with id: {id} not found");
            }
            return Ok(product);
        }

        [Authorize]
        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct([FromBody] Productdto productdto)
        {
            if (productdto == null)
            {
                throw new ArgumentNullException(nameof(productdto));
            }
            await _productRepository.AddProduct(productdto);
            return Ok("Product Added Successfully");
        }

        [Authorize]
        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] Productdto productdto, int Id)
        {
            if (productdto == null)
            {
                throw new ArgumentNullException(nameof(productdto));
            }
            await _productRepository.UpdateProduct(productdto, Id);
            return Ok("Product Updated Successfully");
        }

        [Authorize]
        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int Id)
        {
            await _productRepository.DeleteProduct(Id);
            return Ok("Product Deleted Successfully");
        }
    }
}
