using System.Collections.Generic;
using System.Linq;
using Database;
using Microsoft.EntityFrameworkCore;

namespace Application.StockAdmin
{
    public class GetStock
    {
        private readonly ApplicationDbContext _ctx;
        public GetStock(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<ProductViewModel> Do(){
            var stock = _ctx.Products
                .Include(x => x.Stock)
                .Select(x => new ProductViewModel 
                { 
                    Id = x.Id,
                    Description = x.Description,
                    Stock = x.Stock.Select( y=> new StockViewModel 
                    {
                        Id = y.Id,
                        Description = y.Description,
                        Qty = y.Qty
                    })
                })
                .ToList();

            return stock;
        }

        public class StockViewModel
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public int Qty { get; set; }
        }

        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public IEnumerable<StockViewModel> Stock { get; set; }
        }
        
    }
}