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
        public ITeacherService TeacherService { get; set; }
        public IAdminService AdminService { get; set; }
        public IStudentService StudentService { get; set; }
        // GET: UserLogin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            string LoginId = Request["LoginId"];
            string Pwd = Request["Pwd"];
            Admin admin = AdminService.GetEntities(u => u.LName == LoginId && u.Pwd== Pwd && u.DelFlag == delFlagNormal).FirstOrDefault();
            Teacher teacher = TeacherService.GetEntities(t => t.TeaId == LoginId && t.Pwd == Pwd && t.DelFlag == delFlagNormal).FirstOrDefault();
            Student student = StudentService.GetEntities(s => s.StuId == LoginId && s.Pwd == Pwd && s.DelFlag == delFlagNormal).FirstOrDefault();
            if (admin != null)
            {
                return Redirect("/Admin/Index");
            }
            if (teacher != null)
            {
                return Redirect("/Teacher/Index");
            }
            if(student != null)
            {
                return Redirect("/Student/Index");
            }
            return Content("ok");
        }
        
    }
}