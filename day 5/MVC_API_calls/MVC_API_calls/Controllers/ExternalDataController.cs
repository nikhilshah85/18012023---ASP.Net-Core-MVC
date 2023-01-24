using Microsoft.AspNetCore.Mvc;

namespace MVC_API_calls.Controllers
{
    public class ExternalDataController : Controller
    {
    
        public IActionResult PostData()
        {
            return View();
        }

        public IActionResult PhotosData()
        {
            return View();
        }
    }
}
