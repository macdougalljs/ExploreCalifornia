using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()  // this is an action that defines all of controller logic when it's time to process the request;  this response is tied to the names of the controller and the action that was created
        {
            return View();
        }
    }
}
