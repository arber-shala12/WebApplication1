using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders.Embedded;

namespace WebApplication1.Controllers
{
    public class Profesor : Controller
    {
        public IActionResult Index()
        {
            Profesor prof = new Profesor("Leron , mbi");
            return View();
        }
    }
}
