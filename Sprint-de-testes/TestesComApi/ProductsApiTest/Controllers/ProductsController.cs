using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApiTest.Domains;
using ProductsApiTest.Interfaces;
using ProductsApiTest.Repositories;

namespace ProductsApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private IProductsRepository _productsRepository {  get; set; }

        public ProductsController(IProductsRepository p)
        {
            _productsRepository = p;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_productsRepository.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id) 
        {
            try
            {
                return Ok(_productsRepository.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Products product)
        {
            try
            {
                _productsRepository.Post(product);

                return StatusCode(201, product);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")] 
        public IActionResult Put(Products product, Guid id) 
        {
            try
            {
                _productsRepository.Put(id, product);

                return StatusCode(201, product);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id) 
        {
            try
            {
                _productsRepository.Delete(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
