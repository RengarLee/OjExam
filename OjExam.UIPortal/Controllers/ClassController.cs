using OjExam.BLL;
using OjExam.IBLL;
using OjExam.Model;
using OjExam.UIPortal.Fliters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OjExam.UIPortal.Controllers
{
    public class ClassController : Controller
    {
        short delNormal = (short)Model.Enum.DelFlagEnum.Normal;
        private IClassService ClassService = new ClassService();

        // GET: Calss
        #region Query
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetList()
        {
            int offset = int.Parse(Request["offset"] ?? "0");
            int pageSize = int.Parse(Request["limit"] ?? "20");
            int pageIndex = (offset / pageSize) + 1;
            var Data = ClassService.GetPageEntities(pageIndex, pageSize, out int total, u => u.DelFlag == delNormal, u => u.Id, true).Select(u => new { u.Id, u.Name }).ToList();
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
            Class c = new Class
            {
                Name = Request["name"],
                DelFlag = delNormal
            };
            if (ClassService.Add(c))
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
            Class c = ClassService.GetEntities(u => u.Id == id).FirstOrDefault();
            c.Name = Request["name"];
            if (ClassService.Updata(c))
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
            Class c = ClassService.GetEntities(u => u.Id == id).FirstOrDefault();
            if (ClassService.Delete(c))
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
