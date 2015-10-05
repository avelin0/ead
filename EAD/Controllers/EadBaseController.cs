using EAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Net;

namespace EAD.Controllers
{
    public class EadBaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (User != null)
            {
                string id = User.Identity.GetUserId();
                if (id != null)
                {
                    var db = new EadContext();
                    Student student = db.Students.Find(id);
                    ViewData.Add("Name", student.Name);
                }
            }
            base.OnActionExecuted(filterContext);
        }
        public EadBaseController()
        { }
    }
}