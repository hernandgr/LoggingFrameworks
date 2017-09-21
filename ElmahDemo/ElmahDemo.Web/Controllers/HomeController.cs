using System;
using System.Web.Mvc;

namespace ElmahDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            throw new Exception("Oops!");
        }
    }
}