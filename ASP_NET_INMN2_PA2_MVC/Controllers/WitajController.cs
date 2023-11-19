using Microsoft.AspNetCore.Mvc;
using ASP_NET_INMN2_PA2_MVC.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ASP_NET_INMN2_PA2_MVC.Controllers;
public class WitajController : Controller
{
    /*public string Index(int? id)
    {
        return $"otrzymane id to {id}";
    }*/
    public IActionResult Index(int? id, string? tekst)
    {
        ViewData["id"] = id;
        ViewData["tekst"] = tekst;
        return View();
    }
    public IActionResult Witaj(string? imię, int? id)
    {
        //mocno niewskazane
        /*ViewData["ilość"] = id;
        ViewData["imię"] = imię;*/
        return View(
            new WitajViewModel() { Imię = imię, Ilość = id }
            );
    }
}
