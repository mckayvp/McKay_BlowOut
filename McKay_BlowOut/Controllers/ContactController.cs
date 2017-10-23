using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace McKay_BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public string Index()
        {
            //return View(); ActionResult
            return "<p>Please call support at <b><u>801-555-1212</u></b>. Thank you!</p>";
        }


        //GET: Email
        public string Email(string name, string email)
        {
            return "<p>Thank you " + name + ". We will sent you an email to " + email + "</p>";
        }

    }
}