using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class Todo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            var data = new Models.Todo();

        return View(data);
        }
        public IActionResult formAdd()
        {
            var data1= new Todo();

            return View(data1);
        }
    }
}
