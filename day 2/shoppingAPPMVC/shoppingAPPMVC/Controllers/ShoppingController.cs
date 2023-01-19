using Microsoft.AspNetCore.Mvc;
using shoppingAPPMVC.Models;
namespace shoppingAPPMVC.Controllers
{
    public class ShoppingController : Controller
    {
      
        public IActionResult Products()
        {
            //collect data from Model, in a ViewBag
            //pass the data to model, in a method from model



            //this is a very wrong approach
            //controller is suppose to get the data from Model and not declare the data
            List<string> topProducts = new List<string>()
            {
                "Pepsi","Coke","Superdry","Puma","Nike","Apple"
            };

            ViewBag.pList = topProducts;


            return View();
        }

        public IActionResult ProductDetails()
        {

            Models.ProductDetails pObj = new ProductDetails();
            ViewBag.pList = pObj.GetAllProducts();
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }


    }
}
