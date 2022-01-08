using Database;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using Application.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Application.Cart;
using System.Collections.Generic;

namespace ShopUI.Pages
{
    public class CartModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;
        public CartModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<GetCart.Response> Cart { get; set; }
        public IActionResult OnGet()
        {
            Cart = new GetCart(HttpContext.Session, _ctx).Do();
            return Page();
        }
    }
}