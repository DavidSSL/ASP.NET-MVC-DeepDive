using System.Web.Mvc;

namespace CustomRouteConstraint.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult List(int year, int month, int day)
        {
            return Content(string.Format("You've just hit BlogController.List with year: {0}, month: {1} and day: {2}", year, month, day));
        }
    }
}
