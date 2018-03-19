
﻿

 


using System;

using System.Collections.Generic;

using System.Data;

using System.Linq;

using System.Linq.Expressions;

using System.Text;

using System.Threading.Tasks;

using OjExam.IDAL;

using OjExam.Model;



namespace OjExam.EFDAL

{ 

		

	public partial class AdminSetDal:BaseDal<AdminSet>,IAdminSetDal

    {

	}

		

	public partial class ClassDal:BaseDal<Class>,IClassDal

    {

	}

		

	public partial class ClassTeacherCourserDal:BaseDal<ClassTeacherCourser>,IClassTeacherCourserDal

    {

	}

		

	public partial class CourserDal:BaseDal<Courser>,ICourserDal

    {

	}

		

	public partial class ExamSetDal:BaseDal<ExamSet>,IExamSetDal

    {

	}

		

	public partial class GradeDal:BaseDal<Grade>,IGradeDal

    {

	}

		

	public partial class KnowPointSetDal:BaseDal<KnowPointSet>,IKnowPointSetDal

    {

	}

		

	public partial class ProblemDal:BaseDal<Problem>,IProblemDal

    {

	}

		

	public partial class StatusSetDal:BaseDal<StatusSet>,IStatusSetDal

    {

	}

		

	public partial class StudentDal:BaseDal<Student>,IStudentDal

    {

	}

		

	public partial class TeacherDal:BaseDal<Teacher>,ITeacherDal

    {

	}


}