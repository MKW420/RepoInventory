
using DomainLayer.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIPractice.Models
{
    public class Suppliers: EntityBaseRepository
    {
        //[ForeignKey]
        public Guid Brand_Id { get; set; }

        public string Supplier_Name { get; set; }

        public string Supplier_Addr { get; set; }
    }
}
