﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelockProject.BusinessLayer.Abstract;
using RelockProject.DtoLayer.Dtos.ProductDto;
using RelockProject.EntityLayer.Concrete;
using System.Threading.Tasks;

namespace RelockWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product2Controller : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public Product2Controller(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _productService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddProduct(ProductAddDto productAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Product>(productAddDto);
            _productService.TInsert(values);
            return Ok();
        }

        [HttpPut]

        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Product>(updateProductDto);
            _productService.TUpdate(values);
            return Ok("Başarıyla Güncellendi");
        }
    }
}
