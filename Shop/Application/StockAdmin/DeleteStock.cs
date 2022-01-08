using System.Linq;
using System.Threading.Tasks;
using Database;

namespace Application.StockAdmin
{
    public class DeleteStock
    {
        private readonly ApplicationDbContext _ctx;
        public DeleteStock(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var stock = _ctx.Stock.FirstOrDefault(x => x.Id == id);
            _ctx.Stock.Remove(stock);
            
            await _ctx.SaveChangesAsync();
            return true;
        }
    }
}