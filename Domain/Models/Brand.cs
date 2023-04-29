using APIPractice.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIPractice.Models
{
    //[Table("Brand")]
    public class Brand: EntityBaseRepository
    {
       
        public string Brand_Name { get; set; }
       
    }
}
