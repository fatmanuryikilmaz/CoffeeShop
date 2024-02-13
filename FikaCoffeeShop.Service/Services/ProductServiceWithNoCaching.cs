using AutoMapper;
using FikaCoffeeShop.Core.DTOs;
using FikaCoffeeShop.Core.Models;
using FikaCoffeeShop.Core.Repositories;
using FikaCoffeeShop.Core.Services;
using FikaCoffeeShop.Core.UnitOfWorks;
using FikaCoffeeShop.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikaCoffeeShop.Service.Services
{
    public class ProductServiceWithNoCaching : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductServiceWithNoCaching(IUnitOfWork unitOfWork, IGenericRepository<Product> repository, IMapper mapper, IProductRepository productRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
        {
            var products=await _productRepository.GetProductsWithCategory();
            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);
            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200,productsDto);

        }
    }
}
