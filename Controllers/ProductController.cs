using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoPessoal.Data.VOs;
using ProjetoPessoal.Repository;

namespace ProjetoPessoal.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _productRepository.GetProductsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducts(long id)
        {
            return Ok(await _productRepository.GetProductByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveProduct(ProductVO productVO)
        {
            try
            {
                await _productRepository.SaveProductAsync(productVO);
                return Created("", "Salvo com sucesso!");
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductVO productVO)
        {
            try
            {
                if (productVO.Id is null) throw new Exception("Informe o ID!");
                return Ok(await _productRepository.UpdateProductAsync(productVO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(long id)
        {
            try
            {
                return Ok(await _productRepository.DeleteProductAsync(id));
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
