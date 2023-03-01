using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    
    public class BookController : Controller
    {
        private ApplicationDbContext context;
        public BookController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        [Authorize(Roles = "StoreOwner")]   
        public IActionResult Index()
        {
            var books = context.Book.OrderByDescending(b => b.Id).ToList();
            return View(books);
        }

        [Authorize(Roles = "Customer")]
        public IActionResult Store()
        {
            return View(context.Book.ToList());
        }

        [Authorize(Roles = "StoreOwner")]
        public IActionResult Delete(int id)
        {
            var book = context.Book.Find(id);
            context.Book.Remove(book);
            context.SaveChanges();
            TempData["Message"] = "Delete book successfully !";
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin, StoreOwner, Customer")]
        public IActionResult Detail(int id)
        {
            var book = context.Book.Include(b => b.Category) 
                                       .FirstOrDefault(c => c.Id == id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Category = context.Category.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            ViewBag.Category = context.Category.ToList();
            if (ModelState.IsValid)
            {
                context.Book.Add(book);
                context.SaveChanges();
                TempData["Message"] = "Add new book successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = context.Category.ToList();
            return View(context.Book.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Update(book);
                context.SaveChanges();
                TempData["Message"] = "Edit book successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public IActionResult PriceAsc()
        {
            var Books = context.Book.OrderBy(b => b.Price).ToList();
            return View("Store", Books);
        }

        public IActionResult PriceDesc()
        {
            var Books = context.Book.OrderByDescending(b => b.Price).ToList();
            return View("Store", Books);
        }

        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var Books = context.Book.Where(b => b.Title.Contains(keyword)).ToList();
            return View("Store", Books);
        }


        [Route("/checkout")]
        public IActionResult CheckOut()
        {
            return View();
        }
    }
}
