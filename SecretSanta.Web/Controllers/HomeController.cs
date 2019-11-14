using Microsoft.AspNetCore.Mvc;
using SecretSanta.Web.Models;

namespace SecretSanta.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDatabaseInstance _db;

        public HomeController(IDatabaseInstance db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(string name, string email)
        {
            _db.AddPerson(new Person { Email = email, Name = name });

            return Ok();
        }
    }
}
