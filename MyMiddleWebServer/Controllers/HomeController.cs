using ActionResultExample.ActionResults;

namespace ActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cont()
        {
            return Content();
        }

        public IActionResult GetJson()
        {
            return Json();
        }

        public IActionResult Nothing()
        {
            return Empty();
        }

        public IActionResult Pdf()
        {
            return File();
        }

        public IActionResult Rdt()
        {
            return Redirect();
        }
    }
}
