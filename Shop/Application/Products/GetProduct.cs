using System.Collections.Generic;
using System.Linq;
using Database;
using Microsoft.EntityFrameworkCore;

namespace Application.Products
{
    public class GetProduct
    {
        private readonly ApplicationDbContext _ctx;
        public GetProduct(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public ProductViewModel Do(string name) => 
            _ctx.Products
                .Where(x => x.Name == name)
                .Include(x => x.Stock)
                .Select(x => new ProductViewModel {
                    Name = x.Name,
                    Description = x.Description,
                    Value = $"Rs. {x.Value.ToString("N2")}",
                    Stock = x.Stock.Select(y => new StockViewModel
                    {
                        Id = y.Id,
                        Description = y.Description,
                        Instock = y.Qty > 0
                    })
                }).FirstOrDefault();

        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Value { get; set; }
            public IEnumerable<StockViewModel> Stock { get; set; }
        }

        public class StockViewModel
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public bool Instock { get; set; }
        }
    }
}