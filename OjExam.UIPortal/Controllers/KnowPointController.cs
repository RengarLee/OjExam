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
    public class KnowPointController : Controller
    {
        short delNormal = (short)Model.Enum.DelFlagEnum.Normal;
        private IKnowPointService KnowPointService = new KnowPointService();
        private ICourserService CourserService = new CourserService();
        // GET: Calss
        #region Query
        public ActionResult Index()
        {
            var Course = CourserService.GetEntities(u => u.DelFlag == delNormal).AsQueryable();
            ViewBag.CourserId = (from u in Course select new SelectListItem() { Text = u.Name, Value = u.Id + "" }).ToList();
            return View();
        }

        public JsonResult GetList()
        {
            int offset = int.Parse(Request["offset"] ?? "0");
            int pageSize = int.Parse(Request["limit"] ?? "20");
            int pageIndex = (offset / pageSize) + 1;
            var Data = KnowPointService.GetPageEntities(pageIndex, pageSize, out int total, u => u.DelFlag == delNormal, u => u.Id, true).Select(u => new { u.Id, u.Name,CourseName = u.Courser.Name }).ToList();
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
            KnowPoint c = new KnowPoint();
            c.Name = Request["Name"];
            c.CourserId = Convert.ToInt32(Request["CourserId"]);
            c.DelFlag = delNormal;
            if (KnowPointService.Add(c))
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
            KnowPoint c = KnowPointService.GetEntities(u => u.Id == id).FirstOrDefault();
            c.Name = Request["name"];
            if (KnowPointService.Updata(c))
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
            KnowPoint c = KnowPointService.GetEntities(u => u.Id == id).FirstOrDefault();
            if (KnowPointService.Delete(c))
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