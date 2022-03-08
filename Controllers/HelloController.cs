using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/

        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }

        //
        // GET: /Goodbye/

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
