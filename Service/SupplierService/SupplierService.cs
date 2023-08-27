using APIPractice.Models;
using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.SupplierService
{
    public class SupplierService : ISupplierService
    {



        private IRepository<Suppliers> _repository;

        public SupplierService(IRepository<Suppliers> repository)
        {
            _repository = repository;
        }

        public void DeleteSupplier(Guid id)
        {
            try
            {
                if (id != null)
                {
                    Suppliers supplier = GetSupplierById(id);
                    _repository.Remove(supplier);
                    _repository.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;

            }
        }

        public IEnumerable<Suppliers> GetAllSuppliers()
        {
            try
            {
                var obj = _repository.GetAll();

                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;

            }
        }

        public Suppliers GetSupplierById(Guid id)
        {
            try
            {
                var obj = _repository.Get(id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertSupplier(Suppliers supplier)
        {
            _repository.Insert(supplier);
        }

        public void UpdateSupplier(Suppliers supplier)
        {
            try
            {
                if (supplier != null)
                {

                    _repository.Update(supplier);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
