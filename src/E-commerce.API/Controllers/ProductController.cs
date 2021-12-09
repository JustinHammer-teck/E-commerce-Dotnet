using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using E_commerce.Domain.Entities;
using E_commerce.Domain.Error;
using E_commerce.Infrastructure.Common.Interfaces;
using E_commerce.Infrastructure.Common.Specification;
using E_commerce.Infrastructure.Contracts.Products.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.API.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IGenericRepository<Product> _productsRepo;
        private readonly IGenericRepository<ProductBrand> _productBrandsRepo;
        private readonly IGenericRepository<ProductType> _productTypesRepo;

        private readonly IMapper _mapper;

        public ProductController(
            IGenericRepository<Product> productsRepo,
            IGenericRepository<ProductBrand> productBrandsRepo,
            IGenericRepository<ProductType> productTypesRepo, 
            IMapper mapper)
        {
            _productsRepo = productsRepo;
            _productBrandsRepo = productBrandsRepo;
            _productTypesRepo = productTypesRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductDTO>>> GetAllProducts()
        {

            var spec = new ProductWithTypesAndBrandsSpecification();

            var products = await _productsRepo.ListAsync(spec);

            return Ok(_mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductDTO>>(products));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductDTO>> GetProduct(int id)
        {
            var spec = new ProductWithTypesAndBrandsSpecification(id);

            var product = await _productsRepo.GetEntityWithSpec(spec);

            if (product == null) return NotFound(new ErrorResponse(400));

            return Ok(_mapper.Map<Product, ProductDTO>(product));
        }


        [HttpGet("brands")]
        public async Task<IActionResult> GetAllProductBrands()
        {
            return Ok(await _productBrandsRepo.GetAllAsync());
        }

        [HttpGet("types")]
        public async Task<IActionResult> GetAllProductTypes()
        {
            return Ok(await _productTypesRepo.GetAllAsync());
        }
    }
}