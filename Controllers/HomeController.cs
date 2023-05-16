using Microsoft.AspNetCore.Mvc;
using TP04bis_CZERNUSZKA_KOZIUPA.Models;
namespace TP04bis_CZERNUSZKA_KOZIUPA.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.listaPaises = Info.ListarPais();
        return View("");
    }
    public IActionResult DetallePais(string pais){
        ViewBag.Pais = Info.DetallePais(pais);
        return View("detallePais.cshtml");
    }
}
