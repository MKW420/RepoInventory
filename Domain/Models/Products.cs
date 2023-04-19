using APIPractice.Data.Base;

namespace APIPractice.Models
{
    public class Products : EntityBaseRepository
    {
        //[Foreign Key]

        public Guid Brand_Id { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Description { get; set; }
        public decimal Prod_Price { get; set; }
        public string Thumbnail { get; set; }
        public int Prod_Qty { get; set; }
 
    }
}
