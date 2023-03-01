using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext context;
        public OrderController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        [Authorize(Roles = "Customer")]
        public IActionResult Create()
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            Order o = new Order();
            if (ModelState.IsValid)
            {
                o.UserId = currentUserID;
                o.Status = 0;
                context.Add(o);
                context.SaveChanges();
                TempData["OrderId"] = o.Id;
                return RedirectToAction("Create", "OrderDetail");
            }
            return RedirectToAction("Cart", "Cart");
        }

        public IActionResult Index()
        {
            var user = context.Users.ToList();
            ViewBag.Users = user;
            return View(context.Order.ToList());
        }
        public IActionResult Approved(int id)
        {
            var order = context.Order.Find(id);
            order.Status = 1;
            context.Order.Update(order);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Rejected(int id)
        {
            var order = context.Order.Find(id);
            order.Status = -1;
            context.Order.Update(order);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var order = context.Order.Include(o => o.OrderDetails).FirstOrDefault(o => o.Id == id);
            foreach (var od in order.OrderDetails)
            {
                var book = context.Book.Find(od.BookId);
                book.Quantity += od.Quantity;
                context.OrderDetail.Remove(od);
            }
            context.Order.Remove(order);
            context.SaveChanges();
            TempData["Message"] = "Delete order successfully !";
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {
            var order = context.Order.Include(o => o.OrderDetails)
                                     .ThenInclude(od => od.Book)
                                     .FirstOrDefault(o => o.Id == id);
            return View(order);
        }

        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var customer = context.Users.Where(u => u.Email.Contains(keyword)).ToList();
            var order = context.Order.ToList();
            List<Order> Result = new List<Order>();
            foreach (var o in order)
            {
                foreach (var c in customer)
                {
                    if (o.UserId.Equals(c.Id))
                    {
                        Result.Add(o);
                    }
                }
            }
            var user = context.Users.ToList();
            ViewBag.Users = user;
            return View("Index", Result);
        }
        
        public IActionResult Filter(int status)
        {
            var user = context.Users.ToList();
            ViewBag.Users = user;
            var order = context.Order.Where(o => o.Status.Equals(status)).ToList();
            return View("Index", order);
        }
    }
}