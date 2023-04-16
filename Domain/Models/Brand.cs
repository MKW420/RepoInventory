using System.ComponentModel.DataAnnotations.Schema;

namespace APIPractice.Models
{
    [Table("Brand")]
    public partial class Brand
    {

        public Guid Id { get; set; }

        public string Brand_Name { get; set; }    
    }
}
