using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;
namespace platzi_asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index(){
            var Escuela = new Escuela();
            Escuela.Nombre= "Platzi";
            Escuela.Id=Guid.NewGuid().ToString();
            Escuela.AnioFundacion=2018;
            return View(Escuela);
        }
    }
}