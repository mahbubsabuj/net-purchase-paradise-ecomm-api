using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PurchaseParadise.Api.Controllers;
using PurchaseParadise.Api.Dto;
using PurchaseParadise.Core.Interfaces;
using PurchaseParadise.Core.Models;
using PurchaseParadise.Core.Specifications;

namespace PurchaseParadise.Infrastructure.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : BaseApiController
{
    private readonly IGenericRepository<Product> _repository;
    private readonly IMapper _mapper;

    public ProductsController(IGenericRepository<Product> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<ProductDto>>> GetProducts()
    {
        ProductsWithTypesAndBrandsSpecification specifion = new();
        IReadOnlyList<Product> products = await _repository.GetAllEntityWithSpecification(specifion);

        IReadOnlyList<ProductDto> productsDto = _mapper.Map<IReadOnlyList<ProductDto>>(products);

        return Ok(productsDto);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProductDto>> GetProduct(int id)
    {
        ProductsWithTypesAndBrandsSpecification specifion = new(id);
        Product? product = await _repository.GetEntityWithSpecification(specifion);

        if (product == null)
        {
            return NotFound();
        }

        ProductDto productDto = _mapper.Map<ProductDto>(product);

        return Ok(productDto);
    }
}
