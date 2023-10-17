
// indicamos que utilizaremos aspnetcore y mvc
using Microsoft.AspNetCore.Mvc;

namespace ProyectoPelis.controller;


public class PrincipalController : Controller
{

    //agregamos las rutas de esta forma
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
       
        ViewBag.CurrentTime = DateTime.Now;
        return View("Index");
    }


}
