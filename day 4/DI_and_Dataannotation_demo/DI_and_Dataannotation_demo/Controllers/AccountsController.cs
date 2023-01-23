using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using DI_and_Dataannotation_demo.Models;

namespace DI_and_Dataannotation_demo.Controllers
{
    public class AccountsController : Controller
    {
        //this is a crime, not a good practice
        // Accounts accObj = new Accounts(); 

        Accounts _accObj;

        public AccountsController(Accounts accObjREF)
        {
            this._accObj = accObjREF;
        }

        public IActionResult DisplayAccounts()
        {
            ViewBag.allAccounts = _accObj.GetAllAccounts();
            return View();
        }
    }
}
