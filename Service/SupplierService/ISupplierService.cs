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


        IEnumerable<Supplier> GetAllSuppliers();

        Supplier GetSupplierById(Guid id);

        void InsertSupplier(Supplier supplier);

        void UpdateSupplier(Supplier supplier);

        void DeleteSupplier(Guid id);

    }
}
