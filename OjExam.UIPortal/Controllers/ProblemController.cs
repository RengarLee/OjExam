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
    public class ProblemController : Controller
    {
        short delNormal = (short)Model.Enum.DelFlagEnum.Normal;
        private IProblemService ProblemService = new ProblemService();
        private IKnowPointService KnowPointService = new KnowPointService();
        private ICourserService CourserService = new CourserService();
        // GET: Problem
        public ActionResult Index()
        {
            var KnowPoint = KnowPointService.GetEntities(u => u.DelFlag == delNormal).AsQueryable();
            ViewBag.KnowPointId = (from u in KnowPoint select new SelectListItem() { Text = u.Name, Value = u.Id + "" }).ToList();
            return View();
        }

        public JsonResult GetList()
        {
            int offset = int.Parse(Request["offset"] ?? "0");
            int pageSize = int.Parse(Request["limit"] ?? "20");
            int pageIndex = (offset / pageSize) + 1;
            var Data = ProblemService.GetPageEntities(pageIndex, pageSize, out int total, u => u.DelFlag == delNormal, u => u.Id, true).Select(u => new { u.Id, u.Answer,KonwPointName = u.KnowPoint.Name }).ToList();
            return Json(new { total = total, rows = Data }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            int KnowPointId = Convert.ToInt32(Request["KnowPointId"]);
            String Answer = Request["Answer"];
            String src = Request["src"];
            Problem problem = new Problem();
            problem.Answer = Answer;
            problem.DelFlag = delNormal;
            problem.Src = src;
            problem.KnowPointId = KnowPointId;
            if (ProblemService.Add(problem))
            {
                return Content("success");
            }
            else
            {
                return Content("fail");
            }
        }

        public JsonResult UploadImage()
        {
            var file = Request.Files["file"];
            string path = "/Content/UploadImgs/" + Guid.NewGuid().ToString() + "-" + file.FileName;
            file.SaveAs(Request.MapPath(path));
            return Json(new { msg="success", src=path},JsonRequestBehavior.AllowGet);
        }

        public JsonResult QueryImage(int id)
        {
            var temp = ProblemService.GetEntities(u => u.Id == id).FirstOrDefault();
            return Json(new { title = "1", id = 1, start =0, data = new { alt = "1", pid = "1", src = temp.Src, thumb = temp.Src } }, JsonRequestBehavior.AllowGet);
        }
    }
}