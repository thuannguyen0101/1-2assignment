using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lab3.Data;
using lab3.Models;

namespace lab3.Controllers
{
    public class AuthController : Controller
    {
        private UserContext db = new UserContext();

        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
    }
}
