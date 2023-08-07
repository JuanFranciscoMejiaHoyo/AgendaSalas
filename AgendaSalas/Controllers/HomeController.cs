using Microsoft.AspNetCore.Mvc;
namespace AgendaSalas.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
