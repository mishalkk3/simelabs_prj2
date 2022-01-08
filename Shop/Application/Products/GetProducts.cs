using System.Collections.Generic;
using System.Linq;
using Database;

namespace Application.Products
{
    public class GetProducts
    {
        private readonly ApplicationDbContext _ctx;
        public GetProducts(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<ProductViewModel> Do() => 
            _ctx.Products.ToList().Select(x => new ProductViewModel {
                Name = x.Name,
                Description = x.Description,
                Value = $"Rs. {x.Value.ToString("N2")}"
            });

        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Value { get; set; }
        }
    }
}