using OjExam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OjExam.IBLL
{
    public partial interface IProblemService
    {
        List<Problem> RandomList(int courseId);
    }
}
