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
    public class UserLoginController : Controller
    {
        public short delFlagNormal = (short)OjExam.Model.Enum.DelFlagEnum.Normal;
        public ITeacherService TeacherService = new TeacherService();
        public IAdminService AdminService = new AdminService();
        public IStudentService StudentService = new StudentService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            string LoginId = Request["LoginId"];
            string Pwd = Request["Pwd"];
            Admin admin = AdminService.GetEntities(u => u.LName == LoginId && u.Pwd.Equals(Pwd) && u.DelFlag == delFlagNormal).FirstOrDefault();
            Teacher teacher = TeacherService.GetEntities(t => t.TeaId == LoginId && t.Pwd.Equals(Pwd) && t.DelFlag == delFlagNormal).FirstOrDefault();
            Student student = StudentService.GetEntities(s => s.StuId == LoginId && s.Pwd.Equals(Pwd) && s.DelFlag == delFlagNormal).FirstOrDefault();
            if (admin != null)
            {
                Session["User"] = admin;
                return Redirect("/Admin/Index");
            }
            if (teacher != null)
            {
                Session["User"] = teacher;
                return Redirect("/Teacher/Index");
            }
            if(student != null)
            {
                Session["User"] = student;
                return Redirect("/Student/Index");
            }
            return Content("fail");
        }

        public ActionResult Exit()
        {
            Session["User"] = null;
            return Redirect("/UserLogin/Index");
        }
    }
}