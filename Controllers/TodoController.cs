using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index(Todo data)
        {
            return View(data);
        }
        public IActionResult Add()
        {
            var data = new Todo();
            return View(data);
        }
        [HttpPost]
        public IActionResult Add (Todo data)
        {
            return RedirectToAction("Index", data);
        }
        public IActionResult Upsert(int id)
        {

            //db dekhi id lera todo ko data tanera view vitra bata pass gardine
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

