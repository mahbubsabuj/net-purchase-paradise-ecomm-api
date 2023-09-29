using Microsoft.AspNetCore.Mvc;
using PurchaseParadise.Core.Interfaces;
using PurchaseParadise.Core.Models;

namespace PurchaseParadise.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductBrandsController : ControllerBase
{
    private readonly IGenericRepository<ProductBrand> _repository;

    public ProductBrandsController(IGenericRepository<ProductBrand> repository)
    {
        _repository = repository;
    }

    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetAllProductBrands()
    {
        return Ok(await _repository.GetAllAsync());
    }
}
