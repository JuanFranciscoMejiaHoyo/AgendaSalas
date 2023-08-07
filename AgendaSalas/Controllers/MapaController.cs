using AgendaSalas.Models;
using AgendaSalas.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;

namespace AgendaSalas.Controllers
{
    public class MapaController : Controller
    {
        private readonly IRepositorioMapa repositorioMapa;

        public MapaController(IRepositorioMapa repositorioMapa)
        {
            this.repositorioMapa = repositorioMapa;
        }
        public ActionResult Staff(string Acceso)
        {
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.UtcNow.AddHours(1) // Puedes ajustar el tiempo de expiración
            };

            Response.Cookies.Append("AccesoCookie", Acceso, cookieOptions); // Establece la cookie

            return RedirectToAction("mapainfo");
        }

        public ActionResult mapainfo()
        {
            var accesoCookie = Request.Cookies["AccesoCookie"];
            ViewBag.AccesoCookie = accesoCookie;

            return View();
        }

        public async Task<IActionResult> AgendaSala1(MapaModel mapaModel)
        {
            await repositorioMapa.InsertarEvento(mapaModel);
            return View("mapainfo");
        }
        public async Task<IActionResult> AgendaSala2(MapaModel mapaModel)
        {
            await repositorioMapa.InsertarEvento(mapaModel);
            return View("mapainfo");
        }
        public async Task<IActionResult> AgendaSala3(MapaModel mapaModel)
        {
            await repositorioMapa.InsertarEvento(mapaModel);
            return View("mapainfo");
        }


        public async Task<IActionResult> ZonaComun(MapaModel mapaModel)
        {
            await repositorioMapa.InsertarEvento(mapaModel);
            return View("mapainfo");
        }

        
    }
}
