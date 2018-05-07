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
    public class TeacherController : Controller
    {
        short delNormal = (short)Model.Enum.DelFlagEnum.Normal;
        private ITeacherService TeacherService = new TeacherService();

        #region Query
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TeacherManger()
        {
            return View();
        }

        public JsonResult GetList()
        {
            int offset = int.Parse(Request["offset"] ?? "0");
            int pageSize = int.Parse(Request["limit"] ?? "20");
            int pageIndex = (offset / pageSize) + 1;
            var Data = TeacherService.GetPageEntities(pageIndex, pageSize, out int total, u => u.DelFlag == delNormal, u => u.Id, true).Select(u => new { u.Id, u.Name,u.TeaId }).ToList();
            return Json(new { total = total, rows = Data }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(int id)
        {
            return View();
        }
        #endregion

        #region Cretae
        public ActionResult Create()
        {
            Teacher c = new Teacher
            {
                Name = Request["Name"],
                DelFlag = delNormal,
                Pwd = Request["TeaId"],
                TeaId = Request["TeaId"]
            };
            if (TeacherService.Add(c))
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
            Teacher c = TeacherService.GetEntities(u => u.Id == id).FirstOrDefault();
            c.Name = Request["name"];
            if (TeacherService.Updata(c))
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
            Teacher c = TeacherService.GetEntities(u => u.Id == id).FirstOrDefault();
            if (TeacherService.Delete(c))
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