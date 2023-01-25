using Microsoft.AspNetCore.Mvc;

namespace Layoutview_partialview.Controllers
{
    public class BankingController : Controller
    {
      public IActionResult BankingHome()
        {
            return View();
        }

        public IActionResult Transfer()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Accounts()
        {
            return View();
        }
    }
}
