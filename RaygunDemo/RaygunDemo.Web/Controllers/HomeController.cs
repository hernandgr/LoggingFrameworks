using System;
using System.Web.Mvc;

namespace RaygunDemo.Web.Controllers
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