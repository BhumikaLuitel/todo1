using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            var data = new Todo();
            return View(data);
        }
        [HttpPost]
        public IActionResult Add (Todo data)
        {
            return RedirectToAction("Index");
        }
        public IActionResult Upsert(int id)
        {
             return View();
        }
        [HttpPost]
        public IActionResult Upsert(Todo t)
        {
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }
    }
    }

