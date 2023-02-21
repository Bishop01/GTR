using BLL.DTOs;
using BLL.Services;
using GTR.Middleware;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTR.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        [Route("GetProducts")]
        public async Task<IActionResult> GetProducts(UserDTO user)
        {
            try
            {
                var result = await ProductService.GetProducts(user);
                return Ok(result);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        [HttpPost]
        [Route("GetCategories")]
        public async Task<IActionResult> GetCategories(UserDTO user)
        {
            try
            {
                var result = await ProductService.GetCategories(user);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddProduct([FromBody] ProductDTO product)
        {
            try
            {
                var result = await ProductService.AddProduct(product);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
    }
}
