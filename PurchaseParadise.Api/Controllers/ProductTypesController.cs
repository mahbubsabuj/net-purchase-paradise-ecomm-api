using Microsoft.AspNetCore.Mvc;
using PurchaseParadise.Core.Interfaces;
using PurchaseParadise.Core.Models;

namespace PurchaseParadise.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeRepository _repository;

        public ProductTypesController(IProductTypeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetAllProductTypes()
        {
            return Ok(await _repository.GetAllProductTypesAsync());
        }
    }
}
