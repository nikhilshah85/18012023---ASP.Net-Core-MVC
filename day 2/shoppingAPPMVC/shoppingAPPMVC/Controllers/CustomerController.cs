using Microsoft.AspNetCore.Mvc;

namespace shoppingAPPMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerProfile()
        {
            //this is a very wrong approach
            //controller is suppose to get the data from Model and not declare the data
            ViewBag.customerName = "Nikhil Shah";
            ViewBag.customerCity = "Mumbai";
            ViewBag.customerContact = 687545748;
            ViewBag.customerIsActive = true;

            return View();
        }

        public IActionResult Wallet()
        {
            return View();
        }
    }
}
