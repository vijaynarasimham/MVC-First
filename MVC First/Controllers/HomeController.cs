using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_First.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index(string ID, string name)
        {
            return "Hello World... This is MVC application " + "ID:" + ID + " Name:" + name;
        }

        public string Version()
        {
            return typeof(Controller).Assembly.GetName().Version.ToString();
        }
    }
}