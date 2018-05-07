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
    public class StudentController : Controller
    {
        short delNormal = (short)Model.Enum.DelFlagEnum.Normal;
        private IStudentService StudentService = new StudentService();
        private IClassService ClassService = new ClassService();

        // GET: Calss
        #region Query
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentManger()
        {
            var Class = ClassService.GetEntities(u => u.DelFlag == delNormal).AsQueryable();
            ViewBag.ClassId = (from u in Class select new SelectListItem() { Text = u.Name, Value = u.Id + "" }).ToList();
            return View();
        }

        public JsonResult GetList()
        {
            int offset = int.Parse(Request["offset"] ?? "0");
            int pageSize = int.Parse(Request["limit"] ?? "20");
            int pageIndex = (offset / pageSize) + 1;
            var Data = StudentService.GetPageEntities(pageIndex, pageSize, out int total, u => u.DelFlag == delNormal, u => u.Id, true).Select(u => new { u.Id, u.Name, u.StuId,ClassName=u.Class.Name }).ToList();
            return Json(new { total = total, rows = Data }, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Cretae
        public ActionResult Create()
        {
            Student c = new Student
            {
                Name = Request["Name"],
                DelFlag = delNormal,
                StuId = Request["StuId"],
                Pwd = Request["StuId"],
                ClassId = Convert.ToInt32(Request["ClassId"]),  
            };
            if (StudentService.Add(c))
            {
                return Content("success");
            }
            else
            {
                return Content("fail");
            }
        }
        #endregion

        #region Edit

        public ActionResult Edit()
        {
            int id = Convert.ToInt32(Request["id"]);
            Student c = StudentService.GetEntities(u => u.Id == id).FirstOrDefault();
            c.Name = Request["name"];
            if (StudentService.Updata(c))
            {
                return Content("success");
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
            Student c = StudentService.GetEntities(u => u.Id == id).FirstOrDefault();
            if (StudentService.Delete(c))
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