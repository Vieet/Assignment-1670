using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext context;
        public CartController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public const string CARTKEY = "cart";

        List<CartItem> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        public void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }

        [Route("addcart/{bookid:int}", Name = "addcart")]
        public IActionResult AddToCart([FromRoute] int bookid)
        {

            var book = context.Book
                .Where(b => b.Id == bookid)
                .FirstOrDefault();
            if (book == null)
                return NotFound("No book!");

            var cart = GetCartItems();
            var cartitem = cart.Find(b => b.book.Id == bookid);
            if (cartitem != null)
            {
                cartitem.quantity++;
            }
            else
            {
                cart.Add(new CartItem() { quantity = 1, book = book });
            }

            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        [Route("/cart", Name = "cart")]
        public IActionResult Cart()
        {
            return View(GetCartItems());
        }

        [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] int bookid, [FromForm] int quantity)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(b => b.book.Id == bookid);
            if (cartitem != null)
            {
                cartitem.quantity = quantity;
            }
            if (quantity > cartitem.book.Quantity)
            {
                TempData["Message"] = "Order failed!";
            }
            else
            {
                SaveCartSession(cart);
            }
            return Ok();
        }

        [Route("/removecart/{bookid:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int bookid)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(b => b.book.Id == bookid);

            if (cartitem != null)
            {
                cart.Remove(cartitem);
            }

            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        public IActionResult MakeOrder()
        {
            return RedirectToAction("Create", "Order");
        }


    }
}
