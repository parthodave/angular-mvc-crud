using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        
        [Route("create-user")]
        // GET: User
        public ActionResult CreateUser()
        {
            return View();
        }
    }
}