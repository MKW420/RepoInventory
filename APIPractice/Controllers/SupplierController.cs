using APIPractice.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.SupplierService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {

        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        // GET: api/<SupplierController>
        [HttpGet(nameof(GetAllSuppliers))]
        public IEnumerable<Supplier> GetAllSuppliers()
        {

            foreach (var supplier in _supplierService.GetAllSuppliers())
            {
                yield return supplier;
            }



        }


        // GET api/<SupplierController>/5
        [HttpGet(nameof(GetSuppliersByID))]
        public IActionResult GetSuppliersByID(Guid id)
        {
            var supplier = _supplierService.GetSupplierById(id);

            if (supplier is not null)
            {
                return Ok(supplier);
            }
            return BadRequest("No records found");
        }



        // POST api/<SupplierController>
        [HttpPost(nameof(InsertSuppliers))]
        public IActionResult InsertSuppliers(Supplier supplier)
        {
            _supplierService.InsertSupplier(supplier);
            return Ok("Data succesfully inserted");


        }


        // PUT api/<SupplierController>/5
        [HttpPut(nameof(UpdateSuppliers))]
        public IActionResult UpdateSuppliers(Supplier supplier)
        {

            _supplierService.UpdateSupplier(supplier);
            return Ok("Updating done");
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete(nameof(DeleteSupplier))]
        public IActionResult DeleteSupplier(Guid id)
        {
            _supplierService.DeleteSupplier(id);
            return Ok("Deleted Data!");

        }
    }
}
