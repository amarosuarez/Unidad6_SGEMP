using Microsoft.AspNetCore.Mvc;

namespace Ej01U06.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}
