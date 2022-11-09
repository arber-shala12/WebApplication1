using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student studenti1 = new Student(emri:Blend , mbiemri:Krasniqi )

            return View(studenti1);
        }
        public IActionResult pershendete()
        {
            string emri = "Ardit Hyseni";
            return View(emri);
        }
    }
}
