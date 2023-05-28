using DomainLayer.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIPractice.Models
{
    [Table("CATEGORY")]
    public class Category: EntityBaseRepository
    {

        public string Category_Name { get; set; }
    }
}
