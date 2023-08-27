using DomainLayer.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIPractice.Models
{
  
    public class Category: EntityBaseRepository
    {

        public string Category_Name { get; set; }
    }
}
