
using OjExam.IBLL;
using OjExam.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OjExam.BLL
{
    public partial class ProblemService:BaseService<Problem>,IProblemService
    {
        public List<Problem>  RandomList(int courseId)
        {
            short delNormal = (short)Model.Enum.DelFlagEnum.Normal;
            List<Problem> Result = new List<Problem>();
            Random random = new Random();
            List<Problem> list = GetEntities(u => u.DelFlag == delNormal && u.KnowPoint.CourserId == courseId).ToList();
            var KnowPoint = DbSession.KnowPointDal.GetEntities(u => u.CourserId == courseId).ToList();
            foreach(var know in KnowPoint)
            {
                var t = list.Where(u => u.KnowPointId == know.Id).ToList();
                var Count = t.Count();
                //取一题
                Result.Add(t[random.Next(0, Count)]);
            }
            return Result;
        }
    }
}