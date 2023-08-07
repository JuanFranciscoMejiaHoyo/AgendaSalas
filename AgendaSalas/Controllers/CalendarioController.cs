using Microsoft.AspNetCore.Mvc;



namespace AgendaSalas.Controllers
{
    public class CalendarioController : Controller
    {
        public ActionResult Calendario()
        {
            return View();
        }
    }
}
