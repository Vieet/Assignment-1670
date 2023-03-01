using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Assignment.Controllers
{
    public class CategoryRequestController : Controller
    {
        private ApplicationDbContext context;
        public CategoryRequestController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        public IActionResult Index()
        {
            var request = context.Request.ToList();
            return View(request);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryRequest request)
        {
            if (ModelState.IsValid)
            {
                context.Add(request);
                context.SaveChanges();
                TempData["Message"] = "Requested a new category to the admin !";
                return RedirectToAction("Create");
            }
            return View(request);
        }

        public IActionResult Approved(int id)
        {
            var request = context.Request.Find(id);
            request.Status = 1;
            context.Request.Update(request);
            context.SaveChanges();
            TempData["Category"] = request.Category;
            return RedirectToAction("Create", "Category");
        }

        public IActionResult Rejected(int id)
        {
            var request = context.Request.Find(id);
            request.Status = -1;
            context.Request.Update(request);
            context.SaveChanges();
            TempData["Message"] = "Request rejected!";
            return RedirectToAction("Index");
        }
    }
}
