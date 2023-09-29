using Microsoft.AspNetCore.Mvc;
using PurchaseParadise.Core.Interfaces;
using PurchaseParadise.Core.Models;

namespace PurchaseParadise.Infrastructure.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IGenericRepository<Product> _repository;

    public ProductsController(IGenericRepository<Product> repository)
    {
        _repository = repository;
    }

    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts()
    {
        IReadOnlyList<Product> products = await _repository.GetAllAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        Product? product = await _repository.GetByIdAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }
}
