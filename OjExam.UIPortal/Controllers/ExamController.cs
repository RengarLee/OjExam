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
    public class ExamController : Controller
    {

        short delNormal = (short)Model.Enum.DelFlagEnum.Normal;
        short delDelete = (short)Model.Enum.DelFlagEnum.Delete;
        private IExamService ExamService = new ExamService();

        // GET: Exam
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Query()
        {
            return View();
        }

        public JsonResult GetList()
        {

            if ((int)Session["Type"] == 1)
            {
                Teacher teacher = Session["User"] as Teacher;
                var Data = ExamService.GetEntities(u => u.ClassTeacherCourser.TeacherId == teacher.Id).Select(u=>new { u.StartTime,u.EndTime,ClassName = u.ClassTeacherCourser.Class.Name, CourseName = u.ClassTeacherCourser.Courser.Name,u.Id }).ToList();
                return Json(Data, JsonRequestBehavior.AllowGet);
            } else if ((int)Session["Type"] == 2)
            {
                Student student = Session["User"] as Student;
                var Data = ExamService.GetEntities(u => u.ClassTeacherCourser.ClassId == student.ClassId).Select(u => new { u.StartTime, u.EndTime, ClassName = u.ClassTeacherCourser.Class.Name, CourseName = u.ClassTeacherCourser.Courser.Name, u.Id,TeacherName=u.ClassTeacherCourser.Teacher.Name }).ToList();
                return Json(Data, JsonRequestBehavior.AllowGet);
            }
            else {
                var Data = ExamService.GetEntities(u => true).Select(u => new { u.StartTime, u.EndTime, ClassName = u.ClassTeacherCourser.Class.Name, CourseName = u.ClassTeacherCourser.Courser.Name, u.Id, TeacherName = u.ClassTeacherCourser.Teacher.Name }).ToList();
                return Json(Data, JsonRequestBehavior.AllowGet);
            }
           
        }

        public ActionResult Create()
        {
            int Id = Convert.ToInt32(Request["Id"]);
            DateTime StartTime = Convert.ToDateTime(Request["StartTime"]);
            DateTime EndTime = Convert.ToDateTime(Request["EndTime"]);
            Exam exam = ExamService.GetEntities(u => u.Id==Id).FirstOrDefault();
            exam.StartTime = StartTime;
            exam.EndTime = EndTime;
            exam.DelFlag = delNormal;
            if (ExamService.Updata(exam))
            {
                return Content("success");
            }
            else
            {
                return Content("fail");
            }
        }

    }
}