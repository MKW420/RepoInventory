using APIPractice.Models;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.SupplierService
{
    public interface ISupplierService
    {


        IEnumerable<Suppliers> GetAllSuppliers();

        Suppliers GetSupplierById(Guid id);

        void InsertSupplier(Suppliers supplier);

        void UpdateSupplier(Suppliers supplier);

        void DeleteSupplier(Guid id);

    }
}
