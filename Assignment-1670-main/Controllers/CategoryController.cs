using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext context;
        public CategoryController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(context.Category.ToList());
        }

        public IActionResult Delete(int id)
        {
            var category = context.Category.Find(id);
            context.Category.Remove(category);
            context.SaveChanges();
            TempData["Message"] = "Delete category successfully !";
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {
            var category = context.Category.Include(c => c.Books)
                                     .FirstOrDefault(c => c.Id == id);
            return View(category);
        }

        public IActionResult Create()
        {
            Category c = new Category();
            if (ModelState.IsValid)
            {
                c.Name = (string)TempData["Category"];
                context.Add(c);
                context.SaveChanges();
                TempData["Message"] = "Add category successfully !";
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(context.Category.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Update(category);
                context.SaveChanges();
                TempData["Message"] = "Edit category successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
    }
}
