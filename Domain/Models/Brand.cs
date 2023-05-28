using DomainLayer.Base;

using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    [Table("Brand")]
    public class Brand: EntityBaseRepository
    {
        public string Brand_Name { get; set; }
       
    }
}
