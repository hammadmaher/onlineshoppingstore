using Microsoft.AspNetCore.Mvc;

namespace Hammad.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
        public IActionResult form()
        {
            return View();
        }
    }
}
