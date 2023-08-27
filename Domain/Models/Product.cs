
using DomainLayer.Base;

namespace APIPractice.Models
{
    public class Product : EntityBaseRepository
    {
        //[Foreign Key]

        public Guid Brand_Id { get; set; }
        public Guid Category_Id { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Description { get; set; }
        public decimal Prod_Price { get; set; }
        //public string Thumbnail { get; set; }
        public int Prod_Qty { get; set; }
        public bool on_sale { get; set; }
        public bool discontinued { get; set; }
      //  public DateTime Discontinued_date { get; set; }
        public decimal Discounted_Price { get; set; }

 
    }
}
