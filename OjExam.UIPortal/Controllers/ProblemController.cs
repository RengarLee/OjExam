using OjExam.BLL;
using OjExam.IBLL;
using OjExam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace OjExam.UIPortal.Controllers
{
    public class ProblemController : Controller
    {
        short delNormal = (short)Model.Enum.DelFlagEnum.Normal;
        short delNotStart = (short)Model.Enum.DelFlagEnum.NotStart;
        short delBeing = (short)Model.Enum.DelFlagEnum.Being;
        private IProblemService ProblemService = new ProblemService();
        private IKnowPointService KnowPointService = new KnowPointService();
        private ICourserService CourserService = new CourserService();
        private IGradeService GradeService = new GradeService();
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

        public ActionResult ProblemList(int id)
        {

            Student student = Session["User"] as Student;
            Grade grade = GradeService.GetEntities(u => u.Id == id).FirstOrDefault();
            ViewBag.GradeId = grade.Id;
            int CourseId = grade.Exam.ClassTeacherCourser.CourserId;
            List<Problem> problemlist = null;
            if (grade.DelFlag == delNotStart)
            {
                problemlist = ProblemService.RandomList(CourseId);
                StringBuilder sb = new StringBuilder();
                foreach (var problem in problemlist)
                {
                    sb.Append("," + problem.Id);
                }
                sb.Append(",");
                grade.Problems = sb.ToString();
                grade.DelFlag = delBeing;
                GradeService.Updata(grade);
            }
            else
            {
                problemlist = ProblemService.GetEntities(u => grade.Problems.Contains("," + u.Id + ",")).ToList();
            }
            ViewData["Problems"] = problemlist;
            return View();
        }

        public ActionResult Submit()
        {
            int id = Convert.ToInt32(Request["id"]);
            Grade grade = GradeService.GetEntities(u => u.Id == id).FirstOrDefault();
            String Problems = grade.Problems;
            List<String> proIds = Problems.Split(',').ToList();
            int num = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var proid in proIds)
            {
                if (proid != "")
                {
                    int iproId = Convert.ToInt32(proid);
                    if (Request[proid].Equals(ProblemService.GetEntities(u => u.Id == iproId).FirstOrDefault().Answer))
                    {
                        num++;
                    }
                    sb.Append(","+Request[proid]);
                }
            }
            grade.Score = (num * 25).ToString();
            sb.Append(",");
            grade.Answers = sb.ToString();
            return Content("success");
        }
    }
}