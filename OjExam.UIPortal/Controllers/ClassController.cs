using OjExam.BLL;
using OjExam.IBLL;
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
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetList()
        {
            int pageIndex = int.Parse(Request["pageIndex"] ?? "1");
            int pageSize = int.Parse(Request["limit"] ?? "20");
            var Data = ClassService.GetPageEntities(pageIndex, pageSize, out int total, u =>u.DelFlag==delNormal, u => u.Id, true).Select(u => new { u.Id, u.Name }).ToList();
            return Json(new { total=total, rows = Data}, JsonRequestBehavior.AllowGet);
        }

        // GET: Calss/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calss/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calss/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Calss/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calss/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Calss/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Calss/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
