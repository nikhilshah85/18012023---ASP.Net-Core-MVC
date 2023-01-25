using Microsoft.AspNetCore.Mvc;
using API_Call_ServerSide.Models;
namespace API_Call_ServerSide.Controllers
{
    public class ExternalDataController : Controller
    {

        //This is a bad code, i promise never to use this in my Project, I will use DI
        //CommentsData commentsObj = new CommentsData();

        CommentsData _commentsObj;

        public ExternalDataController(CommentsData commentsObjREF)
        {
            _commentsObj = commentsObjREF;
        }


        public IActionResult ShowCommentsData()
        {
            ViewBag.comments = _commentsObj.GetCommentsData();
            return View();
        }





    }
}
