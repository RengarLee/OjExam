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
    public class ClassTeacherCourserController : Controller
    {
        short delNormal = (short)Model.Enum.DelFlagEnum.Normal;
        short delDelete = (short)Model.Enum.DelFlagEnum.Delete;
        private IClassTeacherCourserService ClassTeacherCourserService = new ClassTeacherCourserService();
        private IClassService ClassService = new ClassService();
        private ITeacherService TeacherService = new TeacherService();
        private ICourserService CourserService = new CourserService();
        private IExamService ExamService = new ExamService();
        // GET: Calss
        #region Query
        public ActionResult Index()
        {
            var Class = ClassService.GetEntities(u => u.DelFlag == delNormal).AsQueryable();
            ViewBag.ClassId = (from u in Class select new SelectListItem() { Text = u.Name, Value = u.Id + "" }).ToList();
            var Teacher = TeacherService.GetEntities(u => u.DelFlag == delNormal).AsQueryable();
            ViewBag.TeacherId = (from u in Teacher select new SelectListItem() { Text = u.Name, Value = u.Id + "" }).ToList();
            var Course = CourserService.GetEntities(u => u.DelFlag == delNormal).AsQueryable();
            ViewBag.CourseId = (from u in Course select new SelectListItem() { Text = u.Name, Value = u.Id + "" }).ToList();

            return View();
        }

        public JsonResult GetList()
        {
            int offset = int.Parse(Request["offset"] ?? "0");
            int pageSize = int.Parse(Request["limit"] ?? "20");
            int pageIndex = (offset / pageSize) + 1;
            var Data = ClassTeacherCourserService.GetPageEntities(pageIndex, pageSize, out int total, u => u.DelFlag == delNormal, u => u.Id, true).Select(u => new { u.Id, TeacherName=u.Teacher.Name, CourseName= u.Courser.Name, ClassName = u.Class.Name }).ToList();
            return Json(new { total = total, rows = Data }, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Cretae
        public ActionResult Create()
        {
            ClassTeacherCourser c = new ClassTeacherCourser
            {
                TeacherId = Convert.ToInt32(Request["TeacherId"]),
                CourserId = Convert.ToInt32(Request["CourseId"]),
                ClassId = Convert.ToInt32(Request["ClassId"]),
                DelFlag = delNormal,
            };

            if (ClassTeacherCourserService.Add(c))
            {
                Exam e = new Exam
                {
                    ClassTeacherCourser_Id = c.Id,
                    DelFlag = delDelete,
                };
                if (ExamService.Add(e))
                {
                    return Content("success");
                }
                return Content("fail");
            }
            else
            {
                return Content("fail");
            }
        }
        #endregion

        #region Delete

        public ActionResult Delete()
        {
            int id = Convert.ToInt32(Request["id"]);
            ClassTeacherCourser c = ClassTeacherCourserService.GetEntities(u => u.Id == id).FirstOrDefault();
            if (ClassTeacherCourserService.Delete(c))
            {
                return Content("success");
            }
            else
            {
                return Content("fail");
            }
        }
        #endregion
    }
}
