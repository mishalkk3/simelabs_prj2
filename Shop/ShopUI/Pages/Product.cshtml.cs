using Database;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using Application.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Application.Cart;

namespace ShopUI.Pages
{
    public class ProductModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;
        public ProductModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public class Test {
            public string Id { get; set; }
        }

        [BindProperty]
        public AddToCart.Request CartViewModel { get; set; }

        public  GetProduct.ProductViewModel Product { get; set; }
        public IActionResult OnGet(string name)
        {
            Product = new GetProduct(_ctx).Do(name.Replace('-',' '));
            if(Product == null)
                return RedirectToPage("Index");
            else
                return Page();
        }

        public IActionResult OnPost() {
            new AddToCart(HttpContext.Session).Do(CartViewModel);
            return RedirectToPage("Cart");
        }
    }
}