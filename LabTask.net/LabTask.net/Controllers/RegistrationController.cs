using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask.net.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Registration ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string name, string userId, string password, string id, string email, DateTime dob)
        {

            return RedirectToAction("RegistrationSuccess");
        }

        public ActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}
    
