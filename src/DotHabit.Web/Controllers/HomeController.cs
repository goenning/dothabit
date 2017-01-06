using Microsoft.AspNetCore.Mvc;

namespace DotHabit.Web.Controllers
{
    [Route("")]
    public class HomeController : Controller 
    {
        [Route("")]
        public IActionResult Index() 
        {
            ViewBag.Message = "Powered by ASP.NET Core MVC";
            return View();
        }
    }
}