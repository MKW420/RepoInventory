﻿using RepositoryLayer;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.BrandService;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {


        private readonly IBrandService _brandService;

        
        //var _Db;
     //   private AppDbContext _context;
        public BrandController(IBrandService brandService)
        {
           _brandService = brandService;
        }


        //// GET: api/<BrandsController>
        //[HttpGet("{GetBrandByID]
        //public IActionResult GetBrands(Guid id)
        //{
        //    var brand = _brandService.GetBrandById(id);

        //   if(brand is not null){
        //         return Ok(brand);
        //    }
        //    return BadRequest("No records found");    
        //}


        // GET api/<BrandsController>/5
        [HttpGet(nameof(GetAllBrands))]
        public IEnumerable<Brand> GetAllBrands()
        {
            
            foreach (var brand in _brandService.GetAllBrands())
            {
                yield return brand;
            }

        }

        // POST api/<BrandsController>
        [HttpPost(nameof(InsertBrand))]
        public IActionResult InsertBrand(Brand brand)
        { 

          
            _brandService.InsertBrand(brand);
            return Ok("Data successfully inserted");


        }

        // PUT api/<BrandsController>/5
        [HttpPut(nameof(UpdateBrand))]
        public IActionResult UpdateBrand(Brand brand)
        {

            _brandService.UpdateBrand(brand);
            return Ok("Updating done");
        }

        // DELETE api/<BrandsController>/5
        [HttpDelete(nameof(DeleteBrand))]
        public IActionResult DeleteBrand(Guid id)
        {
            _brandService.DeleteBrand(id);
            return Ok("Deleted Data!");

        }
    }
}
