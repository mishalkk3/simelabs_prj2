using System.Collections.Generic;

namespace Domain.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<OrderStock> OrderStocks { get; set; } 
    }
}