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
    public class GradeController : Controller
    {
        short delNormal = (short)Model.Enum.DelFlagEnum.Normal;
        short delDelete = (short)Model.Enum.DelFlagEnum.Delete;
        private IExamService ExamService = new ExamService();
        private IGradeService GradeService = new GradeService();

        // GET: Grade
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfStudent()
        {
            return View();
        }

        public JsonResult GetList()
        {
            if ((int)Session["Type"] == 1)
            {
                var Data = "s";
                //Teacher teacher = Session["User"] as Teacher;
                //var Data = GradeService.GetEntities(u => u.ClassTeacherCourser.TeacherId == teacher.Id).Select(u => new { u.Exam.StartTime, u.Exam.EndTime, ClassName = u.Exam.ClassTeacherCourser.Class.Name, CourseName = u.Exam.ClassTeacherCourser.Courser.Name, u.Id, TeacherName = u.Exam.ClassTeacherCourser.Teacher.Name, u.Score }).ToList();
                return Json(Data, JsonRequestBehavior.AllowGet);
            }
            else if ((int)Session["Type"] == 2)
            {
                Student student = Session["User"] as Student;
                var Data = GradeService.GetEntities(u => u.StudentId == student.Id).Select(u => new { u.Exam.StartTime, u.Exam.EndTime, ClassName = u.Exam.ClassTeacherCourser.Class.Name, CourseName = u.Exam.ClassTeacherCourser.Courser.Name, u.Id, TeacherName = u.Exam.ClassTeacherCourser.Teacher.Name,u.Score}).ToList();
                return Json(Data, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var Data = "s";
                //var Data = GradeService.GetEntities(u => true).Select(u => new { u.StartTime, u.EndTime, ClassName = u.ClassTeacherCourser.Class.Name, CourseName = u.ClassTeacherCourser.Courser.Name, u.Id, TeacherName = u.ClassTeacherCourser.Teacher.Name }).ToList();
                return Json(Data, JsonRequestBehavior.AllowGet);
            }
        }
    }
}