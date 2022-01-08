using Application.Cart;
using Database;
using Microsoft.AspNetCore.Mvc;

namespace ShopUI.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _ctx;
        public CartViewComponent(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IViewComponentResult Invoke(string view = "Default") {
            return View(view ,new GetCart(HttpContext.Session, _ctx).Do());
        }
    }
}