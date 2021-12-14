using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using E_commerce.Domain.Entities;
using E_commerce.Infrastructure.Common.Interfaces;
using E_commerce.Infrastructure.Common.Specification;
using E_commerce.Infrastructure.Contracts.Products.Queries;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.API.Controllers
{
    public class TestingController : BaseController
    {
        private readonly IGenericRepository<Product> _productsRepo;
        private readonly IGenericRepository<ProductBrand> _productBrandsRepo;
        private readonly IGenericRepository<ProductType> _productTypesRepo;
        private readonly IMapper _mapper;

        public TestingController(IGenericRepository<ProductBrand> productBrandsRepo, 
            IGenericRepository<Product> productsRepo, 
            IGenericRepository<ProductType> productTypesRepo,
            IMapper mapper) 
        {
            _productBrandsRepo = productBrandsRepo;
            _productsRepo = productsRepo;
            _productTypesRepo = productTypesRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductDTO>>> Get(
            [FromQuery]ProductSpecParams productParams)
        {
            var spec = new ProductWithTypesAndBrandsSpecification(productParams);
            var product = await _productsRepo.ListAsync(spec);
            return Ok(_mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductDTO>>(product));
        }
    }
}