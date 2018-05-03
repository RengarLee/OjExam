using OjExam.BLL;
using OjExam.IBLL;
using OjExam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OjExam.UIPortal.Controllers
{
    public class AdminController : Controller
    {
        private IAdminService AdminService = new AdminService();
        public ActionResult Index()
        {
            Admin admin = Session["User"] as Admin;
            ViewData.Model = AdminService.GetEntities(u => u.Id == admin.Id).FirstOrDefault();
            return View();
        }
    }
}