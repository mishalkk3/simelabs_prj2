using System.Collections.Generic;
using System.Linq;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Application.Cart
{
    public class AddToCart
    {
        private readonly ISession _session;
        public AddToCart(ISession session)
        {
            _session = session;
        }

        public class Request
        {
            public int StockId { get; set; }
            public int Qty { get; set; }
        }

        public void Do(Request request)
        {
            var cartList = new List<CartProduct>();

            var stringObject = _session.GetString("cart");
            if (!string.IsNullOrEmpty(stringObject))
            {
                cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);
            }

            if (cartList.Any(x => x.StockId == request.StockId))
            {
                cartList.Find(x => x.StockId == request.StockId).Qty += request.Qty;
            }
            else
            {
                cartList.Add(new CartProduct
                {
                    StockId = request.StockId,
                    Qty = request.Qty
                });
            }

            stringObject = JsonConvert.SerializeObject(cartList);
            _session.SetString("cart", stringObject);
        }
    }
}