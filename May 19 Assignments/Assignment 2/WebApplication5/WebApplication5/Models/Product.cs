using System.ComponentModel;

namespace WebApplication5.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        //public Category Category { get; set; }
    }
    //public class Category
    //{
    //    public int CategoryId { get; set; }
    //    public string CategoryName { get; set; }
    //    public ICollection<Product> Products { get; set; }
    //}

}
