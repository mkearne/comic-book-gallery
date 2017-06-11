using System;
using System.Web.Mvc;

namespace ComicBookGallary.Controllers
{
    public class ComicBooksController : System.Web.Mvc.Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                return Redirect("/");
            };

            return Content("Hello from the controller");
            
        }
    }
}