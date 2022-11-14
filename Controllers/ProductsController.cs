using abstractfactory_mydramalist.Clients;
using abstractfactory_mydramalist.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace abstractfactory_mydramalist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("dorama")]
        public IActionResult SearchDorama([FromQuery] TypeProduct typeProduct)
        {
            var productClient = ProductClient.CreateProductClient(typeProduct);

            var doramas = productClient.SearchDorama();

            if (doramas == null)
            {
                return BadRequest();
            }

            return Ok(doramas);
        }
    }
}
